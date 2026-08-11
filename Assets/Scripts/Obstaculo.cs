using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public GameManager GameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player"))
        {
            GameManager.Dano();
        }
    }
}
