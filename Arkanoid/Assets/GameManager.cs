using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    void backMenu (){
        SceneManager.LoadScene("Inicio");
    }


    // Update is called once per frame
    void Update(){
        Invoke("backMenu" , 5);
    }
}
