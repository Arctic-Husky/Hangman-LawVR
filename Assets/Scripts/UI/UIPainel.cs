using UnityEngine;

public class UIPainel : MonoBehaviour
{
    public void AbrirPainel(GameObject painel)
    {
        painel.SetActive(true);
    }
    public void FecharPainel(GameObject painel)
    {
        painel.SetActive(false);
    }
}
