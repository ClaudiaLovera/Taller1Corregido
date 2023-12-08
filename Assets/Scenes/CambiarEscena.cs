using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Codigo para cambiar la escena
public class CambiarAEscenaJuego : MonoBehaviour
{
    //Metodo para cambiar de escena
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}