using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _controller;

    [SerializeField]
    private float _velocity = 6.0f;
    [SerializeField]
    private float _gravity = 1.0f;
    [SerializeField]
    private float _jumpHeight = 15.0f;
    private float yVelocity;
    private bool _canDoubleJump = false;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalInput, 0, 0);
        direction *= _velocity;

        if (_controller.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = _jumpHeight;
                _canDoubleJump = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_canDoubleJump == true)
                {
                    yVelocity += _jumpHeight;
                    _canDoubleJump = false;
                }
                
               
            }
            yVelocity -= _gravity;
        }

        direction.y = yVelocity;

        _controller.Move(direction * Time.deltaTime);
    }
}
