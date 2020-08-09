using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class LevelController : MonoBehaviour
{
    public void ToLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void ToLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void ToLevel3()
    {
    //    SceneManager.LoadScene(3);
    } 
    //public void NextLevel()
    //{
      //  SceneManager.LoadScene(1);
        //Debug.Log("NextLevel!");
    //}

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("RestartLevel!");
    }

    public void WinScreen()
    {
        SceneManager.LoadScene(3);
        Debug.Log("You won!");
    }
}
