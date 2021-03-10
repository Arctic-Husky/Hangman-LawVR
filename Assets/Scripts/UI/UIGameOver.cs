using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameOver : MonoBehaviour
{
    public void OnRestarButtonClick()
    {
        GameManager.Instance.ReiniciarCena();
    }
    public void OnBackButtonClick()
    {
        GameManager.Instance.VoltarParaMenu();
    }
}
