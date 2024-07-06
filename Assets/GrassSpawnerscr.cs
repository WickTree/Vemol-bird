using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawnerscr : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float Yoffset = 10;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }    
    void spawnpipe()
    {
        float highestoffset = transform.position.y + Yoffset;
        float lowestoffset = transform.position.y - Yoffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestoffset + 1,highestoffset + 1),0), transform.rotation);
    }      
}
 