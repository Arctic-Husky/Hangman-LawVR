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
<<<<<<< Updated upstream

    [SerializeField]
    UIPalavra uiPalavra;

    private string userInput;

    private void Start()
    {
        palavraManager = GetComponent<PalavraManager>();
    }
    public void OnGuessSubmitted(Button button)
=======
    [SerializeField]
    UIPalavra uiPalavra;
    [SerializeField]
    EnemyManager enemyManager;
    [SerializeField]
    GameOverScript gameoverScript;

    private string userInput;

    private void Awake()
    { 
       
        //print("pik");
        palavraManager.OnPalavraChange += PalavraManager_OnPalavraChanged;
    }

    private void PalavraManager_OnPalavraChanged(string palavraEscondida, string descricao)
    {
       // print("PalavraManager_OnPalavraChanged");
        userInput = palavraEscondida;
    }

    public void TentadoAdivinharLetra(Button button)
>>>>>>> Stashed changes
    {
        char letter = button.GetComponentInChildren<TextMeshProUGUI>().text.ToCharArray()[0];
        print(letter);
        print(palavraManager.PalavraEscolhida);
        if (palavraManager.PalavraEscolhida.Contains(letter))
        {
<<<<<<< Updated upstream
            UpdateAnswerText(letter);
            if (palavraManager.CheckWinCondition(userInput))
            {
                Debug.Log("You won the game !");
=======
            print("acertou");
            AtualizarTextoPalavra(letra);
            if (palavraManager.CondicaoVencedor(userInput))
            {
                enemyManager.DiminuirSangueInimigo(1);
                
>>>>>>> Stashed changes
                //ShowFinalDialogue(true);
            }
        }
        else
        {
<<<<<<< Updated upstream
            if (palavraManager.CheckLoseCondition())
            {
                Debug.Log("You lost the game");
=======
            print("errou");
            if (palavraManager.CondicaoPerdedora())
            {
                print("perdeu");
                gameoverScript.PerdeuJogo();
>>>>>>> Stashed changes
                //ShowFinalDialogue(false);
            }
            else { 
                palavraManager.DrawNextHangmanPart(); 
            }
        }
    }
<<<<<<< Updated upstream
    private void UpdateAnswerText(char letter)
=======



    private void AtualizarTextoPalavra(char letter)
>>>>>>> Stashed changes
    {
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
