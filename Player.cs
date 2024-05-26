using UnityEngine;

public class PersonagemPrincipal : MonoBehaviour
{
    public string nomeDaPersonagem = "Menina Fada";
    public int vidaMaxima = 100;
    public int vidaAtual;
    public int moedas = 0;

    public GameObject radiogun;
    public GameObject quimiogun;

    public Diario diario;

    void Start()
    {
        vidaAtual = vidaMaxima;
    }

    void Update()
    {
        if (vidaAtual <= 0)
        {
            Debug.Log("Game Over - Você morreu!");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UsarRadiogun();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UsarQuimiogun();
        }

    }

    void UsarRadiogun()
    {
        Debug.Log("Usando a Radiogun!");
    }

    void UsarQuimiogun()
    {
        Debug.Log("Usando a Quimiogun!");
    }

    public void ReceberDano(int dano)
    {
        vidaAtual -= dano;
    }

    public void Curar(int quantidade)
    {
        vidaAtual = Mathf.Min(vidaAtual + quantidade, vidaMaxima);
    }

    public void AdicionarMoedas(int quantidade)
    {
        moedas += quantidade;
    }
}