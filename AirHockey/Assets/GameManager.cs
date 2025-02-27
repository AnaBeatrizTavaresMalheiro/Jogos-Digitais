using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    // Start is called before the first frame update

    public static int PlayerScore = 0;
    public static int IaScore = 0;

    public GUISkin layout;              // Fonte do placar
    GameObject theBall;                 // Referência ao objeto bola


    public static void Score(string ID){
        Debug.Log("Gol registrado em: " + ID);
        if (ID == "goalPlayer"){  
            IaScore++;
        }
        else if (ID == "goalIA"){  
            PlayerScore++;
        }
    }


    // Gerência da pontuação e fluxo do jogo
    // Gerência da pontuação e fluxo do jogo
    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 160 - 12, -12, 1000, 100), "Player");
        GUI.Label(new Rect(Screen.width / 2 - 160 , 35, 100, 100), "" + PlayerScore);
        GUI.Label(new Rect(Screen.width / 2 + 100 + 12, -12, 100, 100), "IA");
        GUI.Label(new Rect(Screen.width / 2 + 100 + 12, 35, 100, 100), "" + IaScore);

        if (GUI.Button(new Rect(Screen.width / 2 - 300 , 35, 120, 53), "RESTART"))
        {
            PlayerScore = 0;
            IaScore = 0;
            theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
            
        }
        if (PlayerScore == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER WINS");
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);

        } else if (IaScore == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "IA WINS");
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }



    void Start(){
        theBall = GameObject.FindGameObjectWithTag("Disco"); // Busca a referência do disco
    }

    // Update is called once per frame
    void Update(){
        
    }
}
