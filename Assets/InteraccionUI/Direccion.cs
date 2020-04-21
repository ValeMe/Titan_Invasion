using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direccion : MonoBehaviour
{
    [SerializeField]
    private int ubicacion;
    public const int ARRIBA = 1;
    public const int DERECHA = 2;
    public const int ABAJO = 3;
    public const int IZQUIERDA = 4;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int Ubicacion { get => ubicacion; set => ubicacion = value; }
}

