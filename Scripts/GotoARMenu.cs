using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


namespace UnityEngine.XR.ARFoundation.Samples
{
    public class GotoARMenu : MonoBehaviour
    {
        // Start is called before the first frame update

        //public DBManager _dBManager;

        private void Start()
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }

        /* private void Update()
         {
             if (_dBManager.claseDatosUser.tokenID != null) 

             {
                 LoadScene("Menu_WB");

             }

         }*/
        static void LoadScene(string sceneName)
        {
            LoaderUtility.Initialize();
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        public void ARCuratoreButtonPressed()
        {
            LoadScene("ARCuratore");

        }
       


    }
}