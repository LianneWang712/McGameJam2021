using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private Transform player;
    // base speed of the movement
    public float speed = 40.0f;
    public bool faceRight;
    public Vector3 pos;
    public Vector3 velocity;
    playermovement movementscript;

    // Start is called before the first frame update
    void Start()
    {
        movementscript = GameObject.Find("player").GetComponent<playermovement>();
        
        player = GameObject.Find("player").GetComponent<Transform>();
        if (!movementscript.faceRight)
        {
            velocity = new Vector3(Time.deltaTime * (-1f) * speed, 0f, 0f);
            //transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (movementscript.faceRight)
        {
            velocity = new Vector3(Time.deltaTime * speed, 0f, 0f);
            // transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        pos = transform.position;
    }
    private void Awake()
    {
       
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        pos += velocity;
        transform.position = pos;
           
            // move the object towards the player at the specifed speed

    }
    
}
