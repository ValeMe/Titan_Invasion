﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaBarra : MonoBehaviour
{
    [SerializeField]
    private GameObject barra_verde;
    [SerializeField]
    private GameObject barra_roja;
    private float escala_actual = 15f;
    private SpriteRenderer sr;

    // Use this for initialization
    void Start()
    {
        sr = barra_verde.GetComponent<SpriteRenderer>();
    }

    public void ModificarBarra(float escala)
    {
        if (sr.transform.localScale.x > 0)
        {
            sr.transform.localScale -= new Vector3(escala, 0);
        }
        else
        {
            //Disparar evento de muerte
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
