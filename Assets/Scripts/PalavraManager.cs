using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using TMPro;

public class PalavraManager : MonoBehaviour
{
    [SerializeField]
    Palavra[] palavras;


    private int vidasAtuais = 0;
    private const int TOTAL_DE_VIDAS = 8;
    public string PalavraEscolhida { get;private set;}
    public string DescricaoEscolhida {  get; private set; }

    public event Action<string, string> OnPalavraChange = delegate { };
    public event Action<int> OnVidasChange = delegate { };


    public char PLACEHOLDER = '*';
    void Start()
    {
        //comeca o jogo e escolhe uma palavra aleatoria
        EscolherPalavraAleatoria(); 
    }
    //checar se venceu
    public bool CheckWinCondition(string userInput) { 
        return PalavraEscolhida.Equals(userInput); 
    }
    //checar se perdeu
    public bool CheckLoseCondition() {
        return GameManager.Instance.Vidas < 1 || vidasAtuais == TOTAL_DE_VIDAS - 1;
        //return vidasAtuais == TOTAL_DE_VIDAS - 1; 
    }

    public void DrawNextHangmanPart()
    {
        vidasAtuais = ++vidasAtuais % TOTAL_DE_VIDAS;
        GameManager.Instance.PerderVida();
        OnVidasChange(vidasAtuais);
        print(vidasAtuais);
        //HangmanImage.sprite = HangmanSprites[currentHangmanSprite];
    }


    private void EscolherPalavraAleatoria()
    {
        int randInt = UnityEngine.Random.Range(0, palavras.Length);
        PalavraEscolhida= palavras[randInt].palavra;
        DescricaoEscolhida = palavras[randInt].descricao;
        StringBuilder sb = new StringBuilder("");
        for (int i = 0; i < PalavraEscolhida.Length; i++) { 
        sb.Append(PLACEHOLDER);
        }
        OnPalavraChange(sb.ToString(), DescricaoEscolhida);
        print("Resposta: " + sb.ToString());
    }
}
