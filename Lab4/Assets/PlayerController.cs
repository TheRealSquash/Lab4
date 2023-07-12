using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 5f, strafeSpeed = 3f;
    private float horizontal = 0.0f, vertical = 0.0f;
    private Rigidbody rb;
    private bool forward, backward, left, right;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void FixedUpdate() {
        MovePlayer();
    }

    private void GetInput() {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void MovePlayer() {
        // Movement
        Vector3 movementDirection = Vector3.zero;

        Vector3 forwardVel = transform.forward * vertical * (vertical < 0 ? strafeSpeed : speed);
        Vector3 strafeVel = transform.right * horizontal * strafeSpeed;
        movementDirection = forwardVel + strafeVel;
        movementDirection *= Time.deltaTime; // Apply the speed after calculating the movement direction

        Vector3 vel = new Vector3(movementDirection.x * 100, rb.velocity.y, movementDirection.z * 100);
        rb.velocity = vel;
    }
}
