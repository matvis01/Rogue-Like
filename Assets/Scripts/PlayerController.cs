using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;
    private Animator animator;
    private Vector3 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

        if (movementDirection != Vector3.zero) {
            animator.SetBool("isRunning", true);

            if(movementDirection.x < 0) {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180f, 0));
            }
            else if (movementDirection.x > 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection.normalized * speed;
    }
}
