using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void switchScene()
    {
        SceneManager.LoadScene(2);
    }
    public void RestartTime() {
        Time.timeScale = 1f;
    }
    public void mainMenu() {
        SceneManager.LoadScene(0);
    }
    public void goodend() {
        SceneManager.LoadScene(3);
    }
    public void normalend()
    {
        SceneManager.LoadScene(4);
    }
    public void badend()
    {
        SceneManager.LoadScene(5);
    }
}
