using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlantPosition : MonoBehaviour
{
    public bool playerInRange = false;
    public GameObject story;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (playerInRange) {
            if (Input.GetKeyDown(KeyCode.E)) {
                story.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("ENTER");
        playerInRange = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInRange = false;
    }
}
