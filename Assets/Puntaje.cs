using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;

    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;

    public int puntos = 0;
    public int puntajeAlto = 1000;

    void Start()
    {
        if (PlayerPrefs.HasKey("Puntaje Alto"));
        {
            puntajeAlto = PlayerPrefs.GetInt("Puntaje Alto");
        }
    }

    void Update()
    {
        puntos += 1;

        textoActual.text = "Puntaje Actual: " + puntos;

        if (puntos > puntajeAlto)
        {
            puntajeAlto = puntos;
            PlayerPrefs.SetInt("Puntaje Alto", puntos);
        }

        textoPuntajeAlto.text = "Puntaje Alto: " + puntajeAlto;
    }
}