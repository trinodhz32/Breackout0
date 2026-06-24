using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public PuntajeAlto1 puntajeAltoSO;

    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;
    

    void Start()
    {
        transformPuntajeActual= GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("PuntajeAlto"))
        //{
            //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
            puntajeAltoSO.Cargar();
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.puntaje = 0;
        //}
        // if (PlayerPrefs.HasKey("Puntaje Alto"));
        // {
        //     //puntajeAlto = PlayerPrefs.GetInt("Puntaje Alto");
        // }
    }
    private void FixedUpdate()
    {
        puntajeAltoSO.puntaje += 50;
    }
 
    void Update()
    {
        textoActual.text = $"PuntajeActual: {puntajeAltoSO.puntaje}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("PuntajeAlto", puntos);
        }
        //puntajeAltoSO += 50;

        // textoActual.text = "Puntaje Actual: " + puntos;

        // if (puntos > puntajeAlto)
        // {
        //     puntajeAlto = puntos;
        //     //PlayerPrefs.SetInt("Puntaje Alto", puntos);
        // }

        // textoPuntajeAlto.text = "Puntaje Alto: " + puntajeAlto;
    }
}