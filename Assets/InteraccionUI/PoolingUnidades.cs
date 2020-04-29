using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUnidades : MonoBehaviour
{

    public static ArrayList unidades;

    // Use this for initialization
    void Start()
    {
        unidades = new ArrayList();
        CrearPoolingUnidades();
        PosicionarUnidades();
    }

    public void CrearPoolingUnidades()
    {
        for (int i = 0; i < 20; i++)
        {
            CrearUnidad("VillanoAstronauta");
            CrearUnidad("VillanoAstronauta2");
            CrearUnidad("VillanoAstronauta3");
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


    public void PosicionarUnidades()
    {
        Vector3 incremento = new Vector3(0, 1);
        Vector3 posicion_actual = new Vector3(0, 4);
        Vector3[] posiciones = new Vector3[4];

        posiciones[0] = new Vector3(-37.3f, 49.4f); 
        posiciones[1] = new Vector3(9f, 49.12f);   
        posiciones[2] = new Vector3(-62.3f, -15.7f); 

        int cont = 0;

        foreach (GameObject item in unidades)
        {
            item.transform.position = posicion_actual;
            posicion_actual = posiciones [cont++];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
