using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int Vidas { get; private set; }

    public event Action<int> OnVidasChanged = delegate { };

    private int totalDeVidas;
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
        Vidas = 8;
        OnVidasChanged(Vidas);
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
        Vidas = 8;
        OnVidasChanged(Vidas);
        SceneManager.LoadScene(cenaAtual);
    }

    public void PerderVida()
    {
        Vidas--;
        Debug.Log("Perdeu vida");

        if(OnVidasChanged != null)
        {
            OnVidasChanged(Vidas);
        }

        /*if(Vidas <= 0)
        {
            
        }*/
    }
}
