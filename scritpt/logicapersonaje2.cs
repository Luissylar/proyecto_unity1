using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicapersonaje2 : MonoBehaviour
{
    public float velocidad = 5f;
    public float velocidadrotacion = 200f;
    private Animator anim;
    public float x, y;
    public Rigidbody rb;
    public float fuerzaSalto = 8f;
    public bool puedoSaltar;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        puedoSaltar = false;
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadrotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidad);
    }
    void Update()
    {   
        // Obtener la entrada del teclado
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if(puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("salte", true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            }

            anim.SetBool("tocoSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }
    }
    public void EstoyCayendo()
    {
       anim.SetBool("tocoSuelo", false);
       anim.SetBool("salte", false); 
    }
}
