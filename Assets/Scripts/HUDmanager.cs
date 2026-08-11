using UnityEngine;
using UnityEngine.UI;
public class HUDmanager : MonoBehaviour
{
    public Image[] coracoes;
    public Sprite cheio;
    public Sprite vazio;
    public GameManager GameManager;
    void Update()
    {
         AtualizarHUD();
    }
    public void AtualizarHUD()
    {
        for (int i = 0; i < coracoes.Length; i++)
        {
            if (i < GameManager.vida)
                coracoes[i].sprite = cheio;
            else
                coracoes[i].sprite = vazio;
        }
    }
}

