using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Management;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class RegresarButton : MonoBehaviour
    {
        [SerializeField]
        GameObject m_BackButton;
        public GameObject backButton
        {
            get { return m_BackButton; }
            set { m_BackButton = value; }
        }

        void Start()
        {
            if (Application.CanStreamedLevelBeLoaded("InicioSesionCuratore"))
            {
                m_BackButton.SetActive(true);
            }
        }

        public void BackButtonPressed()
        {
            SceneManager.LoadScene("InicioSesionCuratore", LoadSceneMode.Single);
            LoaderUtility.Deinitialize();
        }
    }
}