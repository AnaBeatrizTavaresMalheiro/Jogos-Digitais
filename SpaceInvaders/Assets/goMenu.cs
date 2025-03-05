using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;   
using UnityEngine;

public class goMenu : MonoBehaviour{
    

    void changeScene() {
        // Return the current Active Scene in order to get the current Scene name.
        Scene scene = SceneManager.GetActiveScene();
        // Check if the name of the current Active Scene is your first Scene.

        if (scene.name == "GameOver"){
            SceneManager.LoadScene("Menu");
        }
        
    }



    // Update is called once per frame
    void Update(){
        Invoke("changeScene" , 5);
    }
}
