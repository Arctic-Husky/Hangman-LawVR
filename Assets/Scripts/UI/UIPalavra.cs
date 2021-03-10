using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPalavra : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TextMeshProUGUI textoPalavra;
    [SerializeField]
    TextMeshProUGUI textoDescricao;
    [SerializeField]
    PalavraManager palavraManager;
    private void Awake()
    {
        palavraManager.OnPalavraChange += PalavraManager_OnPalavraChanged;

    }

    private void PalavraManager_OnPalavraChanged(string palavra, string descricao)
    {
        textoPalavra.text = palavra;
        textoDescricao.text = descricao;
        print("PalavraManager_OnPalavraChanged");
    }
    public void AtualizarTexto(string palavra)
    {
        textoPalavra.text = palavra;
    }
    public void AtualizarTexto(string palavra, string descricao)
    {
        textoPalavra.text = palavra;
        textoDescricao.text = descricao;
    }
}
