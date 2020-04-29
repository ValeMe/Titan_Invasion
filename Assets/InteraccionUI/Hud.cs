using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour {

   [SerializeField]
   private Text monedas;
   private static int contador_monedas;
   private uint modo_ejecucion;
   private static Hud instancia;

    public const uint CONSTRUCCION = 1;
    public const uint EJECUCION = 2;

    public static Hud GetInstance()
    {
        return instancia;
    }

    public uint Modo_ejecucion { get => modo_ejecucion; set => modo_ejecucion = value; }

    void Start()
    {
        modo_ejecucion = CONSTRUCCION;
        contador_monedas = 1000;
        instancia = this;
    }


    public static void ActualizarMoneda(int valor)
   {
     contador_monedas += valor;
   }

   
   //Update is called once per frame
    void Update () {
       monedas.text = contador_monedas.ToString();
    }
}
