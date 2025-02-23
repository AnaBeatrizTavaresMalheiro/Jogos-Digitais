using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   


public class DownWall : MonoBehaviour{
    // Start is called before the first frame update

    // Verifica colisões da bola nas paredes

    PlayerMove player = new PlayerMove();

    void OnTriggerEnter2D (Collider2D hitInfo) {
        GameObject heart = GameObject.FindWithTag("Heart"); 
        if (hitInfo.tag == "Ball"){
            
            Destroy(heart);
            
            player.life = player.life - 1;
            hitInfo.gameObject.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
        }
        isNotAlive();
    }

    void isNotAlive (){
        Scene scene = SceneManager.GetActiveScene();
        if (player.life == 0){
            SceneManager.LoadScene("Game Over");
        }
    }


    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
}
