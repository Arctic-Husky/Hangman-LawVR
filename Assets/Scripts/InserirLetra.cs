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
                gameOver.SetActive(true);
                gameOverText.text = "Voce Ganhou!!!";
                Debug.Log("You won the game !");
                //ShowFinalDialogue(true);
            }
        }
        else
        {
            print("errou");
            if (palavraManager.CheckLoseCondition())
            {
                gameOver.SetActive(true);
                gameOverText.text = "Voce Perdeu!!!";
                Debug.Log("You lost the game");
                //ShowFinalDialogue(false);
            }
            else { 
                palavraManager.DrawNextHangmanPart(); 
            }
        }
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
