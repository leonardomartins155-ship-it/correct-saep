using UnityEngine;

public class Morrida : MonoBehaviour
{
    public GameManager GameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           GameManager.vida = 0;
            GameManager.Derrota();
        }
    }
}
