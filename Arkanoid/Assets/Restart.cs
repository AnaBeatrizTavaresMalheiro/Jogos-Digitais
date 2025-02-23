using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void changeScene() {
        // Return the current Active Scene in order to get the current Scene name.
        Scene scene = SceneManager.GetActiveScene();
        // Check if the name of the current Active Scene is your first Scene.

        if (scene.name == "Ganhou"){
            SceneManager.LoadScene("Inicio");
        }
        
    }



    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return)){
            changeScene();
        }
    }
}
