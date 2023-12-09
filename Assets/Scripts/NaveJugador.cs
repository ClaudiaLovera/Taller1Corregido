using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveJugador : MonoBehaviour
{
    
    public float velocidad;
    private float distanciaProyectil = 2.0f;
    public GameObject proyectilPrefab;
    public AudioSource sonidoDisparo;

   

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
        //limite izquierdo
        if(transform.position.x < -2)
        {
            transform.position = new Vector4(-2, transform.position.y, transform.position.z);
        }
        //limite derecho
        if (transform.position.x > 2)
        {
            transform.position = new Vector4(2, transform.position.y, transform.position.z);
        }
        //-1 y 1 //vertical eje y
        float Movimiento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        //direccion y magnitud
        rigidbody.velocity = new Vector2(Movimiento * velocidad, rigidbody.velocity.y);
       
    }
    void disparo()
    {
        //posicionNave
        Vector3 posicionInicioNave = transform.position + Vector3.up * distanciaProyectil;
        GameObject proyectil = Instantiate(proyectilPrefab,posicionInicioNave,Quaternion.identity);

        //rotacion
        proyectil.transform.rotation = Quaternion.Euler(0, 0, 90);

        //fuerza
        Rigidbody2D rigidbodyProyectil = proyectil.GetComponent<Rigidbody2D>();
        rigidbodyProyectil.velocity = new Vector2(0f, 5f);

        //Reproduce el sonido del disparo
        sonidoDisparo.Play();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Moneda"))
        {
            
            Destroy(collision.gameObject);
            
        }

       
    }

    
}

