using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    
    private bool newcheck;
    private bool spacePressed;
    private float horizontalPress;
    private Rigidbody playerBodyComponent;
    
    

    // Start is called before the first frame update
    void Start()
    {
        playerBodyComponent = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = true;
        }

        horizontalPress = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        if (!newcheck)
        {
            spacePressed = false;

        } else if (spacePressed) 
        {
            playerBodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            spacePressed = false;
        }
            
                
            


        playerBodyComponent.velocity = new Vector3(horizontalPress * 2, playerBodyComponent.velocity.y, 0);

    }



    private void OnCollisionExit(Collision collision)
    {
        newcheck = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        newcheck = true;
    }

}
