using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serpente : MonoBehaviour
{


    private float timer = 0.0f;
    private float waitTime = 1.0f;

    public float speed = 2.0f;
    private int direction = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.diminuirVida();
            Destroy(gameObject);
        }
    }

    void ChangeState()
    {
        direction *= -1; // Inverte a direção
        Flip(); // Inverte a escala do sprite para virar a serpente visualmente
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= waitTime)
        {
            ChangeState();
            timer = 0.0f;
        }

        // Move a serpente na direção atual
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

    }
}
