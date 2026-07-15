using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Opciones", menuName = "Herramientas/Opciones", order = 1)]
public class Opciones : PuntajePersistente
{
public float velocidadBola = 30;
public dificultad NivelDificultad = dificultad.Facil;

public enum dificultad
    {
        Facil,
        Normal,
        Dificil
    }
    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }
    public void CambiarDificultad(int nuevaDificultad)
    {
        NivelDificultad = (dificultad)nuevaDificultad;
    }
    
}
