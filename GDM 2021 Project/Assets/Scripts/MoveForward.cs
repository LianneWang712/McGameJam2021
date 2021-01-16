using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // base speed of the movement
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move the object towards the player at the specifed speed
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
