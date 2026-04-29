using UnityEngine;

public class BloqueMadera : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistencia = 3;
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
 