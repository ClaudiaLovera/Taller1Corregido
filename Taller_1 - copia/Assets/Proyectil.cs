using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Intersecté con el Objeto: " + collider.gameObject.name);
        if (collider.gameObject.CompareTag("Destruir"))
        {
            Destroy(collider.gameObject);
         
        }
        

    }
}
