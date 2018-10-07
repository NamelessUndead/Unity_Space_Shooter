using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    [SerializeField]
    // The speed at which our player is moving per meter
    private float Speed = 5.0f;

    // game object laser prefab variable
    public GameObject LaserPrefab;

	// Use this for initialization
	void Start ()
    {
        //current pos = new position
        transform.position = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();

        // if space key pressed
        // spawn laser at player position

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // spawn laser
            Instantiate(LaserPrefab, transform.position + new Vector3(0, 0.65f,0), Quaternion.identity );
        }

    }

    // handles all the movement for the player
    private void Movement()
    {
        /// Using keyboard to move vehicle
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * HorizontalInput * Speed * Time.deltaTime);
        transform.Translate(Vector3.up * VerticalInput * Speed * Time.deltaTime);

        // makes the player unable to cross past the y boundries
        if (transform.position.y > 4)
        {
            transform.position = new Vector3(transform.position.x, 4, 0);
        }
        else if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, -4, 0);
        }

        // makes the player unable to cross past the x boundries
        if (transform.position.x > 8.88f)
        {
            transform.position = new Vector3(-8.88f, transform.position.y, 0);
        }
        else if (transform.position.x < -9.03f)
        {
            transform.position = new Vector3(8.78f, transform.position.y, 0);
        }
    }
}
