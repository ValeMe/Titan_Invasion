using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPonerTorres : MonoBehaviour
{
    public GameObject torre;


    void OnMouseDown()
    {
        GameObject temp;
        Vector3 pos = this.transform.position;
        pos.y = pos.y + 1.5f;
        temp = Instantiate(torre);
        temp.transform.position = pos;
        temp.layer = 5;
        Destroy(this.gameObject);
    }
}
