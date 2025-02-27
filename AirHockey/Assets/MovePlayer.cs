using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour{

    
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete
    public float upperBoundY = -0.58f; 
    public float downBoundY = -6.952f; 
    public float rightBoundX = 6.363f; 
    public float leftBoundX = -6.3764f; 


    // Start is called before the first frame update
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();     // Inicializa a raquete
       
    }

    // Update is called once per frame
    void Update(){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var pos = transform.position;
        pos.x = mousePos.x;
        pos.y = mousePos.y;

        if (pos.y > upperBoundY) {                  
            pos.y = upperBoundY;                     // Corrige a posicao da raquete caso ele ultrapasse o limite superior
        }
        else if (pos.y < downBoundY) {
            pos.y = downBoundY;                    // Corrige a posicao da raquete caso ele ultrapasse o limite superior
        }

        if (pos.x > leftBoundX){
            pos.x = leftBoundX;
        }
        else if (pos.x < rightBoundX){
            pos.x = rightBoundX;
        }

        transform.position = pos;
    }
}

//-0.58, -6.952 -> y
