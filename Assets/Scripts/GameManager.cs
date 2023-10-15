using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;
    private AudioManager audioManager;
    private LevelManager levelManager;
    public static GameManager Instance
    {
        get
        {
            return _instance;
                
        }
    }

    private void Awake()
    {
        if(_instance !=null && _instance!=this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            audioManager = AudioManager.Instance;
            levelManager = LevelManager.Instance;
        }
    }


}
