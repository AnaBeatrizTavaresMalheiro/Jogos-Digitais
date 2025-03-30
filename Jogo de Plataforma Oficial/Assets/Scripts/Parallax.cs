using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Parallax : MonoBehaviour {

    private float length;
    public float parallaxEffect;
    private Tilemap tilemap;

  

    void Start(){
        tilemap = GetComponent<Tilemap>();

        // Calcula o comprimento baseado nos bounds do Tilemap
        Bounds bounds = tilemap.localBounds;
        length = bounds.size.x;

    }

    void Update(){
        transform.position += Vector3.left * Time.deltaTime * parallaxEffect;
        if(transform.position.x < -length ) {
            transform.position = new Vector3(length, transform.position.y, transform.position.z);
        }
    }

}