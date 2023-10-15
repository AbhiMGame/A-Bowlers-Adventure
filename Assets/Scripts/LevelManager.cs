using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject pauseMenu;

    
    public void LoadGame()
    {
        AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.ButtonClick);
        SceneManager.LoadScene(1);
        mainMenu.SetActive(false);
       
    }

    public void PauseGame()
    {
        AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.ButtonClick);
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.ButtonClick);

    }

    public void ResumeGame()
    {
        AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.ButtonClick);
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.ButtonClick);
        Time.timeScale = 1;
        
    }

    public void QuitGame()
    {
        
        Application.Quit();
        Debug.Log("Player has Quit The Game");
        AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.ButtonClick);
    }
}
