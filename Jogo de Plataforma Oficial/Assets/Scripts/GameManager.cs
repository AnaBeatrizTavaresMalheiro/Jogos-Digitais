using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
    private static int score = 0;

    private static int vida = 3;

    private static int numMamadeiras = 21;
    public GUISkin layout;

    public static void aumentarScore(int pontos){
        score += pontos;

        if (SceneManager.GetActiveScene().name == "Fase2") {
            numMamadeiras --;
        }

        if(numMamadeiras == 0){
            SceneManager.LoadScene("Winner");
            score = 0;
            numMamadeiras = 21;
            vida = 3;
        }
    }

    public static void diminuirVida(){
        vida --;
        Destroy(GameObject.FindGameObjectWithTag("Heart"));
        if(vida == 0){
            SceneManager.LoadScene("GameOver");
            vida = 3;
            score = 0;
            numMamadeiras = 21;
        }
    }

    void  OnGUI(){
        GUIStyle style = new GUIStyle();
        style.fontSize = 30; // Altere esse valor para o tamanho que desejar

        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 40, 500, 500), "Pontuação: " + score, style);

    }

}
