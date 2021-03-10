<<<<<<< Updated upstream:Assets/Scripts/ScoreVidas.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
=======
﻿using UnityEngine;
>>>>>>> Stashed changes:Assets/Scripts/UI/UIScoreVidas.cs
using UnityEngine.UI;

public class UIScoreVidas : MonoBehaviour
{
    public GameObject vidaUI;
    public static int vidas = 5;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 5;
    }
<<<<<<< Updated upstream:Assets/Scripts/ScoreVidas.cs

    // Update is called once per frame
    void Update()
=======
    private void Start()
    {
        vidasText.text = palavraManager.vidaAtual.ToString();
    }
    private void palavraManager_OnVidasChange(int vidas)
>>>>>>> Stashed changes:Assets/Scripts/UI/UIScoreVidas.cs
    {
        vidaUI.GetComponent<Text>().text = ("" + ScoreVidas.vidas.ToString());
    }

}
