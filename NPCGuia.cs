using UnityEngine;

public class NPCGuia : MonoBehaviour
{

    public string mensagemGuia = "Olá! Bem-vindo ao Monte Marshmallow! Pressione a tecla de espaço para pular e as setas para mover.";
    public float raioInteracao = 2f;
    public TextMesh textoMensagem;
    private bool jogadorDentroDoRaio = false;

    void Start()
    {
        textoMensagem = GetComponentInChildren<TextMesh>();
        textoMensagem.gameObject.SetActive(false);
        
    }

    void Update()
    {
        if(jogadorDentroDoRaio){
            textoMensagem.gameObject.SetActive(true);
            textoMensagem.text = mensagemGuia;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.log("NPC:" + mensagemGuia);
        }
    }else{
        textoMensagem.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player")){
            jogadorDentroDoRaio = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){

        if(other.CompareTag("Player")){
            jogadorDentroDoRaio = false;
        }
    }
}
