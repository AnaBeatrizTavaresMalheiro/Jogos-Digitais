using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;   
using UnityEngine;

public class startGame : MonoBehaviour{
    void Start(){

    }

    void changeScene() {
        // Return the current Active Scene in order to get the current Scene name.
        Scene scene = SceneManager.GetActiveScene();
        // Check if the name of the current Active Scene is your first Scene.

        if (scene.name == "Menu"){
            SceneManager.LoadScene("SampleScene");
        }
        
    }



    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return)){
            changeScene();
        }
    }
}
