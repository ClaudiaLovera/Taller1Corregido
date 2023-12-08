using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveEnemiga : MonoBehaviour
{
   
    public GameObject[] prefab;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

    public float spawnInterval = 1.0f;
    public AudioSource sonidoExplosion;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("naveAleatoria", 1.0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void naveAleatoria()
    {
        
        int randomIndex = Random.Range(0, prefab.Length);
        //numero aleatorio
        int randomSpawnPoint = Random.Range(0, 3);

        Transform chosenSpawnPoint;
       
        if (randomSpawnPoint == 0)
            chosenSpawnPoint = spawnPoint;
        else if (randomSpawnPoint == 1)
            chosenSpawnPoint = spawnPoint2;
        else
            chosenSpawnPoint = spawnPoint3;

        //instancia de nave enemiga
        GameObject naveInstancia = Instantiate(prefab[randomIndex], chosenSpawnPoint.position, Quaternion.identity);

        naveInstancia.transform.position = new Vector3(naveInstancia.transform.position.x, naveInstancia.transform.position.y, 0);

        naveInstancia.transform.rotation = Quaternion.Euler(0, 0, 180);
    }

   
}
