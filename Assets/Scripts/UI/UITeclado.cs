using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITeclado : MonoBehaviour
{
    string palavra;
    int palavraIndex = 0;
    string alpha;
    TMPro.TextMeshProUGUI meuNome = null;

    public void inserirLetrasNaPalavra(string letra)
    {
        palavraIndex++;
        palavra = palavra + letra;
        meuNome.text = palavra;
    }
}
