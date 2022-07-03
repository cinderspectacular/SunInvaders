using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField] public InputReader InputReader { get; private set; }
    [field: SerializeField] public Rigidbody rb { get; private set; }

    public float MovementSpeed;
    public float JumpSpeed;

    bool isGrounded = false;

    void Start()
    {
        InputReader.JumpEvent += OnJump;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3();
        movement.x = InputReader.MovementValue.x;
        movement.y = 0f;
        movement.z = InputReader.MovementValue.y;

        transform.Translate(movement * MovementSpeed * Time.deltaTime);
     }

    void OnCollisionStay(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }

    void OnDestroyed()
    {
        InputReader.JumpEvent -= OnJump;
    }

    void OnJump()
    {
        if(isGrounded)
        {
            rb.AddForce(new Vector3(0, JumpSpeed, 0), ForceMode.Impulse);
        }
    }
}
