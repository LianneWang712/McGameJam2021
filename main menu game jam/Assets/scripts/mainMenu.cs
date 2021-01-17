using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
   public void quit() {
        Application.Quit();
   }
    public void play() {
        SceneManager.LoadScene(1);
    }
}
