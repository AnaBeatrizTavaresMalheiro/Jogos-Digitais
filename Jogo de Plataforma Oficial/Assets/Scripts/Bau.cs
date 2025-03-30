using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bau : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            SceneManager.LoadScene("Fase2"); // Troque "GameOver" pelo nome da sua cena de Game Over
        }
    }
}
