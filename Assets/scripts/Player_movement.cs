using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
      private Rigidbody2D physics;
      private BoxCollider2D coll;

      private float vel = 0f;

      [SerializeField] private LayerMask jumpableGround;

      [SerializeField] private float moveSpeed = 10.5f;
      [SerializeField] private float jumpForce = 14f;

     

    // Start is called before the first frame update
    void Start()
    {
     physics = GetComponent<Rigidbody2D>();
     coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
       vel = Input.GetAxisRaw("Horizontal");
      physics.velocity = new Vector2(vel * moveSpeed, physics.velocity.y);
       
        if (Input.GetButtonDown("Jump") && IsGrounded() ) 
      {
            physics.velocity = new Vector2(physics.velocity.x, jumpForce);
      }
}
private bool IsGrounded()
{
return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
}



}