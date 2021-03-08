using UnityEngine;

public class UIBotaoAjuda : MonoBehaviour
{
    [SerializeField]
    private GameObject painelAjuda;
    [SerializeField]
    private GameObject painelPrincipal;

    private void Awake()
    {
        painelAjuda.SetActive(false);
        painelPrincipal.SetActive(true);
    }

    public void AbrirPainelAjuda()
    {
        print("Abrir painel ajuda");
        painelAjuda.SetActive(true);
    }

    public void FecharPainelAjuda()
    {
        print("Fechar painel ajuda");
        painelAjuda.SetActive(false);
    }
}
