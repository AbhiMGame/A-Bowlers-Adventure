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
        SceneManager.LoadScene(1);
        mainMenu.SetActive(false);

    }

    public void PlaySound()
    {
        AudioManager.Instance.buttonClick.Play();
    }

    public void PauseGame()
    {
        AudioManager.Instance.buttonClick.Play();
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        
    }

    public void ResumeGame()
    {
        
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        
        Application.Quit();
        Debug.Log("Player has Quit The Game");
    }
}
