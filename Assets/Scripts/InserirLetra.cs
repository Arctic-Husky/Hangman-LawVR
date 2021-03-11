using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InserirLetra : MonoBehaviour
{
    [SerializeField]
    PalavraManager palavraManager;
    [SerializeField]
    UIPalavra uiPalavra;

    //gameover script
    [SerializeField]
    GameObject gameOver;
    [SerializeField]
    Text gameOverText;

    public event Action OnErrarLetra=delegate{};

    private string userInput;

    private void Awake()
    { 
       
        print("pik");
        palavraManager.OnPalavraChange += PalavraManager_OnPalavraChanged;
    }

    private void PalavraManager_OnPalavraChanged(string palavraEscondida, string descricao)
    {
        print("PalavraManager_OnPalavraChanged");
        userInput = palavraEscondida;
    }

    public void OnGuessSubmitted(Button button)
    {
        char letra = button.GetComponentInChildren<TextMeshProUGUI>().text.ToCharArray()[0];
        print(letra);
        
        if (palavraManager.PalavraEscolhida.Contains(letra))
        {
            print("acertou");
            AtualizarTextoPalavra(letra);
            if (palavraManager.CheckWinCondition(userInput))
            {
                GanhouJogo("Voce Ganhou!!!");
            }
        }
        else
        {
            print("errou");
            OnErrarLetra();
            if (palavraManager.CheckLoseCondition())
            {
                GanhouJogo("Voce Perdeu!!!");
            }
            else { 
                palavraManager.DrawNextHangmanPart(); 
            }
        }
    }

    private void GanhouJogo(string gameOverString)
    {
        gameOver.SetActive(true);
        gameOverText.text = gameOverString;
        Debug.Log(gameOverText);
    }

    private void AtualizarTextoPalavra(char letter)
    {
        print(userInput);
        char[] userInputArray = userInput.ToCharArray();
        for (int i = 0; i < palavraManager.PalavraEscolhida.Length; i++)
        {
            if (userInputArray[i] != palavraManager.PLACEHOLDER) { continue; } // already guessed
            if (palavraManager.PalavraEscolhida[i] == letter) { userInputArray[i] = letter; }
        }
        userInput = new string(userInputArray);
        print("atualizou");
        uiPalavra.AtualizarTexto(userInput);
    }
}
