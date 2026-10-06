using UnityEngine;


public class SpawnScript : MonoBehaviour
{
    public GameObject prefab;
    public float contagem;
    private int contagemLimite = 5;
    private float posiMaxX = 346;
    private float posiMinX = 340;
    private float posiMaxZ = 460;
    private float posiMinZ = 451;
    void Start()
    {
        Spawn();
    }

 
    void Update()
    {
        contagem += Time.deltaTime;

        if (contagem >= contagemLimite)
        {
            Spawn();
            contagem = 0;
        }

    }

    void Spawn()
    {
        Vector3 spawnposition = new Vector3(Random.Range(posiMinX, posiMaxX), transform.position.y, Random.Range(posiMinZ, posiMaxZ));
        Instantiate(prefab, spawnposition, Quaternion.identity);
    }
}
