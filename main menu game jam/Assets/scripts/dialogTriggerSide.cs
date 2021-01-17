using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogTriggerSide : MonoBehaviour
{
    public GameObject panel;
    public GameObject frontDoor;
    public GameObject story1;
    bool playerInRangeside = false;
    public dialogTriggerFront openDoorScript;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        openDoorScript = GameObject.Find("frontDoor").GetComponent<dialogTriggerFront>();
    }
    void Update()
    {
        if (playerInRangeside) {
            if (Input.GetKeyDown(KeyCode.E)&&openDoorScript.interactedFrontDoor) {
                panel.SetActive(true);
                story1.SetActive(false);
               
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player")) {
            playerInRangeside = true;
        
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            playerInRangeside = false;

        }
    }
}
