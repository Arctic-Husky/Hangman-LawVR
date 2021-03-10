using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InserirLetra : MonoBehaviour
{
    PalavraManager palavraManager;

    [SerializeField]
    UIPalavra uiPalavra;

    private string userInput;

    private void Start()
    {
        palavraManager = GetComponent<PalavraManager>();
    }
    public void OnGuessSubmitted(Button button)
    {
        char letter = button.GetComponentInChildren<Text>().text.ToCharArray()[0];
        if (palavraManager.PalavraEscolhida.Contains(letter))
        {
            UpdateAnswerText(letter);
            if (palavraManager.CheckWinCondition(userInput))
            {
                Debug.Log("You won the game !");
                //ShowFinalDialogue(true);
            }
        }
        else
        {
            if (palavraManager.CheckLoseCondition())
            {
                Debug.Log("You lost the game");
                //ShowFinalDialogue(false);
            }
            else { 
                palavraManager.DrawNextHangmanPart(); 
            }
        }
    }
    private void UpdateAnswerText(char letter)
    {
        char[] userInputArray = userInput.ToCharArray();
        for (int i = 0; i < palavraManager.PalavraEscolhida.Length; i++)
        {
            if (userInputArray[i] != palavraManager.PLACEHOLDER) { continue; } // already guessed
            if (palavraManager.PalavraEscolhida[i] == letter) { userInputArray[i] = letter; }
        }
        userInput = new string(userInputArray);
        uiPalavra.AtualizarTexto(userInput);
    }
}
