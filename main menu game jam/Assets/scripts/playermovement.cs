using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
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
    public GameObject projectilePrefab;
    public float negXRange = -9.0f;
    public float topYRange = 2.5f;
    public float bottomYRange = -4.5f;
    public GameObject heart1;
    public bool invicible = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {    
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        else animator.SetBool("shooting", false);
        if (Input.GetKey(KeyCode.Space)){
            animator.SetBool("shooting", true);
        }
        else animator.SetBool("shooting", false);

        if (playerData.hasKilled)
        {
            Debug.Log("has killed");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        collisionCalled = false;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // check to see if a game over has occured
        if (!heart1.activeInHierarchy)
        {
            player.position = new Vector3(player.position.x, player.position.y, player.position.z);
        }
        else if (movement != Vector3.zero )
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

        // check to make sure player doesn't go out of bounds
        if (player.position.x < negXRange)
        {
            player.position = new Vector3(negXRange, player.position.y, player.position.z);
        }
        if (player.position.y > topYRange)
        {
            player.position = new Vector3(player.position.x, topYRange, player.position.z);
        }
        if (player.position.y < bottomYRange)
        {
            player.position = new Vector3(player.position.x, bottomYRange, player.position.z);
        }

    }
    void flip() {
        faceRight = !faceRight;
        Vector3 scale = player.localScale;
        scale.x *=(-1);
        player.localScale = scale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!invicible)
        {
            if (collision.CompareTag("zombie"))
            {
                // start the flashing sprite animation and i-frames when hit by an enemy
                StartCoroutine(Flashing());
                StartCoroutine(Invulnerability());
            }
        }
    }

    IEnumerator Invulnerability()
    {
        invicible = true;
        yield return new WaitForSeconds(2.0f);
        invicible = false;
    }

    IEnumerator Flashing()
    {
        for (int n = 0; n < 2; n++)
        {
            
            GetComponent<SpriteRenderer>().color = Color.red;
            yield return new WaitForSeconds(0.5f);
            GetComponent<SpriteRenderer>().color = Color.white;
            yield return new WaitForSeconds(0.5f);
        }   
    }

}
