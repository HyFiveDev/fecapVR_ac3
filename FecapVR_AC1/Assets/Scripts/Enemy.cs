using UnityEngine;


public class Enemy : MonoBehaviour
{
    private Animator anim;
    [Header("Referências")]
    [SerializeField] public Transform player;
    [SerializeField] public GameObject deathCanvas;
    public int moviment0 = 0;
    Rigidbody rb;

    [Header("Configurações")]
    public float speed = 3f;
    private bool playerDead = false;
    private bool moving = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (player == null || playerDead)
            return;

        // Faz o inimigo olhar para o jogador
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime
        );

        if (rb.linearVelocity.magnitude > moviment0)
        {
            anim.SetBool("isWalking", true);
        }
        
            
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDead = true;
            
            //Ativa animação de morte
            anim.SetTrigger("attaking");

            // Mostra o Canvas de morte
            deathCanvas.SetActive(true);

            // Desativa o jogador
            collision.gameObject.SetActive(false);

            // Pausa o jogo
            Time.timeScale = 0f;
        }
    }
}