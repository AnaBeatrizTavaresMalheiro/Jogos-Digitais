using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;


public class GameManager : MonoBehaviour{
    
    public static float seconds;
    public GUISkin layout;

    public static float timer = 0.0f;

    public Transform bornPoint;

    public static int lifes = 3;

    public static int score = 0;

    public static int num_invaders = 10;

    public static float bricksSpeed = 1f;
    public static float invaderSpeed = 1f;

    void  OnGUI(){
        GUI.skin = layout;
        timer += Time.deltaTime / 2f;
        seconds += Time.deltaTime / 2f;

        
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "Tempo: " + seconds.ToString("0"));
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 40, 100, 100), "Pontuação: " + score);
    }

    

    public static void notifyLifeLost(){
        lifes --;
        GameObject heart = GameObject.FindWithTag("Heart"); 
        Destroy(heart);

        if(lifes == 0){
            gameOver();
        }
    }

    public static void notifyScore(int newScore){
        score += newScore;
    }


    public static void gameOver(){
        lifes = 3;
        score = 0;
        timer = 0.0f;
        seconds = 0.0f;
        num_invaders = 10;
        SceneManager.LoadScene("Game Over");
        
    }

    public static void notifyWinner(){
        lifes = 3;
        score = 0;
        timer = 0.0f;
        seconds = 0.0f;
        num_invaders = 10;
        SceneManager.LoadScene("Winner");
    }
}