using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinLabMovement : MonoBehaviour
{
    public Animator animator;
    public Transform player;
    public Vector3 movement = new Vector3();
    public float speed = 10f;
    public bool moving = true;
    public bool collisionCalled = false;
    public bool changeDir = false;
    public bool faceRight = true;
    private Vector3 scaleRight = new Vector3(1, 1, 1);//use this localscale when the player is facing right
    private Vector3 scaleLeft = new Vector3(-1, 1, 1);// when player face left
    //public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        collisionCalled = false;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement != Vector3.zero)
        {
            //if (moving == true || collisionCalled == false) {
            //  player.Translate(movement.x * speed * Time.fixedDeltaTime, movement.y * speed * Time.fixedDeltaTime, 0);
            //}
            player.Translate(movement.x * speed * Time.fixedDeltaTime, movement.y * speed * Time.fixedDeltaTime, 0f);

            animator.SetBool("running", true);

            if (movement.x > 0 && !faceRight)
            {
                flip();
            }
            else if (movement.x < 0 && faceRight)
            {
                flip();
            }

        }
        else
        {
            animator.SetBool("running", false);
        }

    }
    void flip()
    {
        faceRight = !faceRight;
        Vector3 scale = player.localScale;
        scale.x *= (-1);
        player.localScale = scale;
    }

    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         collisionCalled = true;
         if (collision.collider.tag == "Collision")
         {
             player.Translate(0, 0, 0);
             Debug.Log("collides");
             moving = false;
         }
         else moving = true;

     }*/
}
