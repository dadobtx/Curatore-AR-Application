using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("The ARCameraManager which will produce frame events.")]
        ARCameraManager m_CameraManager;

        /// <summary>
        /// Get or set the <c>ARCameraManager</c>.
        /// </summary>
        public ARCameraManager cameraManager
        {
            get { return m_CameraManager; }
            set
            {
                if (m_CameraManager == value)
                    return;

                if (m_CameraManager != null)
                    m_CameraManager.frameReceived -= FrameChanged;

                m_CameraManager = value;

                if (m_CameraManager != null & enabled)
                    m_CameraManager.frameReceived += FrameChanged;
            }
        }

        const string k_FadeOffAnim = "FadeOff";
        const string k_FadeOnAnim = "FadeOn";

        //public string AnimaOn ;

        [SerializeField]
        ARPlaneManager m_PlaneManager;

        public ARPlaneManager planeManager
        {
            get { return m_PlaneManager; }
            set { m_PlaneManager = value; }
        }

        [SerializeField]
        Animator m_MoveDeviceAnimation;

        public Animator moveDeviceAnimation
        {
            get { return m_MoveDeviceAnimation; }
            set { m_MoveDeviceAnimation = value; }
        }

        [SerializeField]
        Animator m_TapToPlaceAnimation;

        public Animator tapToPlaceAnimation
        {
            get { return m_TapToPlaceAnimation; }
            set { m_TapToPlaceAnimation = value; }
        }

        [SerializeField]
        GameObject m_PlaneMoveDevice;

        public GameObject PlaneMoveDevice
        {
            get { return m_PlaneMoveDevice; }
            set { m_PlaneMoveDevice = value; }
        }

        [SerializeField]
        GameObject m_PlaneTapToPlace;
        public GameObject PlaneTapToPlace
        {
            get { return m_PlaneTapToPlace; }
            set { m_PlaneTapToPlace = value; }
        }

        

        static List<ARPlane> s_Planes = new List<ARPlane>();

        bool m_ShowingTapToPlace = false;

        bool m_ShowingMoveDevice = true;

        void OnEnable()
        {
            if (m_CameraManager != null)
                m_CameraManager.frameReceived += FrameChanged;

            //PlaceMultipleObjectsOnPlane.onPlacedObject += PlacedObject;
            PlaceOnPlane.onPlacedObject += PlacedObject;
        }

        void OnDisable()
        {
            if (m_CameraManager != null)
                m_CameraManager.frameReceived -= FrameChanged;

            //PlaceMultipleObjectsOnPlane.onPlacedObject -= PlacedObject;
            PlaceOnPlane.onPlacedObject += PlacedObject;
        }


        private void Awake()
        {
            //moveDeviceAnimation.SetBool("AnimaOn", true);
            PlaneMoveDevice.SetActive(true);
        }
        /*void FrameChanged(ARCameraFrameEventArgs args)
        {
            if (PlanesFound() && m_ShowingMoveDevice)
            {
                if (moveDeviceAnimation)
                    moveDeviceAnimation.SetTrigger(k_FadeOffAnim);

                if (tapToPlaceAnimation)
                    tapToPlaceAnimation.SetTrigger(k_FadeOnAnim);

                m_ShowingTapToPlace = true;
                m_ShowingMoveDevice = false;
            }
        }*/

        void FrameChanged(ARCameraFrameEventArgs args)
        {


            if (PlanesFound() && m_ShowingMoveDevice)
            {


                /*if (moveDeviceAnimation)
                {

                    moveDeviceAnimation.SetTrigger(k_FadeOffAnim);
                    moveDeviceAnimation.SetBool("AnimaOn", false);
                }
                if (tapToPlaceAnimation)
                {
                    tapToPlaceAnimation.SetTrigger(k_FadeOnAnim);
                    tapToPlaceAnimation.SetBool("AnimaOn", true);

                }*/

                PlaneMoveDevice.SetActive(false);

                PlaneTapToPlace.SetActive(true);

                m_ShowingTapToPlace = true;
                m_ShowingMoveDevice = false;
                
            }
        }

        bool PlanesFound()
        {
            
            if (planeManager == null)
           
               
                return false;
           
            
            return planeManager.trackables.count > 0;
        }

        void PlacedObject()
        {
            
            if (m_ShowingTapToPlace)
            {
                /*if (tapToPlaceAnimation)
                    tapToPlaceAnimation.SetTrigger(k_FadeOffAnim);
                tapToPlaceAnimation.SetBool("AnimaOn", false);*/
                PlaneTapToPlace.SetActive(false);
                m_ShowingTapToPlace = false;
            }
        }
    }
}