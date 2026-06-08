using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AdministradorDePersistenciia : MonoBehaviour
{
   public List<PuntajePersistente> ObjetosAGuardar;
   public void OnEnable()
    {
        for (int i = 0; 1 < ObjetosAGuardar.Count; i++)
        {
            var so = ObjetosAGuardar[i];
            so.Cargar();
        }
    }
    public void OnDisable()
    {
        for (int i = 0; i < ObjetosAGuardar.Count; i++)
        {
            var so = ObjetosAGuardar[i];
            so.Guardar();
        }
    }
}
