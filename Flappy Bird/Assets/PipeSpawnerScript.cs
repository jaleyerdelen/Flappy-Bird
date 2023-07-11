using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime; // Timer 2'ye geldiginde aþaðýdaki else'e girer
        }
        else
        {
            spawnPipe();
            timer = 0; // 0 olduktan sonra tekrar if'e girer. 
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        //Instantiate(pipe, transform.position, transform.rotation); // Objeyi kopyalar

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation); // Borularý rastgele kopyalar ve dizer
    }
}
