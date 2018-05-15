using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Movement : MonoBehaviour
    {
        public float speed = 20f; // Units to travel per second
        public float rotationSpeed = 360f; //Amount of rotation per second

        private Rigidbody2D rigid; //Reference to attached Rigidbody2D
 
        // Use this for initialization
        void Start()
        {
            //Grab refrence to rigidbody2D component 
            // NOTE: It gets this from the GameObject this script is attached to 
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            // Check if A key is pressed
            if (Input.GetKey(KeyCode.A))
            {
                // Rotate left 
                transform.Rotate(Vector3.forward, rotationSpeed);
            }
            //Check if D key is pressed
            if (Input.GetKey(KeyCode.D))
            {
                //Rotate right
                transform.Rotate(-Vector3.forward, rotationSpeed);
            }
            //Check if W key is pressed 
            if (Input.GetKey(KeyCode.W))
            {
                // Move in facing direction 
                rigid.AddForce(transform.up * speed);
            }

            //Check if S key is pressed
            if (Input.GetKey(KeyCode.S))
            {
                // Move in opposite facing direction
                rigid.AddForce(-transform.up * speed);
            }




        }
    }
}