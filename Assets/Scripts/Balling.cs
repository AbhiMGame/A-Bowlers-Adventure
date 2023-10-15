using UnityEngine;
using UnityEngine.SceneManagement;

public class Balling : MonoBehaviour
{

    public GameObject ball;
    [SerializeField] private float launchballVelocity;
    private bool ballthrown;
    private Vector2 spawnPosition;
    private Quaternion spawnRotation;
    
    public void MoveBall()
    {
        ball.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right *launchballVelocity*Time.deltaTime, ForceMode2D.Impulse);
        ballthrown = false;
    }

    void Start()
    {
        ballthrown = true;
        spawnPosition = transform.position;
        spawnRotation = transform.rotation;
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
            Instantiate(ball, spawnPosition, spawnRotation);
            Debug.Log("Light is destroying");
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.tag == "Stumps")
        {
            AudioManager._instance.AudioPlayer.PlayOneShot(AudioManager._instance.WinSound);
            LevelManager._instance.WinningScreen.SetActive(true);
        }
    }

}



