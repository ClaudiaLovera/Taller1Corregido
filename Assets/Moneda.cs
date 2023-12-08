using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public AudioSource sonidoRecogida; // Opcional: para reproducir un sonido al recoger la moneda

    // Este método se llama cuando hay una colisión
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("NaveEnemiga"))
        {
            // Reproduce el sonido de recogida si está configurado
            if (sonidoRecogida != null)
            {
                sonidoRecogida.Play();
            }

            // Destruye la moneda
            Destroy(gameObject);
        }
    }
}