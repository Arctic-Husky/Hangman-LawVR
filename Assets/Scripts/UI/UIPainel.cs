using UnityEngine;

public class UIPainel : MonoBehaviour
{
    private static bool podeAbrir = true;

    public void AbrirPainel(GameObject painel)
    {
        if(podeAbrir)
        {
            painel.SetActive(true);
            podeAbrir = false;
        }
    }

    public void FecharPainel(GameObject painel)
    {
        painel.SetActive(false);
        podeAbrir = true;
    }
}
