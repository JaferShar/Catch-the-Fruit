using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
        public Rigidbody2D rb;
        private float baseSpeed = 9f;
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
}
