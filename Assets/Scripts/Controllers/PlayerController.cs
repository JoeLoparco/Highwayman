using System.Collections;
using System.Collections.Generic;
using UnityEngine;  // This is the only using statement you need

public class ShipController : MonoBehaviour
{
    private bool _moving;
    private int _direction;  // Add this to track position
    private Rigidbody2D _rb;
    // Force applied when thrusting
    public float walkSpeed = 5f; // Maximum speed the ship can reach
    private Vector2 moveInput;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        Debug.Log("Rigidbody2D component: " + (_rb != null));  // Debug line
        
        _rb.gravityScale = 0f;
        //_rb.constraints = RigidbodyConstraints2D.FrezeRotation;
    }
    void Update()
    {
        //Note We use a popular system for 8d movement and simply floor the undesried axis to 0 for 4d.
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveInput = new Vector2(0,verticalInput);
            _direction = 0;
            _moving = true;
        }else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveInput =  new Vector2(horizontalInput,0);
            _direction = 1;
            _moving = true;
        }else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveInput = new Vector2(0,verticalInput);
            _direction = 2;
            _moving = true;
        }else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveInput = new Vector2(horizontalInput, 0);
            _direction = 3;
            _moving = true;
        }else 
        {
            moveInput = new Vector2(0, 0); // Else we are not moving
            _moving = false;
        }
        animator.SetInteger("direction", _direction);
        animator.SetBool("walking", _moving);
        /*
        // Add shooting input
        if (Input.GetKey(KeyCode.Space) && Time.time > _nextFireTime)
        {
            Shoot();
            _nextFireTime = Time.time + fireRate;
        }
        */
        
    }
    void FixedUpdate()  
    {
        Move();
    }

/*
    private void Shoot()
    {
        Debug.Log("Shoot component: " + (bulletPrefab != null));  // Debug line
        Bullet bullet = Instantiate(this.bulletPrefab, this.transform.position ,this.transform.rotation);
        bullet.Project(this.transform.up);
    }
*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }
    
     private void Move()
    {
        // Calculate velocity and apply it to the Rigidbody2D
        Vector2 velocity = moveInput * walkSpeed;
        _rb.velocity = velocity;
    }
}
