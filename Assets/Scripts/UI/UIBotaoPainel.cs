﻿using UnityEngine;

public class UIBotaoPainel : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Painel a ser ativado por este botão")]
    private UIPainel painel;

    public void AtivarPainel()
    {
        painel.AbrirPainel(painel.gameObject);
    }
}
