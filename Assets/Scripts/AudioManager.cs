using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager _instance;
    public AudioSource AudioPlayer;
    [field: SerializeField]
    public AudioClip DeathClip { get; private set; }
    [field: SerializeField]
    public AudioClip ButtonClick { get; private set; }
    [field: SerializeField]
    public AudioClip WinSound { get; private set; }
    public static AudioManager Instance
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


}
