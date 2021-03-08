using UnityEngine;

public class UIPaineis : MonoBehaviour
{
    [SerializeField]
    private GameObject[] paineis;

    private void Awake()
    {
        foreach (GameObject painel in paineis)
        {
            painel.SetActive(false);
        }
    }

    public void AbrirPainel(GameObject painel)
    {
        painel.SetActive(true);
    }

    public void FecharPainel(GameObject painel)
    {
        painel.SetActive(false);
    }
}
