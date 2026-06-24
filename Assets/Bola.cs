using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class Bola : MonoBehaviour
{
    bool isGameStarted = false;

    [SerializeField] public float velocidadBola = 10.0f;
    Vector3 ultimaPosicion = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    Rigidbody rigidbody;
    private ControlBordes control;
    public UnityEvent BolaDestruida;

    private void Awake()
    {
        control = GetComponent<ControlBordes>();
    }
 void Start()
{
    isGameStarted = false;

    Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
    posicionInicial.y += 3;

    this.transform.position = posicionInicial;
    this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    rigidbody = this.gameObject.GetComponent<Rigidbody>();
}

// Update is called once per frame
void Update()
{
    if (control.salioAbajo)
        {
            BolaDestruida.Invoke();
            Destroy(this.gameObject);
        }

    if (control.salioArriba)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco arriba");
            direccion.y *= -1;
            direccion = direccion.normalized;
            rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
          if (control.salioDerecha)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco la derecha");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
          if (control.salioIzquierda)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco la izquierda");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }

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
private void HabilitarControl()
    {
        control.enabled = true;
    }
private void FixedUpdate()
    {
        ultimaPosicion = transform.position;
    }
    public void LateUpdate()
    {
        if (direccion != Vector3.zero) direccion = Vector3.zero;
    }
}