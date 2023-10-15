using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager _instance;
    [field: SerializeField]
    public AudioSource buttonClick { get; private set; }
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
