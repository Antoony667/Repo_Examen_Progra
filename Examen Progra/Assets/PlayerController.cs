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
        Cuerpo = GetComponent<RigidBody>();
        EscalaNormal = tranform.localScale;
    }

 //salto
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded && !IsCrouching)
        {
            Cuerpo.velocity = new Vector3(0,FuerzaSalto,0);
            IsGrounded =false;
        }
        
        //agacharse

        if (Input.GetKeyDown(KeyCode.DownArrow) && IsGrounded)
        {
            IsGrounded=false;
            transform.localScale = new Vector3(EscalaNormalx)
        }


    }

}
