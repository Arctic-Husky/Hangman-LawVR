using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBotaoVoltar : MonoBehaviour
{
    public void VoltarParaMenu()
    {
        GameManager.Instance.VoltarParaMenu();
    }
}
