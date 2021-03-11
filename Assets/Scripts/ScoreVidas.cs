using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreVidas : MonoBehaviour
{
    [SerializeField]
    Text vidasText;
    [SerializeField]
    PalavraManager palavraManager;
    void Awake()
    {
        //palavraManager.OnVidasChange += palavraManager_OnVidasChange;
        GameManager.Instance.OnVidasChanged += Instance_OnVidasChanged;
    }

    private void Instance_OnVidasChanged(int vidas)
    {
        if(vidasText != null)
            vidasText.text = vidas.ToString();
    }

    /*private void palavraManager_OnVidasChange(int vidas)
    {
        vidasText.text = vidas.ToString();
    }*/
}
