using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{


    public void StartToGame()
    {
        SceneManager.LoadScene(Random.Range(1,6));
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Next()
    {
        SceneManager.LoadScene(LittleTriangle.NextMap);
        
    }


}
