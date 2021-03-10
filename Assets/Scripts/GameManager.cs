using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int cenaAtual;

    private void Awake()
    {
        cenaAtual = 0;

        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void MoverParaJogo(int numeroCena)
    {
        SceneManager.LoadScene(numeroCena);
        cenaAtual = numeroCena;
    }

    public void VoltarParaMenu()
    {
        SceneManager.LoadScene(0);
        cenaAtual = 0;
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }

    public void ReiniciarCena()
    {
        SceneManager.LoadScene(cenaAtual);
    }
}
