using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField] public InputReader InputReader { get; private set; }
    [field: SerializeField] public Rigidbody rb { get; private set; }

    public float MovementSpeed;

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

    void OnDestroyed()
    {
        InputReader.JumpEvent -= OnJump;
    }

    void OnJump()
    {
        rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        transform.Translate(new Vector3(0, 0, 0));
    }
}
