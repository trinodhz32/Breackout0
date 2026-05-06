using UnityEngine;
using UnityEngine.InputSystem;

public class Bola : MonoBehaviour
{
    public InputAction lanzarAction;
    private bool isGameStarted = false;

    private void OnEnable() {
        lanzarAction.Enable();
    }

    private void OnDisable() {
        lanzarAction.Disable();
    }

    void Update()
    {
        if (!isGameStarted && lanzarAction.triggered)
        {
            isGameStarted = true;
            // Tu lógica de lanzamiento aquí
        }
    }
}