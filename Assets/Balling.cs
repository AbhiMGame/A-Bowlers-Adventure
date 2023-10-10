using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balling : MonoBehaviour
{

    [SerializeField] private GameObject ball;
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
}



