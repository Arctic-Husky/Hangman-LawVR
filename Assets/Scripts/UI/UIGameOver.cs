using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameOver : MonoBehaviour
{
    public void OnRestarButtonClick()
    {

        SceneManager.LoadScene(0);


    }
    public void OnBackButtonClick()
    {

        SceneManager.LoadScene(-1);


    }


}
