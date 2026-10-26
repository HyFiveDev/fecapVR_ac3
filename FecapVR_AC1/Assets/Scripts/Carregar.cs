using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

//Para usar o código, deve-se escolher um game object vazio, chamado ponto de soltura,
//que será onde o objeto vai ficar enquanto você estiver segurando e onde ele será depositado ao soltar o mouse.
//Enquanto você estiver com mouse precionado, o objeto estará sendo segurado; quando você soltar o mouse, ele para de ser segurado

public class Carregar : MonoBehaviour
{
    [SerializeField] Transform pontoSoltar;
    [SerializeField] Transform pontoCarregar;
    Rigidbody rb;

    StarterAssetsMaps joaozinho;
    InputAction fireTwo, fireOne;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        joaozinho = new StarterAssetsMaps();
        fireTwo=joaozinho.Player.FireTwo;
        fireOne = joaozinho.Player.FireOne;
        fireOne.Enable();
        fireTwo.Enable();

    }

    bool soltou = false;
    bool carregando = false;

    private void Start()
    {
        pontoCarregar = GameObject.FindGameObjectWithTag("PontoCarregar").GetComponent<Transform>();
        pontoSoltar = pontoCarregar;
    }
    public void OnPointerDown()
    {
        print("interacao funfou");
        gameObject.transform.position=pontoCarregar.position;
        rb.isKinematic = true;
        carregando = true;
    }

    private void Update()
    {
     if (!carregando) return;
     if (fireOne.WasReleasedThisFrame())
     {
          transform.position= pontoSoltar.position;
          rb.isKinematic = false;
          carregando= false;
     }
    }
}
