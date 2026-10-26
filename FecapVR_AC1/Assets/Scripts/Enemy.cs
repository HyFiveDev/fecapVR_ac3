using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    [SerializeField]
    Transform alvo;
    private Rigidbody rb;
    private Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        //StartCoroutine("AcharPlayer");
        StartCoroutine(AcharPlayer());
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isWalking", rb.linearVelocity.x != 0 || rb.linearVelocity.z != 0);
    }

    public void OnPointerDown()
    {
        gameObject.SetActive(false);
        Destroy(gameObject, 0.5f);
    }

    IEnumerator AcharPlayer()
    {
        WaitForSeconds tempo = new WaitForSeconds(0.2f);
        while (true)
        {
            navMeshAgent.SetDestination(alvo.position);
            yield return tempo;

        }
    }
}
