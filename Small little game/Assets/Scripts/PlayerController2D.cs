using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float playerMoveSpeed = 5f;

    [SerializeField] private float rotationSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        RotatePlayer();
    }

    private void PlayerMovement()
    {
        /* if (Input.GetKeyDown(KeyCode.A)) { rb.velocity = Vector2.left * playerMoveSpeed; }
         if (Input.GetKeyDown(KeyCode.D)) { rb.velocity = Vector2.right * playerMoveSpeed; }

         if (Input.GetKeyDown(KeyCode.W)) { rb.velocity = Vector2.up * playerMoveSpeed; }
         if (Input.GetKeyDown(KeyCode.S)) { rb.velocity = Vector2.down * playerMoveSpeed; }*/



        Vector2 move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        rb.velocity = move * playerMoveSpeed;
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }

    }
}
