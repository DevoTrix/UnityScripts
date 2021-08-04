using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fowardForce = 2000f;
    private float initPos;
    public float vel = 100f;

    void Update(){
        initPos = transform.position.y;
    }
    void FixedUpdate(){

        if(Input.GetKeyDown(KeyCode.LeftShift)){
            
        }
        if(Input.GetKey("d")){
            rb.AddForce(vel * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            initPos = transform.position.y;
        }
        if(Input.GetKey("a")){
            initPos = transform.position.y;
            rb.AddForce( -vel * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w")){
            initPos = transform.position.y;
            rb.AddForce( 0, 0, vel * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("s")){
            initPos = transform.position.y;
            rb.AddForce( 0, 0, -vel * Time.deltaTime,ForceMode.VelocityChange);
        }
        if( Input.GetKeyDown(KeyCode.Space)){
            if(transform.position.y == initPos){
                rb.AddForce( 0, 400 * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }
        
        if(transform.position.y < -0.2f){
            transform.position = new Vector3(-127.4f, 0f, -33.2f);
        }
    }
    
    
    
}
