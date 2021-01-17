using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLetter : MonoBehaviour
{
    private bool playerInRange = false;
    public GameObject choice;
    public GameObject dialog1,dialog2,dialog3;
    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E)) {
                choice.SetActive(true);
                dialog1.SetActive(false);
                dialog2.SetActive(false);
                dialog3.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInRange = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInRange = false;
    }
}
