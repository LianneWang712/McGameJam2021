using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public GameObject zombieObject;
    public Transform player;
    public GameObject playerObject;
    public Rigidbody2D zombierb;
    public Transform zombie;
    public float speed;
    public bool faceRight;
    Vector3 direction;
    private Vector3 scaleRight = new Vector3(1, 1, 1);//use this localscale when the player is facing right
    private Vector3 scaleLeft = new Vector3(-1, 1, 1);// when player face left
    public GameObject heart1, heart2, heart3;
    public GameObject gameOverPanel;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = player.position - zombie.position;
        direction /= (direction.magnitude);
        if (direction.x > 0) {
            zombie.localScale = scaleRight;
        }
        else if (direction.x < 0) {
            zombie.localScale = scaleLeft;
        }
    }
    private void FixedUpdate()
    {
        moveZombie();
    }
    void moveZombie() {
        zombierb.MovePosition(zombie.position + (direction * speed * Time.deltaTime));
    }
    void flip()
    {
        faceRight = !faceRight;
        Vector3 scale = zombie.localScale;
        scale.x *= (-1);
        zombie.localScale = scale;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet")){
            zombieObject.SetActive(false);
            Destroy(collision.gameObject);
            playerObject.GetComponent<playermovement>().hasKilled = true;
        }

        // check if collision is with player and the player doesn't have i-frames
        if (collision.CompareTag("player") && !playerObject.GetComponent<playermovement>().invicible) {
            if (heart3.activeInHierarchy)
            {
                heart3.SetActive(false);
            }
            else if (heart2.activeInHierarchy)
            {
                heart2.SetActive(false);
            }
            else if (heart1.activeInHierarchy) {
                heart1.SetActive(false);
                speed = 0f;
                gameOverPanel.SetActive(true);
            }

        }
    }
   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("destoryZombie");
        if (collision.collider.tag == "bullet")
        {
            zombieObject.SetActive(false);
        }
    }*/
}
