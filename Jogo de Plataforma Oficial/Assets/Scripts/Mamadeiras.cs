using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mamadeiras : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            GameManager.aumentarScore(1);
            Destroy(gameObject);
        }
    }
}
