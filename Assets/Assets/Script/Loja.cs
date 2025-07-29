using UnityEngine;
using TMPro;

public class Loja : PontosManager
{
    public TextMeshProUGUI botao1, botao2, botao3, botao4;
    void Start()
    {
        botao1.text = "Update1";
        botao2.text = "Update2";
        botao3.text = "Update3";
        botao4.text = "Update4";
    }

    // Update is called once per frame
    void Update1()
    {
        if (pontos >= 10)
        {
            
        }
    }
}
