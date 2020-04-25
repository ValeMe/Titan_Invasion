using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidad1 : MonoBehaviour
{
    [SerializeField]
    public GameObject ruta;
    private int indice;
    private Vector2 posicion_inicial;
    private Transform posicion_siguiente;
    private Transform posicion_actual;
    public float vel;
    private float distancia_punto;
    private bool esta_viva;
    private float tiempo;
    private int vidas;
    private Vector3 posicion_muerte;
    private Animator controlador;

    


    // Start is called before the first frame update
    void Start()
    {
        vel = 3f;
        vidas = 3;
        distancia_punto = 5f;
        esta_viva = true;
        posicion_inicial = this.transform.position;
        posicion_siguiente = ruta.transform.GetChild(0);
        controlador = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir;

        if (esta_viva)
        {
            //dir = posicion_siguiente - this.transform.position;
            //dir.z = 0;
            transform.position = Vector2.MoveTowards(transform.position, posicion_siguiente.position, vel * Time.deltaTime);
            //this.transform.position += dir * vel * Time.deltaTime;

            if (Vector2.Distance(transform.position, posicion_siguiente.position) < distancia_punto)
            {
                if (indice + 1 < ruta.transform.childCount)
                {
                    indice++;
                    posicion_actual = posicion_siguiente;
                    posicion_siguiente = ruta.transform.GetChild(indice);
                    CambiarPosicion();
                }
                else
                {
                    indice = 0;
                    this.transform.position = posicion_inicial;
                    posicion_siguiente = ruta.transform.GetChild(0);
                    posicion_actual = null;
                }
            }
        }
    }


    private void CambiarPosicion()
    {
        int direccion = 1;
        Direccion mira_hacia;

        if (posicion_actual != null)
        {
            mira_hacia = posicion_actual.GetComponent<Direccion>();
            if (mira_hacia.Ubicacion == Direccion.ARRIBA) 
            {
                direccion = Direccion.ARRIBA;
            }
            if (mira_hacia.Ubicacion == Direccion.ABAJO)
            {
                direccion = Direccion.ABAJO;
            }
            if (mira_hacia.Ubicacion == Direccion.IZQUIERDA)
            {
                direccion = Direccion.IZQUIERDA;
            }
            if (mira_hacia.Ubicacion == Direccion.DERECHA)
            {
                direccion = Direccion.DERECHA;
            }
            controlador.SetInteger("direccion", direccion);
        }
    }

    


    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.tag == "bala")
        {
            Destroy(otro.gameObject);
        }
    }



    public bool Esta_viva { get => esta_viva; set => esta_viva = value; }

}
