using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe_prefab;

    public float pipeMoveSpeed = 10f;
    public float pipesPerSecond = 1f;
    
    public Vector3 spawnPosition = new Vector3(20f,0,0);
    public Vector2 heightRange = new Vector2(-15f, 15f);

    private float timer = 0f;

    void Start(){
        timer = 1/pipesPerSecond;
    }

    // Update is called once per frame
    void Update()
    {
        timer += gameState.deltaTime;

        if(timer >= 1/pipesPerSecond){
            spawnPosition[1] = Random.Range(heightRange[0], heightRange[1]);
            var pipe = Instantiate(pipe_prefab, spawnPosition, Quaternion.identity);
            pipe.GetComponent<pipeMovement>().speed = pipeMoveSpeed;
            timer = 0f;
        }
    }
}
