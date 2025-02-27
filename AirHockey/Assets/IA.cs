// GameManager.cs
using UnityEngine;

public class IA : MonoBehaviour
{
    public float speed = 8.0f;             // Velocidade da raquete
    public float boundX = 2.25f;            // Limites no eixo X
    private Rigidbody2D rb2d;               // Corpo rígido 2D

    private int direction = 1;              // 1 = direita, -1 = esquerda

    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(speed * direction, 0);
    }

    void Update(){
        var pos = transform.position;
        var velocity = rb2d.velocity;
        // Inverte a direção ao atingir os limites
        if (pos.x > boundX && direction > 0){
            direction = -1;
            velocity = new Vector2(speed * direction, 0);
        }
        else if (pos.x < -boundX && direction < 0){
            direction = 1;
            velocity = new Vector2(speed * direction, 0);
        }

        rb2d.velocity = velocity;
    }
}
