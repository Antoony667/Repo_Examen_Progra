using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody Cuerpo;
    private Vector3 EscalaNormal;

    private bool IsGrounded = true;
    private bool IsCrouching = false;

    public float FuerzaSalto = 5f;
    public float EscalaAgachado = 0.5f;


    void Start()
    {
        Cuerpo = GetComponent<Rigidbody>();
        EscalaNormal = transform.localScale;
    }

    //salto
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded && !IsCrouching)
        {
            Cuerpo.linearVelocity = new Vector3(0, FuerzaSalto, 0);
            IsGrounded = false;
        }

        //agacharse

        if (Input.GetKeyDown(KeyCode.DownArrow) && IsGrounded)
        {
            IsCrouching = true;
            transform.localScale = new Vector3(EscalaNormal.x, EscalaNormal.y * EscalaAgachado, EscalaNormal.z);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            IsCrouching = false;
            transform.localScale = EscalaNormal;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            IsGrounded = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
      

        if (other.CompareTag("Plataforma"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }


}
