using UnityEngine;

public class MovimentoFinal : MonoBehaviour
{

    public float velocidade = 3f;
    void Update()
    {
  transform.Translate(Vector2.right*velocidade*Time.deltaTime);
    }
}
