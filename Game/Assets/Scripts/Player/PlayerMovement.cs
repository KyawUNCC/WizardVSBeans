using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
	[SerializeField] float movementSpeed = 1f;
	[SerializeField] float mouseSensitivity = 1;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		/*
		float horizontalInput = Input.GetAxis("Horizontal") * movementSpeed;
		float verticalInput = Input.GetAxis("Vertical") * movementSpeed;
		
		rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
		*/
		rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * mouseSensitivity, 0)));
        rb.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * movementSpeed) + (transform.right * Input.GetAxis("Horizontal") * movementSpeed));
        
    }
	
}
