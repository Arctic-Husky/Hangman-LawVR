using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoParaDarDano : MonoBehaviour
{
    [SerializeField]
    Slider sliderTempo;
    [SerializeField]
    float velocidadeDificuldade;
    [SerializeField]
    PalavraManager palavraManager;

    float tempo;
    
    private void Update()
    {
        AtualizarTempo();
    }

    private void AtualizarTempo()
    {
        tempo += Time.deltaTime * velocidadeDificuldade;
        if (tempo >= 1)
        {
            print("perdeu vida pelo tempo");
            palavraManager.CondicaoPerdedora();
            palavraManager.DrawNextHangmanPart();
            tempo = 0;

        }
        sliderTempo.value = tempo;
    }
}
