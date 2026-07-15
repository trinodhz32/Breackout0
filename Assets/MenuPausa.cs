using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject menuOpciones;

    public void MostrarMenuPausa()
    {
        menuPausa.SetActive(true);
        if (menuOpciones.activeInHierarchy) menuOpciones.SetActive(false);
    }
    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
    }
    public void RegresarAPantallaPrincipal()
    {
        SceneManager.LoadScene("Menu principal");
    }
    public void MostrarMenuOpciones()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }
    public void RegresarMenuPausa()
    {
        menuOpciones.SetActive(false);
        menuPausa.SetActive(true);
    }
    
    }
