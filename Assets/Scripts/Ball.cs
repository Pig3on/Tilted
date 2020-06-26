using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public int force = 5;

    private Rigidbody rigidbodyComponent;
  

    private void Awake()
    {
        rigidbodyComponent = this.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, -Vector3.up, 1f))
        {
            if (Input.GetButtonDown(Buttons.JUMP))
            {
                Vector3 velocity = rigidbodyComponent.velocity;
                velocity.y = 0f;
                rigidbodyComponent.velocity = velocity;
                rigidbodyComponent.AddForce(Vector3.up * force, ForceMode.Impulse);
            }
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(Tags.GOAL) || other.gameObject.CompareTag(Tags.FAIL)){
            
        }
    }
}
