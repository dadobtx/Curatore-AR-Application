using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class ClaseDatos 
{
    
    public string tipoMueble;
    public string color;
    public string email;
    public string tokenID;
    //public string fecha;
    //public string hora;

    public ClaseDatos(string tipoMueble, string color, string email, string tokenID)
    {
        
        this.tipoMueble = tipoMueble;
        this.color = color;
        this.email = email;
        this.tokenID = tokenID;
        
    }

}

[Serializable]
public class ClaseDatosUser
{
    public string email;
    public string tokenID;
    public string tipoMueble;
    public string color;
    public string fecha;
    public string hora;

    public ClaseDatosUser(string email, string tokenID, string tipoMueble, string color, string fecha,string hora)
    {
        this.email = email;
        this.tokenID = tokenID;
        this.tipoMueble = tipoMueble;
        this.color = color;
        this.fecha = fecha;
        this.hora = hora;
    }

}

public class UsersEntry
{
    public string email;
    public string color ;
    public string tipoMueble  ;
    public string tokenID  ;
    public string fecha;
    public string hora;



    public UsersEntry(string email, string color, string tipoMueble, string tokenID, string fecha, string hora)
    {
        this.email = email;
        this.color = color;
        this.tipoMueble = tipoMueble;
        this.tokenID = tokenID;
        this.fecha = fecha;
        this.hora = hora;
    }

    public Dictionary<string, object> ToDictionary()
    {
        Dictionary<string, object> result = new Dictionary<string, object>();
        result["email"] = email;
        result["color"] = color;
        result["tipoMueble"] = tipoMueble;
        result["tokenID"] = tokenID;
        result["fecha"] = fecha;
        result["hora"] = hora;

        return result;
    }
}