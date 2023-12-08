using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBoton : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnMouseOver()
    {
        // Reproduce el sonido
        audioSource.Play();
    }


}