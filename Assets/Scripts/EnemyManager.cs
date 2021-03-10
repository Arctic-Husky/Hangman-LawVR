using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    Enemy[] enemyArray;
    [SerializeField]
    GameOverScript gameoverScript;

    int inimigoAtual = 0;
    public float DificuldadeDoInimigo { get; private set; }
    public event Action<int> OnSangueInimigoChange=delegate { };
    public event Action<string> OnInimigoChange = delegate { };
    private void Start()
    {
        OnSangueInimigoChange(enemyArray[inimigoAtual].sangue);
        OnInimigoChange(enemyArray[inimigoAtual].nomeDoMonstro);
    }

    private void ChecarSangueInimigo(int index)
    {
        if (enemyArray[index].sangue<=0)
        {
            PassarParaProximoInimigo();
            print("Inimigo morto!");
        }
    }

    private void PassarParaProximoInimigo()
    {
        inimigoAtual++;
        OnSangueInimigoChange(enemyArray[inimigoAtual].sangue);
        OnInimigoChange(enemyArray[inimigoAtual].nomeDoMonstro);
    }

    public void DiminuirSangueInimigo(int quantidade)
    {
        
        enemyArray[inimigoAtual].sangue -= quantidade;
        ChecarSangueInimigo(inimigoAtual);
        print(" enemyArray[inimigoAtual].sangue");
    }
}
