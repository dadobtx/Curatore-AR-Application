using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DBCambioColor : MonoBehaviour
{

    //public Material Haya, Wengue, Blanco, Cerezo;
    //public Button CafeButton, NegroButton,BlancoButton;
    public int selector = 0;
    public ClaseDatos claseDatos;
    //public AddessableSetting addessableSetting;
    public DBManager _dbManager;
    public AddessableSetting addessableSetting;
    // Start is called before the first frame update
    /*void LateUpdate()
    {
        var HayaButton = GameObject.Find("Haya").GetComponent<Button>();
        var WengueButton = GameObject.Find("Wengue").GetComponent<Button>();
        var BlancoButton = GameObject.Find("White").GetComponent<Button>();
        var CerezoButton = GameObject.Find("Cerezo").GetComponent<Button>();

        HayaButton.onClick.AddListener(TaskOnClick_Haya);
        //HayaButton.onClick.RemoveListener(TaskOnClick_Haya);
        WengueButton.onClick.AddListener(TaskOnClick_Wengue);
        //WengueButton.onClick.RemoveListener(TaskOnClick_Wengue);
        BlancoButton.onClick.AddListener(TaskOnClick_Blanco);
        //BlancoButton.onClick.RemoveListener(TaskOnClick_Blanco);
        CerezoButton.onClick.AddListener(TaskOnClick_Cerezo);
        //CerezoButton.onClick.RemoveListener(TaskOnClick_Cerezo);

        switch (selector)
        {
            case 4:
                //gameObject.GetComponent<Renderer>().material = Wengue;
                claseDatos.color = "Wengue";
                //_dbManager.AAA();
                break;

            case 3:
                //gameObject.GetComponent<Renderer>().material = Haya;
                claseDatos.color = "Haya";
                //_dbManager.AAA();
                break;

            case 2:
                //gameObject.GetComponent<Renderer>().material = Blanco;
                claseDatos.color = "Blanco";
                //_dbManager.AAA();
                break;

            case 1:
                //gameObject.GetComponent<Renderer>().material = Cerezo;
                claseDatos.color = "Cerezo";
                //_dbManager.AAA();
                break;

            default:
                //gameObject.GetComponent<Renderer>().material = Blanco;
                claseDatos.color = "Blanco";
                //_dbManager.AAA();
                break;

        }
    }*/

    public void TaskOnClick_Haya()
    {
        //var HayaButton = GameObject.Find("Haya").GetComponent<Button>();
        //selector = 3;
        //claseDatos.tipoMueble = addessableSetting.claseDatosTipoMueble.tipoMueble;
        claseDatos.color = "Haya";
        _dbManager.AAA(claseDatos.tipoMueble,claseDatos.color);
        //HayaButton.onClick.RemoveListener(TaskOnClick_Haya);
    }

    public void TaskOnClick_Wengue()
    {
        //selector = 4;
        //claseDatos.tipoMueble = addessableSetting.claseDatosTipoMueble.tipoMueble;
        claseDatos.color = "Wengue";
        _dbManager.AAA(claseDatos.tipoMueble, claseDatos.color);
    }

    public void TaskOnClick_Blanco()
    {
        //var BlancoButton = GameObject.Find("White").GetComponent<Button>();
        //selector = 2;
        //claseDatos.tipoMueble = addessableSetting.claseDatosTipoMueble.tipoMueble;
        claseDatos.color = "Blanco";
        _dbManager.AAA(claseDatos.tipoMueble, claseDatos.color);
        //BlancoButton.onClick.RemoveListener(TaskOnClick_Blanco);
    }

    public void TaskOnClick_Cerezo()
    {
        //selector = 1;
       //claseDatos.tipoMueble = addessableSetting.claseDatosTipoMueble.tipoMueble;
        claseDatos.color = "Cerezo";
        _dbManager.AAA(claseDatos.tipoMueble, claseDatos.color);

    }

    
}
