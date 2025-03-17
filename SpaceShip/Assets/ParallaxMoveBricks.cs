using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMoveBricks : MonoBehaviour{
    // Start is called before the first frame update
    private float lenght;
    private float movingSpeed = 1f;
    public GameObject cam;
    public static float bricksParallaxEffect = GameManager.bricksSpeed;
    

    

    // Start is called before the first frame update
    void Start(){
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
   void Update(){
        transform.position += Vector3.left * Time.deltaTime * movingSpeed * bricksParallaxEffect;
        if(transform.position.x < -4.094f ) {
            Destroy(gameObject);


        }

        if(GameManager.score >= 300){
            bricksParallaxEffect = 0.5f;
        }
    }
}
