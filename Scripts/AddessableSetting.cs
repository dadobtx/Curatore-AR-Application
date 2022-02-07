using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System;

public class AddessableSetting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AssetReference Mesa1;
    [SerializeField] AssetReference Mesa2;

    [SerializeField] AssetReference CamaV1;
    [SerializeField] AssetReference CamaV2;
    [SerializeField] AssetReference CamaV3;
    [SerializeField] AssetReference CamaV4;
    [SerializeField] AssetReference CamaV5;
    [SerializeField] AssetReference CamaV6;
    [SerializeField] AssetReference CamaV7;
    [SerializeField] AssetReference CamaV8;
    [SerializeField] AssetReference CamaV9;
    [SerializeField] AssetReference CamaV10;
    [SerializeField] AssetReference CamaV11;
    /*[SerializeField] AssetReference CamaV12;
    [SerializeField] AssetReference CamaV13;
    [SerializeField] AssetReference CamaV14;
    [SerializeField] AssetReference CamaV15;
    [SerializeField] AssetReference CamaV16;
    [SerializeField] AssetReference CamaV17;
    [SerializeField] AssetReference CamaV18;
    [SerializeField] AssetReference CamaV19;
    [SerializeField] AssetReference CamaV20;

    [SerializeField] AssetReference CamaH1;
    [SerializeField] AssetReference CamaH2;
    [SerializeField] AssetReference CamaH3;
    [SerializeField] AssetReference CamaH4;
    [SerializeField] AssetReference CamaH5;
    [SerializeField] AssetReference CamaH6;
    [SerializeField] AssetReference CamaH7;

    [SerializeField] AssetReference Peina1;
    [SerializeField] AssetReference Peina2;
    [SerializeField] AssetReference Peina3;
    [SerializeField] AssetReference Peina4;
    [SerializeField] AssetReference Peina5;*/

    [SerializeField] AssetReference ObjPresentacion;

    // Eliminar este comentario y los comentarios de las lineas 64 y 67
    public ClaseDatos claseDatosTipoMueble;
    public DBManager dBManager;

    [SerializeField]
    [Tooltip("Instantiates this prefab on a plane at the touch location.")]
    GameObject m_PlacedPrefab;
    public GameObject placedPrefab
    {
        get { return m_PlacedPrefab; }
        set { m_PlacedPrefab = value; }
    }

    public AddessableSetting(string tipoMueble)
    {
        this.claseDatosTipoMueble.tipoMueble = tipoMueble;
    }

    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        destroyObjectsEscene();
        ObjPresenta();
    }
    public void mesa1()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(Mesa1).Completed += ObjectLoadDone1;
        claseDatosTipoMueble.tipoMueble = "Buda";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    public void mesa2()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(Mesa2).Completed += ObjectLoadDone2;
        claseDatosTipoMueble.tipoMueble = "Tara";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDone1(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            //m_PlacedPrefab = Instantiate(loadedObject);
            m_PlacedPrefab = loadedObject;

        }

    }
    private void ObjectLoadDone2(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            //m_PlacedPrefab = Instantiate(loadedObject);
            m_PlacedPrefab = loadedObject;

        }

    }

    public void ObjPresenta()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(ObjPresentacion).Completed += ObjectLoadDoneObjPresenta;
        claseDatosTipoMueble.tipoMueble = "Objeto Presentacion";
        claseDatosTipoMueble.color = "Objeto Presentacion";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneObjPresenta(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV1()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV1).Completed += ObjectLoadDoneCamaV1;
        claseDatosTipoMueble.tipoMueble = "Infinito";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV1(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV2()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV2).Completed += ObjectLoadDoneCamaV2;
        claseDatosTipoMueble.tipoMueble = "Buda Piedra 1";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV2(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV3()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV3).Completed += ObjectLoadDoneCamaV3;
        claseDatosTipoMueble.tipoMueble = "Aplique Redondo";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV3(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV4()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV4).Completed += ObjectLoadDoneCamaV4;
        claseDatosTipoMueble.tipoMueble = "Aplique cuadrado";
        claseDatosTipoMueble.color = "Cafe oscuro";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV4(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV5()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV5).Completed += ObjectLoadDoneCamaV5;
        claseDatosTipoMueble.tipoMueble = "Aplique cuadrado";
        claseDatosTipoMueble.color = "Cafe claro";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV5(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV6()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV6).Completed += ObjectLoadDoneCamaV6;
        claseDatosTipoMueble.tipoMueble = "Estructura Metalica";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV6(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV7()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV7).Completed += ObjectLoadDoneCamaV7;
        claseDatosTipoMueble.tipoMueble = "Lampara de Sal";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV7(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV8()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV8).Completed += ObjectLoadDoneCamaV8;
        claseDatosTipoMueble.tipoMueble = "Geodesa";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV8(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV9()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV9).Completed += ObjectLoadDoneCamaV9;
        claseDatosTipoMueble.tipoMueble = "Buda Piedra 2";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV9(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV10()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV10).Completed += ObjectLoadDoneCamaV10;
        claseDatosTipoMueble.tipoMueble = "Buda Pie 2";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV10(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV11()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV11).Completed += ObjectLoadDoneCamaV11;
        claseDatosTipoMueble.tipoMueble = "Buda Negro Dorado";
        claseDatosTipoMueble.color = "Normal";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV11(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }
    //*********************************************************************************************************************

    /* Borrar esta linea y el comentario de la linea 824
    public void camaV1()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV1).Completed += ObjectLoadDoneCamaV1;
        claseDatosTipoMueble.tipoMueble = "Cama V1";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV1(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV2()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV2).Completed += ObjectLoadDoneCamaV2;
        claseDatosTipoMueble.tipoMueble = "Cama V2";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV2(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV4()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV4).Completed += ObjectLoadDoneCamaV4;
        claseDatosTipoMueble.tipoMueble = "Cama V4";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV4(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV3()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV3).Completed += ObjectLoadDoneCamaV3;
        claseDatosTipoMueble.tipoMueble = "Cama V3";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);

    }

    private void ObjectLoadDoneCamaV3(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV5()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV5).Completed += ObjectLoadDoneCamaV5;
        claseDatosTipoMueble.tipoMueble = "Cama V5";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV5(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV6()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV6).Completed += ObjectLoadDoneCamaV6;
        claseDatosTipoMueble.tipoMueble = "Cama V6";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV6(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV7()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV7).Completed += ObjectLoadDoneCamaV7;
        claseDatosTipoMueble.tipoMueble = "Cama V7";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV7(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV8()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV8).Completed += ObjectLoadDoneCamaV8;
        claseDatosTipoMueble.tipoMueble = "Cama V8";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV8(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV9()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV9).Completed += ObjectLoadDoneCamaV9;
        claseDatosTipoMueble.tipoMueble = "Cama V9";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV9(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV10()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV10).Completed += ObjectLoadDoneCamaV10;
        claseDatosTipoMueble.tipoMueble = "Cama V10";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV10(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV11()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV11).Completed += ObjectLoadDoneCamaV11;
        claseDatosTipoMueble.tipoMueble = "Cama V11";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV11(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV12()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV12).Completed += ObjectLoadDoneCamaV12;
        claseDatosTipoMueble.tipoMueble = "Cama V12";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV12(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV14()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV14).Completed += ObjectLoadDoneCamaV14;
        claseDatosTipoMueble.tipoMueble = "Cama V14";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV14(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV13()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV13).Completed += ObjectLoadDoneCamaV13;
        claseDatosTipoMueble.tipoMueble = "Cama V13";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV13(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV15()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV15).Completed += ObjectLoadDoneCamaV15;
        claseDatosTipoMueble.tipoMueble = "Cama V15";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV15(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV16()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV16).Completed += ObjectLoadDoneCamaV16;
        claseDatosTipoMueble.tipoMueble = "Cama V16";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV16(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV17()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV17).Completed += ObjectLoadDoneCamaV17;
        claseDatosTipoMueble.tipoMueble = "Cama V17";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV17(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV18()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV18).Completed += ObjectLoadDoneCamaV18;
        claseDatosTipoMueble.tipoMueble = "Cama V18";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV18(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV19()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV19).Completed += ObjectLoadDoneCamaV19;
        claseDatosTipoMueble.tipoMueble = "Cama V19";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV19(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaV20()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaV20).Completed += ObjectLoadDoneCamaV20;
        claseDatosTipoMueble.tipoMueble = "Cama V20";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaV20(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }



    //*************************************************************************************************

    public void camaH1()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaH1).Completed += ObjectLoadDoneCamaH1;
        claseDatosTipoMueble.tipoMueble = "Cama H1";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaH1(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaH2()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaH2).Completed += ObjectLoadDoneCamaH2;
        claseDatosTipoMueble.tipoMueble = "Cama H2";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaH2(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaH4()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaH4).Completed += ObjectLoadDoneCamaH4;
        claseDatosTipoMueble.tipoMueble = "Cama H4";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaH4(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaH3()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaH3).Completed += ObjectLoadDoneCamaH3;
        claseDatosTipoMueble.tipoMueble = "Cama H3";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);

    }

    private void ObjectLoadDoneCamaH3(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaH5()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaH5).Completed += ObjectLoadDoneCamaH5;
        claseDatosTipoMueble.tipoMueble = "Cama H5";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDoneCamaH5(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaH6()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaH6).Completed += ObjectLoadDoneCamaH6;
        claseDatosTipoMueble.tipoMueble = "Cama H6";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);

    }

    private void ObjectLoadDoneCamaH6(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void camaH7()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(CamaH7).Completed += ObjectLoadDoneCamaH7;
        claseDatosTipoMueble.tipoMueble = "Cama H7";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);

    }

    private void ObjectLoadDoneCamaH7(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }


    //*************************************************************************************************************************


    public void peina1()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(Peina1).Completed += ObjectLoadDonePeina1;
        claseDatosTipoMueble.tipoMueble = "Peinadora P1";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDonePeina1(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void peina2()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(Peina2).Completed += ObjectLoadDonePeina2;
        claseDatosTipoMueble.tipoMueble = "Peinadora P2";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDonePeina2(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void peina4()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(Peina4).Completed += ObjectLoadDonePeina4;
        claseDatosTipoMueble.tipoMueble = "Peinadora P4";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDonePeina4(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void peina3()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(Peina3).Completed += ObjectLoadDonePeina3;
        claseDatosTipoMueble.tipoMueble = "Peinadora P3";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDonePeina3(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }

    public void peina5()
    {
        destroyObjectsEscene();
        Addressables.LoadAssetAsync<GameObject>(Peina5).Completed += ObjectLoadDonePeina5;
        claseDatosTipoMueble.tipoMueble = "Peinadora P5";
        claseDatosTipoMueble.color = "Blanco";
        dBManager.AAA(claseDatosTipoMueble.tipoMueble, claseDatosTipoMueble.color);
    }

    private void ObjectLoadDonePeina5(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            GameObject loadedObject = obj.Result;
            m_PlacedPrefab = loadedObject;

        }

    }*/

    public void destroyObjectsEscene()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Mesa");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);
        //GameObject[] enemies1 = GameObject.FindGameObjectsWithTag("Peinadora");
        //foreach (GameObject enemy in enemies1)
        //GameObject.Destroy(enemy);
        GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("Cama");
        foreach (GameObject enemy in enemies2)
            GameObject.Destroy(enemy);
        /* GameObject[] enemies3 = GameObject.FindGameObjectsWithTag("Armario");
         foreach (GameObject enemy in enemies3)
             GameObject.Destroy(enemy);*/
    }
}