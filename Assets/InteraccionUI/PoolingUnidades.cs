using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour
{

    public static ArrayList unidades;
    public static ArrayList unidades2;

    // Use this for initialization
    void Start()
    {
        unidades = new ArrayList();
        unidades2 = new ArrayList();
        CrearPoolingUnidades();
        PosicionarUnidades();
        PosicionarUnidades2();
    }

    public void CrearPoolingUnidades()
    {
        for (int i = 0; i < 10; i++)
        {
            CrearUnidad("VillanoAstronauta");
            CrearUnidad("VillanoAstronauta2");
            CrearUnidad2("VillanoAstronauta3");
        }


    }

    public void CrearUnidad(string nombre)
    {
        GameObject unidad = GameObject.Find(nombre);
        GameObject temp;

         temp = (GameObject)Instantiate(unidad, Vector3.zero, Quaternion.identity);

        if (!unidades.Contains(unidad))
        {
            unidades.Add(unidad);
        }
        unidades.Add(temp);

    }
    public void CrearUnidad2(string nombre) //usar 2 arraylist
    {
        GameObject unidad2 = GameObject.Find(nombre);
        GameObject temp;

        temp = (GameObject)Instantiate(unidad2, Vector3.zero, Quaternion.identity);

        if (!unidades2.Contains(unidad2))
        {
            unidades2.Add(unidad2);
        }
        unidades2.Add(temp);

    }


    public void PosicionarUnidades()
    {
        Vector3 incremento = new Vector3(1, 0);
        Vector3 posicion_actual = new Vector3(-42, 46);

        foreach(GameObject item in unidades)
        {
            item.transform.position = posicion_actual;
            posicion_actual = posicion_actual + incremento;
        }
    }
    public void PosicionarUnidades2()
    {
        Vector3 incremento = new Vector3(1, 0);
        Vector3 posicion_actual = new Vector3(-65, -5);

        foreach(GameObject item in unidades2)
        {
            item.transform.position = posicion_actual;
            posicion_actual = posicion_actual + incremento;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
