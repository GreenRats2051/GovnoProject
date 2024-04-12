using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Vector2 inputMove;
    public float speed;

    void Start()
    {
        PlayerInput PlayerInput = new PlayerInput();
        PlayerInput.Enable();
        PlayerInput.Player.Move.performed += context => inputMove = context.ReadValue<Vector2>();
        PlayerInput.Player.Move.canceled += context => inputMove = Vector2.zero;
    }

    void Update()
    {
        rigidbody.velocity = new Vector2(inputMove.x * speed, inputMove.y * speed);
    }
}
