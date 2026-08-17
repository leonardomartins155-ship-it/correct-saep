using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{

    

       public void IniciarJogo( )
    {
        GameManager gameManager = FindFirstObjectByType<GameManager>(); 
            SceneManager.LoadScene("Menu");
        if (gameManager != null) Destroy(gameManager.gameObject);
        Time.timeScale = 0;
        
    }
    }


