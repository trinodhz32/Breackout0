using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public UnityEvent AumentarPuntaje;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;
    }
    
    void Start() 
    {
         int resistenciaBase = resistencia;

switch (opciones.NivelDificultad)
{
    case Opciones.dificultad.Facil:
        resistencia = resistenciaBase;
        break;
    case Opciones.dificultad.Normal:
        resistencia = resistenciaBase + 1;
        break;
    case Opciones.dificultad.Dificil:
        resistencia = resistenciaBase + 2;
        break;
}
    } 

    
    void Update()
    {
        if (resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }
    
    public virtual void RebotarBola()
    {
        
    }


public Opciones opciones;

} 
