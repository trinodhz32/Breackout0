using UnityEngine;
using UnityEngine.InputSystem;

public class Bola : MonoBehaviour
{
    bool isGameStarted = false;

    [SerializeField] public float velocidadBola = 10.0f;
 void Start()
{
    isGameStarted = false;

    Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
    posicionInicial.y += 3;

    this.transform.position = posicionInicial;
    this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
}

// Update is called once per frame
void Update()
{
    if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))
    {
        if (!isGameStarted)
        {
            isGameStarted = true;

            this.transform.SetParent(null);

            GetComponent<Rigidbody>().linearVelocity = velocidadBola * Vector3.up;
        }
    }
}
}