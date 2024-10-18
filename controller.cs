using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float flapStrength = 1f;
    public Rigidbody2D bird;

    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(bird.simulated != gameState.isPlaying) bird.simulated = gameState.isPlaying;
        
        if(!gameState.isGameOver) transform.localEulerAngles = new Vector3(0,0,bird.velocity[1]);

        if(Input.GetKeyDown(KeyCode.Space)){
            if(!gameState.isPlaying) gameState.isPlaying = true;
            
            bird.velocity = Vector2.up * flapStrength;
        }

    }    

    void OnCollisionEnter2D(Collision2D col)
    {
        gameState.isGameOver = true;
        bird.simulated = false;
    }
}
