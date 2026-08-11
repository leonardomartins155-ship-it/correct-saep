using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public GameManager GameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Cura();
            GameObject.Destroy(gameObject);
        }
    }
}
