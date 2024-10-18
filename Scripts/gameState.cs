using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameState : MonoBehaviour
{
    public static int score = 0;

    public static bool isPlaying = false;
    public static bool isGameOver = false;
    
    public static float deltaTime = 0f;
    private static TextMeshProUGUI scoreText;


    void Start(){
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        isPlaying = false;
        isGameOver = false;
        score = 0;
    }

    public static void increaseScore(){
        if(isGameOver) return;
        score = score + 1; //score++;
        scoreText.text = score.ToString();
    }

    public static void Reset(){
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) Reset();

        if(isPlaying){
            deltaTime = Time.deltaTime * (score+20)/20;
        }
        else{
            deltaTime = 0;
        }
    }
}
