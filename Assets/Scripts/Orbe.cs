using UnityEngine;
using UnityEngine.SceneManagement;

public class Orbe : MonoBehaviour
{
    public GameObject painelVitoria;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            painelVitoria.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
