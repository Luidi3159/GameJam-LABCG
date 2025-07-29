using UnityEngine;
using TMPro;

public class PontosManager : MonoBehaviour
{
    public TextMeshProUGUI textoPontos;
    protected int pontos;
    protected int multiplicador = 1;
    void Start()
    {
        // Carrega os pontos salvos
        //pontos = PlayerPrefs.GetInt("Pontos", 0);
        pontos=0;
        AtualizarTexto();
    }

    public void AdicionarPonto()
    {
        pontos += pontos*multiplicador;
        PlayerPrefs.SetInt("Pontos", pontos); // Salva os pontos
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        textoPontos.text = "Pontos: " + pontos.ToString();
    }
}
