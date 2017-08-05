using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Rigidbody2D rigBod;
    public float jumpHeight = 140;
    public float speed = 200;
    public float maxForward = 20;


    // Use this for initialization
    void Start () {
        rigBod = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("jump");
            rigBod.AddForce(new Vector2(0, jumpHeight));
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("left");

            rigBod.AddForce(new Vector2(-speed,0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("right");
            rigBod.AddForce(new Vector2(speed, 0));
        }



        if (rigBod.velocity.magnitude > maxForward)
        {
            Vector2.ClampMagnitude(rigBod.velocity, maxForward);
        }
        
	}


    void inputManager(string key)
    {
        //





    }
}
