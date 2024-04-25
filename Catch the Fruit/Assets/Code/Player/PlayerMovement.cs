using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
        public Rigidbody2D rb;
        public float baseSpeed = 4.5f;
        public float sprintSpeed = 7f;

        private Vector2 move;
        private float currMoveSpeed;
        
    void Start()
    {
        currMoveSpeed = baseSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(move.x * currMoveSpeed, 0);
    }

    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void Sprint(InputAction.CallbackContext context)
    {
        if (context.started) {
            currMoveSpeed = sprintSpeed;
        } else if (context.canceled) {
            currMoveSpeed = baseSpeed;
        }
    }
}
