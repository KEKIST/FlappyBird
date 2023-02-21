using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawpRate = 2;
    [SerializeField] private float timer = 0;
    [SerializeField] private float heightOffset;
   
    void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer < spawpRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
       

    }

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3( transform.position.x, Random.Range(highestPoint, lowestPoint), 0), transform.rotation);
    }
}

