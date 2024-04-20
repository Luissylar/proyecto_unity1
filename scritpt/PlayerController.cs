using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 300f;
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Salto con la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0.0f, jumpForce, 0.0f), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el suelo es adecuado para saltar
        if (IsSuitableGround(collision.gameObject))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Verificar si el suelo es adecuado para saltar
        if (IsSuitableGround(collision.gameObject))
        {
            isGrounded = false;
        }
    }

    bool IsSuitableGround(GameObject ground)
    {
        // Aquí puedes implementar tu lógica para determinar si el suelo es adecuado para saltar
        // Por ejemplo, podrías verificar si el suelo tiene un tag específico o si tiene ciertas propiedades

        // Por ahora, supongamos que el suelo es adecuado si tiene el tag "SuitableGround"
        return ground.CompareTag("SuitableGround");
    }
}
