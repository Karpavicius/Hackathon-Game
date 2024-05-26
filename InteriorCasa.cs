using UnityEngine;

public class InteriorCasa : MonoBehaviour
{
    public GameObject[] moveis;
    public GameObject[] decoracoes;

    void Start()
    {
        InicializarCasa();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InteragirComObjeto();
        }
    }

    void InicializarCasa()
    {
        foreach (GameObject movel in moveis)
        {
            InstanciarObjeto(movel);
        }

        foreach (GameObject decoracao in decoracoes)
        {
            InstanciarObjeto(decoracao);
        }
    }

    void InstanciarObjeto(GameObject objeto)
    {
        Vector3 posicaoAleatoria = new Vector3(Random.Range(-5f, 5f), Random.Range(-2f, 2f), 0f);
        Instantiate(objeto, posicaoAleatoria, Quaternion.identity, transform);
    }

    void InteragirComObjeto()
    {
        Debug.Log("Interagiu com um objeto dentro da casa!");
    }
}