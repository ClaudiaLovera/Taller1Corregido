using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveJugador : MonoBehaviour
{
    public float velocidad;
    private float distanciaProyectil = 1.0f;
    public GameObject proyectilPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoNave();

        if (Input.GetKeyDown(KeyCode.F)){
           disparo();
        }
    }
    void movimientoNave()
    {
        //limite izq
        if(transform.position.x < -2)
        {
            transform.position = new Vector4(-2, transform.position.y, transform.position.z);
        }
        //limite der
        if (transform.position.x > 2)
        {
            transform.position = new Vector4(2, transform.position.y, transform.position.z);
        }
        //-1 y 1 //vertical eje y
        float Movimiento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        //direccion y magnitud
        //x, la segunda es la velocidad en y
        rigidbody.velocity = new Vector2(Movimiento * velocidad, rigidbody.velocity.y);
        //transform.localScale = new Vector3(direccion, 1, 1); // Voltea la escala en función de la dirección // falta variable direccion

    }
    void disparo()
    {
        //posicionNave
        Vector3 posicionInicioNave = transform.position + Vector3.up * distanciaProyectil;
        GameObject proyectil = Instantiate(proyectilPrefab,posicionInicioNave,Quaternion.identity);

        //fuerza
        Rigidbody2D rigidbodyProyectil = proyectil.GetComponent<Rigidbody2D>();
        rigidbodyProyectil.velocity = new Vector2(0f, 5f);
    }
   
}

