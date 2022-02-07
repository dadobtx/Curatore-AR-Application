using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Google;
using UnityEngine;
using UnityEngine.UI;
//using Facebook.Unity;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class GoogleSignInDemo : MonoBehaviour
{
    public static event Action<bool> SignInAction = delegate { };
    public static event Action<object, EventArgs> AuthStateChanged = delegate { };
    public Text infoText;
    public string webClientId = "<your client id here>";
    public bool IsInicialized => isInicialized;
    private FirebaseAuth auth;
    private GoogleSignInConfiguration configuration;
    private bool isInicialized = false;
   // public DBManager _dbManager;
   
    private void Awake()
    {
        // RequestEmail is true if you want to get the email adress, else false.
        configuration = new GoogleSignInConfiguration { WebClientId = webClientId, RequestEmail = true, RequestIdToken = true };
        CheckFirebaseDependencies();
        
        //FB.Init(InitCallBack, OnHideUnity);
       
    }

    private void CheckFirebaseDependencies()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            if (task.IsCompleted)
            {
                if (task.Result == DependencyStatus.Available)
                    auth = FirebaseAuth.DefaultInstance;
                else
                    AddToInformation("Could not resolve all Firebase dependencies: " + task.Result.ToString());
            }
            else
            {
                AddToInformation("Dependency check was not completed. Error : " + task.Exception.Message);
            }
        });
    }

    /*
    private void InitCallBack()
    {
        if (FB.IsInitialized)
        {
            FB.ActivateApp();
            isInicialized = true;
            AddToInformation("Facebook Inicialized");
        }
        else
        {
            AddToInformation("Fail Facebook Inicialized");
        }
    }
    private void OnHideUnity(bool isUnityShown)
    {
        if (isUnityShown) FB.ActivateApp();
    }

    private static void AuthOnStateChanged(object sender, EventArgs e)
    {
        AuthStateChanged(sender, e);
    }*/

    // these 2 functions are called when clicking the button from unity.
    public void SignInWithGoogle() { OnSignIn(); }
    public void SignOutFromGoogle() { OnSignOut(); }

    //public void SignInWithFacebook() { OnSignIn_FB(); }
    //public void SignOutFromFacebook() { OnSignOut_FB(); }
    public void SignInWithAnonymus() { OnSignIn_Anonymus(); }

    private void OnSignIn()
    {
        GoogleSignIn.Configuration = configuration;
        GoogleSignIn.Configuration.UseGameSignIn = false;
        GoogleSignIn.Configuration.RequestIdToken = true;
        AddToInformation("Calling SignIn");

        GoogleSignIn.DefaultInstance.SignIn().ContinueWith(OnAuthenticationFinished);
    }

    private void OnSignOut()
    {
        AddToInformation("Calling SignOut");
        GoogleSignIn.DefaultInstance.SignOut();
        FirebaseAuth.DefaultInstance.SignOut();
    }

    public void OnDisconnect()
    {
        AddToInformation("Calling Disconnect");
        GoogleSignIn.DefaultInstance.Disconnect();
    }

    /*
    private void OnSignIn_FB()
    {

        var perms = new List<String>() { "public_profile ", "email" };
        FB.LogInWithReadPermissions(perms, OnFacebookLoginResult);

    }

    private void OnFacebookLoginResult(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            var accessToken = AccessToken.CurrentAccessToken;
            SignInWithFacebookOnFirebase(accessToken);
            //AddToInformation(accessToken.TokenString);
        }
        else
        {
            SignInAction(false);
            AddToInformation("User cancel login");
        }
    }
    private void OnSignOut_FB()
    {


    }*/

    private void OnSignIn_Anonymus()
    {
        auth.SignInAnonymouslyAsync().ContinueWith(task => {
            if (task.IsCanceled)
            {
                AddToInformation("SignInAnonymouslyAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                AddToInformation("SignInAnonymouslyAsync encountered an error: " + task.Exception);
                return;
            }

            FirebaseUser newUser = task.Result;
            AddToInformation("User signed in successfully: {0} ({1})" + newUser.DisplayName + newUser.UserId);
            //claseDatos.tokenID = newUser.UserId;
            LoadScene("ARCuratore");
        });

    }
    static void LoadScene(string sceneName)
    {
        LoaderUtility.Initialize();
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    internal void OnAuthenticationFinished(Task<GoogleSignInUser> task)
    {
        // if it failed, then show the error. Else continue with firebase.
        if (task.IsFaulted)
        {
            using (IEnumerator<Exception> enumerator = task.Exception.InnerExceptions.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    GoogleSignIn.SignInException error = (GoogleSignIn.SignInException)enumerator.Current;
                    AddToInformation("Got Error: " + error.Status + " " + error.Message);
                }
                else
                {
                    AddToInformation("Got Unexpected Exception?!?" + task.Exception);
                }
            }
        }
        else if (task.IsCanceled)
        {
            AddToInformation("Canceled");
        }
        else
        {
            AddToInformation("Welcome: " + task.Result.DisplayName + "!");
            AddToInformation("Email = " + task.Result.Email);
            AddToInformation("Google ID Token = " + task.Result.IdToken);
            AddToInformation("Email = " + task.Result.Email);
            SignInWithGoogleOnFirebase(task.Result.IdToken);
        }
    }

    private void SignInWithGoogleOnFirebase(string idToken)
    {
        auth = FirebaseAuth.DefaultInstance;
        Credential credential = GoogleAuthProvider.GetCredential(idToken, null);

        auth.SignInWithCredentialAsync(credential).ContinueWith(task =>
        {
            AggregateException ex = task.Exception;
            // check for error.
            if (ex != null)
            {
                if (ex.InnerExceptions[0] is FirebaseException inner && (inner.ErrorCode != 0))
                    AddToInformation("\nError code = " + inner.ErrorCode + " Message = " + inner.Message);
            }
            else
            {
                AddToInformation("Sign In Successful.");
                //_dbManager.SaveDataUser(task.Result.Email, idToken);
                SaveDataUser(task.Result.Email, idToken);
                LoadScene("ARCuratore");
            }
        });
    }

    /*
    private void SignInWithFacebookOnFirebase(AccessToken accessToken)
    {
        

        Credential credential = FacebookAuthProvider.GetCredential(accessToken.TokenString);

        auth.SignInWithCredentialAsync(credential).ContinueWith(task =>
        {


            if (task.IsCanceled)
            {
                AddToInformation("Sign in cancelled" + task.Exception);
                SignInAction(false);
                return;
            }

            if (task.IsFaulted)
            {
                AddToInformation("Sign in error: " + task.Exception);
                Debug.Log("Sign in error: " + task.Exception);
                SignInAction(false);
                return;
            }

            FirebaseUser newUser = task.Result;
            
            AddToInformation("User Sign in:" + newUser.DisplayName + newUser.UserId + newUser.Email);
           
            SignInAction(true);
            Debug.Log("Sign in facebook " + newUser.Email);
            //_dbManager.SaveDataUser(newUser.Email, newUser.UserId);
            SaveDataUser(newUser.Email, newUser.UserId);
            Debug.Log("Sign in facebook " + newUser.Email);
            LoadScene("ARCuratore");

        });
    }*/

    // these 2 functions are currently not used in this demo. but you can use it as per your need.
    public void OnSignInSilently()
    {
        GoogleSignIn.Configuration = configuration;
        GoogleSignIn.Configuration.UseGameSignIn = false;
        GoogleSignIn.Configuration.RequestIdToken = true;
        AddToInformation("Calling SignIn Silently");

        GoogleSignIn.DefaultInstance.SignInSilently().ContinueWith(OnAuthenticationFinished);
    }

    public void OnGamesSignIn()
    {
        GoogleSignIn.Configuration = configuration;
        GoogleSignIn.Configuration.UseGameSignIn = true;
        GoogleSignIn.Configuration.RequestIdToken = false;

        AddToInformation("Calling Games SignIn");

        GoogleSignIn.DefaultInstance.SignIn().ContinueWith(OnAuthenticationFinished);
    }

    private void AddToInformation(string str) { infoText.text += "\n" + str; }

    public void SaveDataUser(string email, string tokenID)
    {

        Debug.Log("save data");
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

        Debug.Log("save data");
        string key = reference.Child("Users").Push().Key;
        UsersEntry entry = new UsersEntry(email, null, null, tokenID, DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("hh:mm:ss"));
        Dictionary<string, object> entryValues = entry.ToDictionary();
        Dictionary<string, object> childUpdates = new Dictionary<string, object>();
        childUpdates["/Users/" + key] = entryValues;
        reference.UpdateChildrenAsync(childUpdates);
        Debug.Log(entry.email);
        //emailrec = entry.email;
        //tokenIDrec = entry.tokenID;

    }
}