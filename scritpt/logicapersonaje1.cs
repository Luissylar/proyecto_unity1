using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicapersonaje1 : MonoBehaviour
{
    public float velocidad = 5f;
    public float velocidadDrotacion = 200f;
    private Animator anim;
    public float x, y; // Velocidad de movimiento del personaje

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Obtener la entrada del teclado
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadDrotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidad);
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
