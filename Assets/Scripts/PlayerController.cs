using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 7;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool estaNoChao;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = rb.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);
        if (movimento > 0) sprite.flipX = false;
        if (movimento < 0) sprite.flipX = true;

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