using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudio : MonoBehaviour
{

    AudioSource source;
    private void Start()
    {

        source = GetComponent<AudioSource>();
    }
    public void TocarAudio(AudioClip audio)
    {
        source.clip=audio;
        source.Play();
    }

}
