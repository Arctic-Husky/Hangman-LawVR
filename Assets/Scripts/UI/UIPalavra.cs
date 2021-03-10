using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPalavra : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textoPalavra;
    [SerializeField]
    TextMeshProUGUI textoDescricao;
    [SerializeField]
    PalavraManager palavraManager;
    private void Start()
    {
        palavraManager.OnPalavraChange += PalavraManager_OnPalavraChanged;

    }
    private void PalavraManager_OnPalavraChanged(string palavra, string descricao)
    {
        textoPalavra.text = palavra;
        textoDescricao.text = descricao;
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
