using UnityEngine;

public class Vila : MonoBehaviour
{
    public string nomeDaVila = "Vila Marshmallow";

    public GameObject[] amigos;

    public GameObject prefabCasa;

    void Start()
    {
        InicializarVila();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ConstruirCasa();
        }
    }

    void InicializarVila()
    {
    }

    public void AdicionarAmigo(GameObject novoAmigo)
    {
    }

    public void ConstruirCasa()
    {
        Vector3 posicaoAleatoria = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
        Instantiate(prefabCasa, posicaoAleatoria, Quaternion.identity);
    }
}