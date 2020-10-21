using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _playerSpeed = 1.0f;
    public float _jumpForce = 16.0f;

    private Rigidbody2D _rigidBody;

    private float _movementInputDirection;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    private void CheckInput()
    {
        _movementInputDirection = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
            Jump();
    }

    private void ApplyMovement()
    {
        _rigidBody.velocity = new Vector2(_movementInputDirection * _playerSpeed, _rigidBody.velocity.y);
    }

    private void Jump()
    {
        _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, _jumpForce);
    }
}
