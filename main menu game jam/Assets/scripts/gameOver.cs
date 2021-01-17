using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public void retry() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void mainMenu() {
        SceneManager.LoadScene(0);
    }
}
