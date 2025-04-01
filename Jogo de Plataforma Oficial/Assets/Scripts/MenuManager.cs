using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour{
    
    public GameObject howToPlayPanel;
    public GameObject TextPular;

    public void Start(){
        howToPlayPanel.SetActive(false);
        TextPular.SetActive(false);
    }
    public void Play(){
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Start MenuManager");
    }

    public void OpenHowToPlay(){
        howToPlayPanel.SetActive(true);
        TextPular.SetActive(true);

    }

    public void CloseHowToPlay(){
        howToPlayPanel.SetActive(false);
        TextPular.SetActive(false);
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
