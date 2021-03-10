using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreVidas : MonoBehaviour
{
    public GameObject vidaUI;
    public static int vidas = 5;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 5;
    }

    // Update is called once per frame
    void Update()
    {
        vidaUI.GetComponent<Text>().text = ("" + ScoreVidas.vidas.ToString());
    }

}
