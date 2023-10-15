using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager _instance;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject pauseMenu;
    [field: SerializeField]
    public GameObject WinningScreen { get; private set; }

    public static LevelManager Instance
    {
        get
        {
            return _instance;

        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void LoadGame()
    {
        LevelManager._instance.WinningScreen.SetActive(false);
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
