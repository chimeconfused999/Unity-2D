using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanScript : MonoBehaviour
{ 
    public float speed;
    public Rigidbody2D myRigidBody;
    private float move;
    public float jump = 500;
    public bool isjumping;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Character";
    }

    // Update is called once per frame
    void Update()
    {
       move = Input.GetAxis("Horizontal");
       myRigidBody.velocity = new Vector2(speed * move, myRigidBody.velocity.y);

       if (Input.GetKeyDown(KeyCode.Space) == true && isjumping == false)
       {
            myRigidBody.AddForce(new Vector2(myRigidBody.velocity.x, jump));
            isjumping = true;
       }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
         if (other.gameObject.tag == "Ground")
         {
            isjumping = false;
         }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
         if (other.gameObject.tag != "Ground")
         {
            isjumping = true;
         }
    }
}