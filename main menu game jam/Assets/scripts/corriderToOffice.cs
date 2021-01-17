using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corriderToOffice : MonoBehaviour
{
    public Transform player;
    public GameObject camera1, camera2;
   // public GameObject grid1,grid2;
    public Camera cam1, cam2;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void OnTriggerEnter2D(Collider2D collision)
    {
        player.position = new Vector3(26f, 0.1f, 0f);
        camera1.SetActive(false);
        camera2.SetActive(true);
        cam1.enabled = false;
        cam2.enabled = true;
    }
}
