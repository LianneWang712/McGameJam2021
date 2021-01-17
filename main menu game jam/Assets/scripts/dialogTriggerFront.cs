using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogTriggerFront : MonoBehaviour
{
    public GameObject panel;
    public GameObject story;
    private bool playerInRangefront = false;
    public bool interactedFrontDoor = false;
    

    private void Update()
    {
        if (playerInRangefront) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                interactedFrontDoor = true;
                panel.SetActive(true);
                story.SetActive(false);
                Time.timeScale = 0f;
            }
        }
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        playerInRangefront = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInRangefront = false;
    }
}
