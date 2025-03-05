using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;


public class GameManager : MonoBehaviour{
    
    public static float seconds;
    public GUISkin layout;

    public static float timer = 0.0f;

    public spaceShipMove spaceShip;
    public Transform bornPoint;

    public static int lifes = 3;

    public static int score = 0;

    public static int invaders = 36; //36

    void  OnGUI(){
        GUI.skin = layout;
        timer += Time.deltaTime / 2f;
        seconds += Time.deltaTime / 2f;

        if(timer >= 30){
            Instantiate(spaceShip , bornPoint.position , bornPoint.rotation);
            timer = 0.0f;
        }
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
        invaders = 36;
        SceneManager.LoadScene("GameOver");
    }

    public static void notifyWinner(){
        lifes = 3;
        score = 0;
        timer = 0.0f;
        seconds = 0.0f;
        invaders = 36;
        SceneManager.LoadScene("Winner");
    }

}
