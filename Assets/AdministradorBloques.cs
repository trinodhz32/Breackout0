using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AdministradorBloques : MonoBehaviour
{
    public GameObject MenuFinNivel;
    

    // Update is called once per frame
    void Update()
    {
       if (transform.childCount == 0)
       {
        MenuFinNivel.SetActive(true);
       } 
    }
}
