using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    //private int IndexCenaAtual;

    private void Awake()
    {
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
        SceneManager.LoadScene(numeroCena); // Alterar depois para mais game modes
    }

    public void VoltarParaMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
