using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

//using Firebase.Unity;

using System;


public class DBManager : MonoBehaviour
{
    // Start is called before the first frame update

    private DatabaseReference reference;
    //public ClaseDatos claseDatos;
    //public ClaseDatosUser claseDatosUser;
    public ClaseDatosUser claseDatosUser;
    public AddessableSetting addessableSetting;
    public DBCambioColor cambioMaterial;
    //public GoogleSignInDemo googleSignInDemo1;
    public UsersEntry userEntry;
    


    //public string a = "cccc";
    //public string email = "dadobtx@gmail.com";
    //public string email1 = "dadobtx@gmail.com";
   // public string tokenID1 = "333";
    //public string tokenID2 = "333";
    static string emailrec;
    static string tokenIDrec;
    //public int entero = 20;
   // public int entero2 = 20;


    private void Awake()
    {
        //FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://wbarsignin.firebaseio.com/");
        //reference = FirebaseDatabase.DefaultInstance.RootReference;
        //DontDestroyOnLoad(gameObject);
        //FirebaseDatabase.GetInstance("https://curatorear-default-rtdb.firebaseio.com/") ;
        //reference = FirebaseDatabase.GetInstance().getReferenceFromUrl("https://curatorear-default-rtdb.firebaseio.com/");
     
        // FirebaseApp.DefaultInstance.Options.DatabaseUrl = new Uri("https://curatorear-default-rtdb.firebaseio.com/");
        reference = FirebaseDatabase.DefaultInstance.RootReference;
       

    }
    /*
    private void Update()
    {
        claseDatosUser.color = cambioMaterial.claseDatos.color;
    }*/

    public void TaskOnClick_Haya()
    {
        //var HayaButton = GameObject.Find("Haya").GetComponent<Button>();
        //selector = 3;
        //claseDatos.tipoMueble = addessableSetting.claseDatosTipoMueble.tipoMueble;
        claseDatosUser.color = "Haya";
        AAA(claseDatosUser.tipoMueble, claseDatosUser.color);
        //HayaButton.onClick.RemoveListener(TaskOnClick_Haya);
    }

    public void TaskOnClick_Wengue()
    {
        //selector = 4;
        //claseDatos.tipoMueble = addessableSetting.claseDatosTipoMueble.tipoMueble;
        claseDatosUser.color = "Wengue";
        AAA(claseDatosUser.tipoMueble, claseDatosUser.color);
    }

    public void TaskOnClick_Blanco()
    {
        //var BlancoButton = GameObject.Find("White").GetComponent<Button>();
        //selector = 2;
        //claseDatosUser.tipoMueble = addessableSetting.claseDatosTipoMueble.tipoMueble;
        claseDatosUser.color = "Blanco";
        AAA(claseDatosUser.tipoMueble, claseDatosUser.color);
        //BlancoButton.onClick.RemoveListener(TaskOnClick_Blanco);
    }

    public void TaskOnClick_Cerezo()
    {
        //selector = 1;
        //claseDatosUser.tipoMueble = addessableSetting.claseDatosTipoMueble.tipoMueble;
        claseDatosUser.color = "Cerezo";
        AAA(claseDatosUser.tipoMueble, claseDatosUser.color);

    }

    public void AAA(string tipoMueble,string color)
    {
       
        claseDatosUser.tipoMueble = tipoMueble;
        claseDatosUser.color = color;
        claseDatosUser.email = emailrec;
        claseDatosUser.tokenID = tokenIDrec;

        Debug.Log(claseDatosUser.email);

        string key = reference.Child("Users").Push().Key;

        UsersEntry entry = new UsersEntry(claseDatosUser.email, claseDatosUser.color, claseDatosUser.tipoMueble, claseDatosUser.tokenID, DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("hh:mm:ss"));
        Dictionary<string, object> entryValues = entry.ToDictionary();
        Dictionary<string, object> childUpdates = new Dictionary<string, object>();
       // childUpdates["/Users/" + key] = entryValues;
        childUpdates["/User-Data/" + claseDatosUser.color + "/" + key] = entryValues;
        reference.UpdateChildrenAsync(childUpdates);
    }

    public void SaveDataUser(string email,string tokenID)
    {

        

        
        string key = reference.Child("Users").Push().Key;
        UsersEntry entry = new UsersEntry(email, null, null, tokenID, DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("hh:mm:ss"));
        Dictionary<string, object> entryValues = entry.ToDictionary();
        Dictionary<string, object> childUpdates = new Dictionary<string, object>();
        childUpdates["/Users/" + key] = entryValues;
        reference.UpdateChildrenAsync(childUpdates);
        Debug.Log(entry.email);
        emailrec = entry.email;
        tokenIDrec = entry.tokenID;

    }

    


}
