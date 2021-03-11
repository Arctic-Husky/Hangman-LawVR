using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDiagramaHangman : MonoBehaviour
{
    [SerializeField]
    Sprite[] HangmanSprites;
    [SerializeField]
    Image HangmanImage;
    [SerializeField]
    PalavraManager palavraManager;
    [SerializeField]
    int currentHangmanSprite = 0;

    void Awake()
    {
        currentHangmanSprite = 0;
        HangmanImage.sprite = HangmanSprites[currentHangmanSprite];
        palavraManager.OnVidasChange += palavraManager_OnVidasChange;
    }
    private void palavraManager_OnVidasChange(int numeroDaImagem)
    {
        currentHangmanSprite = numeroDaImagem;
        HangmanImage.sprite = HangmanSprites[currentHangmanSprite];
    }
    
}
