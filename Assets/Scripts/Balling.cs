using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balling : MonoBehaviour
{

    public GameObject ball;
    [SerializeField] private float launchballVelocity;
    private bool ballthrown;
    // Start is called before the first frame update
    
    public void MoveBall()
    {
        ball.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right *launchballVelocity*Time.deltaTime, ForceMode2D.Impulse);
        ballthrown = false;
    }

    void Start()
    {
        ballthrown = true;
    }


    void FixedUpdate()
    {
        if (Input.GetButton("Fire1") && ballthrown == true)
        {
            MoveBall();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.DeathClip);
            Destroy(this.gameObject, 0.2f);
            Debug.Log("Light is destroying");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.tag == "Stumps")
        {
            AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.WinSound);
        }
    }

}



