using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;


public class Jugador : MonoBehaviour
{
    [SerializeField] public int limiteX = 23;
    [SerializeField] public float VelocidadPaddle = 5f;
    private Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        Vector2 mouseScreenPos = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPos = mainCam.ScreenToWorldPoint(new Vector3(mouseScreenPos.x, mouseScreenPos.y, mainCam.transform.position.y));
          Vector3 pos = this.transform.position;

        // if (Input.GetKey(GetCode.RightArrow))
        // {
        //     this.transform.Translate(Vector3.right * VelocidadPaddle * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     this.transform.Translate(Vector3.left * VelocidadPaddle * Time.deltaTime);
        // }
        
      
        pos.x = mouseWorldPos.x;
        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;
        
        }
        else if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        this.transform.position = pos;
    }
}