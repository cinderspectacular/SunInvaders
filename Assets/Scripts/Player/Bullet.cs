using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 mousePos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        float speed = 20f;
        mousePos = Mouse.current.position.ReadValue();
        float mouseX = mousePos.x;
        float mouseY = mousePos.y;
        
        rb.AddForce(new Vector3 ((mouseX - 556)/10, (mouseY - 316)/10, speed), ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
