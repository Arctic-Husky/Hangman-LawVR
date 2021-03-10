using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInimigo : MonoBehaviour
{
    [SerializeField]
    Text vidasInimigasText;
    [SerializeField]
    TextMeshProUGUI textoNomeDoInimigo;
    [SerializeField]
    EnemyManager enemyMananger;
    private void Awake()
    {
        enemyMananger.OnSangueInimigoChange += enemyMananger_OnSangueInimigoChange;
        enemyMananger.OnInimigoChange += enemyMananger_OninimigoChange;
    }

    private void enemyMananger_OninimigoChange(string nomeDoMonstro)
    {
        textoNomeDoInimigo.text = nomeDoMonstro;
    }

    private void enemyMananger_OnSangueInimigoChange(int sangueInimigo)
    {
        vidasInimigasText.text = sangueInimigo.ToString();
    }
}
