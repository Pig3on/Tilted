using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public int force = 2;

    private Rigidbody rigidbodyComponent;
    private bool isGrounded = true;
  

    private void Awake()
    {
        rigidbodyComponent = this.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(Buttons.JUMP) && isGrounded)
        {
            Vector3 velocity = rigidbodyComponent.velocity;
            velocity.y = 0f;
            rigidbodyComponent.velocity = velocity;
            rigidbodyComponent.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(Tags.GOAL) || other.gameObject.CompareTag(Tags.FAIL)){
            
        }
    }
}
