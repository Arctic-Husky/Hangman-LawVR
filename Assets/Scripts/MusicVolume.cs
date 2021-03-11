using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{

    [SerializeField]
    Slider slider;
    [SerializeField]
    Toggle toggleButton;
    AudioSource music;
    private void Start()
    {
        music = GetComponent<AudioSource>();
        OnToggleButton();
    }
    public void OnToggleButton()
    {
        if (toggleButton.isOn)
        {
            music.mute = false;
        }
        else
        {
            music.mute = true;
        }
    }
    public void OnSliderChange()
    {
        music.volume = slider.value;
    }
}
