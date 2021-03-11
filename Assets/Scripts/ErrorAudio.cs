using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorAudio : MonoBehaviour
{
    [SerializeField]
    InserirLetra inserirLetra;

    AudioSource audioSource;
    private void Awake()
    {
        inserirLetra.OnErrarLetra += inserirLetra_OnErrarLetra;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();        
    }
    private void inserirLetra_OnErrarLetra()
    {
        audioSource.Play();
    }
}
