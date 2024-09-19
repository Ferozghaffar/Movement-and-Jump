using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    public float speed;
    public float jump;

    private float Move;
    public Rigidbody2D myRigidBody;
    public bool isjumping;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        myRigidBody.velocity = new Vector2(speed * Move, myRigidBody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isjumping == false)
        {
            myRigidBody.AddForce(new Vector2(myRigidBody.velocity.x, jump));
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            isjumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            isjumping = true;
        }
    }
}
