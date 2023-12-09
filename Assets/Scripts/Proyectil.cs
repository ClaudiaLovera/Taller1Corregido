using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Proyectil : MonoBehaviour
{
    public AudioSource sonidoExplosion;
    public GameObject moneda;

    void OnCollisionEnter2D(Collision2D collision)
    {
        int contadorNave = 0;
        
        if (collision.gameObject.CompareTag("NaveEnemiga"))
        {
            Destroy(gameObject);
            Instantiate(moneda, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            contadorNave++;

            
        }
        if (collision.gameObject.CompareTag("Nave"))
        {
            SceneManager.LoadScene("Salida");
        }

    }
}
