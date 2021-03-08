using UnityEngine;

public class UIBotaoPainel : MonoBehaviour
{
    [SerializeField]
    private UIPainel painel;

    public void ClicarBotao()
    {
        painel.AbrirPainel(painel.gameObject);
    }
}
