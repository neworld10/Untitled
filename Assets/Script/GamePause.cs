using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuCanvas;
    void Update(){
        // Debug.Log(GameObject.Find("Canvas"));
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause(){
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void ToSettingMenu(){
        Debug.Log("미구현");
    }

    public void ToMain(){
        Debug.Log("로비로 이동");
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame(){
        Debug.Log("미구현");
        Application.Quit();
    }
}
