using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    private float JumpingPower = 16f;

    private Vector2 movement;
    private Rigidbody2D rb;
    public LayerMask groundLayer;

    Vector2 vecMove;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (movement.x != 0 | movement.y != 0)
        {
            rb.velocity = movement * speed;
        }
        flip();
    }
    public void OnMove(InputAction.CallbackContext ctx) => movement = ctx.ReadValue<Vector2>();

    public void Jump(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
        }
    }

    void flip()
    {
        if (vecMove.x < -0.01f) transform.localScale = new Vector3(-1, 1, 1);
        if (vecMove.x > 0.01f) transform.localScale = new Vector3(1, 1, 1);
    }
}
