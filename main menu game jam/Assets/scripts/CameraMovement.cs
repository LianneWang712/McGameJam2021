using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Transform camera;
    public float lerpSpeed;
    public Vector2 maxPos;
    public Vector2 minPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, camera.position.z);
        targetPos.x = Mathf.Clamp(targetPos.x, minPos.x, maxPos.x);
        targetPos.y = Mathf.Clamp(targetPos.y, minPos.y, maxPos.y);
        camera.position = Vector3.Lerp(camera.position, targetPos, lerpSpeed);
    }
}
