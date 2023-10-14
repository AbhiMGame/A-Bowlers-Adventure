using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]private GameObject lightEnemy;
    void Start()
    {
        StartCoroutine(ToggleLight());
        
    }

    IEnumerator ToggleLight()
    {
            lightEnemy.SetActive(true);
            yield return new WaitForSeconds(1f);
            StartCoroutine(ToggleLightOff());
    }
    
    IEnumerator ToggleLightOff()
    {
        lightEnemy.SetActive(false);
        yield return new WaitForSeconds(1f);
        StartCoroutine(ToggleLight());
    }

    


}
