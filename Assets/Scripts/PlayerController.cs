using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    public float velocidade = 5f;
    public float forcaPulo = 7;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool estaNoChao;

    private void Start()
    {
        animator = GetComponent<Animator>(); 
        rb = GetComponent<Rigidbody2D>();
        sprite = rb.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);
        if (movimento > 0) sprite.flipX = false;
        if (movimento < 0) sprite.flipX = true;

        if (movimento > 0 || movimento <0) animator.SetBool("andando", true);
        if (movimento == 0) animator.SetBool("andando", false);
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
        }       
       
    }
    void OnCollisionExit2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("chao"))
        {
            estaNoChao =false;
        }
    }
    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("chao"))
        {
            estaNoChao = true;
        }
    }

}