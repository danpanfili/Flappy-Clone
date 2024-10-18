using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public float speed = 1f;
    public float endPosition = -100f;
    public bool passed = false;

    
    void Update()
    {
        if(gameState.isPlaying){
            transform.position += new Vector3(-1,0,0) * speed * gameState.deltaTime;
        }

        if(transform.position.x < 0f && !passed){
            gameState.increaseScore();
            passed = true;
        }

        if(transform.position.x < endPosition){
            GameObject.Destroy(gameObject);
        }

    }
}
