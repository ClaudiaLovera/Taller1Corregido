using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveEnemiga : MonoBehaviour
{
    public float velocidad ;
    // Start is called before the first frame update
    void Start()
    {
        movimiento();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void movimiento()
    {
        float Movimiento = Input.GetAxis("Vertical");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        //direccion y magnitud
        //x, la segunda es la velocidad en y
        rigidbody.velocity = new Vector2(Movimiento * velocidad, rigidbody.velocity.y);
        //transform.localScale = new Vector3(direccion, 1, 1); // Voltea la escala en función de la dirección // falta variable direccion

    }
}
