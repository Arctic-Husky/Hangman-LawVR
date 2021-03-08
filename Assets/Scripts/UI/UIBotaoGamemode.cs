using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBotaoGamemode : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Número da cena associado ao modo de jogo para o botão")]
    private int numeroCena;

    public void IniciarJogo()
    {
        GameManager.Instance.MoverParaJogo(numeroCena);
        Debug.Log(string.Format("Cena carregada: {0}", numeroCena));
    }
}