using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControlBordes : MonoBehaviour
{
    [Header("configurar el editor")]
    public float radio = 1f;
    public bool mantenerEnPantalla = false;

    [Header("Configuraciones dinamicas")]
    public bool estarEnPantalla = true;
    public float anchoCamara;
    public float altoCamara;
    public bool salioDerecha, salioIzquierda, salioArriba, salioAbajo;

    public void Awake()
    {
        altoCamara = Camera.main.orthographicSize;
        anchoCamara = Camera.main.aspect * altoCamara;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        estarEnPantalla = true;
        salioAbajo = salioArriba = salioDerecha = salioIzquierda = false;
        if (pos.x > anchoCamara - radio)
        {
            pos.x = anchoCamara - radio;
            salioDerecha = true;
        }
         if (pos.x > -anchoCamara + radio)
        {
            pos.x = -anchoCamara + radio;
            salioIzquierda = true;
        }
         if (pos.y > altoCamara - radio)
        {
            pos.y = altoCamara - radio;
            salioArriba = true;
        }
         if (pos.y < -altoCamara+radio)
        {
            pos.y = -altoCamara + radio;
        }

        estarEnPantalla = !(salioAbajo || salioArriba || salioDerecha || salioIzquierda);
        if (mantenerEnPantalla && !estarEnPantalla)
        {
            transform.position = pos;
            estarEnPantalla = true;
        }
    }
    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        Vector3 tamañoBorde = new Vector3(anchoCamara * 2, altoCamara * 2, 0.1f);
        Gizmos.DrawWireCube(Vector3.zero, tamañoBorde);
    }
}
