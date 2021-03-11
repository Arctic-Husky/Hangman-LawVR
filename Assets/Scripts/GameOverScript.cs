using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    //gameover script
    [SerializeField]
    GameObject gameOver;
    [SerializeField]
    Text gameOverText;

    public void PerdeuJogo()
    {
        gameOver.SetActive(true);
        gameOverText.text = "Voce Perdeu!!!";
        Debug.Log("You lost the game");
    }

    public void VenceuJogo()
    {
        gameOver.SetActive(true);
        gameOverText.text = "Voce Ganhou!!!";
        Debug.Log("You won the game !");
    }
}