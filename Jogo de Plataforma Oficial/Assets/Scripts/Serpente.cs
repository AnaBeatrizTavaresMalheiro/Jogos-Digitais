using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serpente : MonoBehaviour
{
    
    private Animator animator;  
    private int serpenteAndando = Animator.StringToHash("SerpenteAndando");

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            
            GameManager.diminuirVida();
            Destroy(gameObject);
        }
    }

    void Start(){
        animator = GetComponent<Animator>(); // Inicializa o animator
    }
    void Update(){
        
        animator.SetBool(serpenteAndando, true); // Define a animação de andar da serpente como verdadeira
    }
}
