using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string codigoAnimal;
    public int dias;
    int gramos;
    int gramosperiodo;
    float costo;
    // Start is called before the first frame update
    void Start()
    {
        if (codigoAnimal!="G"&& codigoAnimal!="PP" && codigoAnimal!="PG" || dias<3){
            Debug.Log("Error");
            return;
        }
        if (codigoAnimal=="G"){
            gramos=300;
        }
        if (codigoAnimal == "PP"){
            gramos=400;
        }
        if(codigoAnimal == "PG"){
            gramos=700;
        }
        gramosperiodo=gramos * dias;
        Debug.Log("Para ese periodo se necesitan" + gramosperiodo + "gramos de alimento");
        costo= 0.80f * gramosperiodo;
        Debug.Log("El costo es de "+ costo);


       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
/*

Usás Y (&&) cuando quieras que todas las condiciones se cumplan al mismo tiempo para hacer algo.

Usás O (||) cuando quiera que se cumpla al menos una condición para hacer algo.

Ejemplo:

Y (&&): "Quiero entrar al cine si tengo entrada y DNI" (necesitás las dos cosas).

O (||): "Me voy a quedar en casa si llueve o hace mucho frío" (con que pase una sola cosa, ya me quedo).