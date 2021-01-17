using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelection : MonoBehaviour
{
    public void level1(){
        SceneManager.LoadScene(1);
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
    }
    public void level4()
    {
        SceneManager.LoadScene(4);
    }
    public void level5()
    {
        SceneManager.LoadScene(5);
    }
    public void level6()
    {
        SceneManager.LoadScene(6);
    }
}
