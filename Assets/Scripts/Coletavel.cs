using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public GameManager GameManager;
    public AudioClip coletavel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(coletavel, transform.position);
            GameManager.Cura();
            GameObject.Destroy(gameObject);
        }
    }
}
