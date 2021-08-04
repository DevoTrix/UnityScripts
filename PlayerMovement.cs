using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float initPos; // implemented later on
    public float vel = 100f; // implemented later on
    // Update is called once per frame
    //currently shouldn't work correctly but supposed to stop double jump
    void Update()
    {
        initPos = transform.position.y;
    }

    void FixedUpdate(){
        if( Input.GetKeyDown(KeyCode.LeftShift)) {
            //implement later
        }
        //WASD Movement
        if( Input.GetKey( "w" ) ){
            initPos = transform.position.y;
            rb.AddForce( 0, 0, vel * Time.deltaTime, ForceMode.VelocityChange );
        }
        if( Input.GetKey( "a" ) ){
            initPos = transform.position.y;
            rb.AddForce( -vel * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
        }
        if( Input.GetKey( "s" ) ){
            initPos = transform.position.y;
            rb.AddForce( 0, 0, -vel * Time.deltaTime, ForceMode.VelocityChange );
        }
        if( Input.GetKey( "d" ) ){
            initPos = transform.position.y;
            rb.AddForce( vel * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
        }

        //jump
        if( Input.GetKeyDown( KeyCode.Space ) ){
            if( transform.position.y == initPos ){
                rb.AddForce( 0, 400 * Time.deltaTime, 0, ForceMode.VelocityChange );
            }
        }

        //if it Falls
        if(transform.position.y < -0.2){
            //copied from prev code on test run
            transform.position = new Vector3(135.0542f, 2.5f, 47.46735f);
        }
    }
}
