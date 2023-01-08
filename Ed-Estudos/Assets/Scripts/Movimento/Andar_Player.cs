using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar_Player : MonoBehaviour
{
    Vector3 Deslocamento = new Vector3();
    [Range(0,10)]
    public float Velocidade;
    private Rigidbody Rb;
    private Vector3 Mover;
    public Animator Player_Animator;

    public void Start()
    {
        Mover = Vector3.zero;
        Rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        Movimentar_Via_Joystick();
    }

    public void Movimentar_Via_Joystick()
    {
        Mover.x = Input.GetAxis("Horizontal");
        Mover.z = Input.GetAxis("Vertical");

        Deslocamento = Rb.position;
        Rb.MovePosition(Deslocamento + Mover * Velocidade*Time.fixedDeltaTime);
        if (Mover != Vector3.zero)
        {
            Player_Animator.SetBool("Andar",true);
            transform.forward = Mover;
        }else
        {
            Player_Animator.SetBool("Andar",false);
        }
        var velocidadeMovimento = Velocidade;
        Rb.MovePosition(Rb.position + velocidadeMovimento * Time.fixedDeltaTime * Mover);
    }
}
