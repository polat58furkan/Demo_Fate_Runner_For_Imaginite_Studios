using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject NextMapCanvas;
    public static bool GoToNextMap=false;


    public GameObject GameFinishedCanvas;
    public static bool GameFinished=false;

    public GameObject Hero;

    void Awake() 
    {
        GoToNextMap=false;
        GameFinished=false;
        NextMapCanvas.SetActive(false);
        Time.timeScale=1;
    }

    void FixedUpdate()
    {
        if(GoToNextMap==true)
        {
            if(NextMapCanvas.activeInHierarchy==false)
            {
                NextMapCanvas.SetActive(true);

                GoToNextMap=false;
                //Time.timeScale=0;
            }
        }

        if(GameFinished==true)
        {
            GameFinishedCanvas.SetActive(true);
            Time.timeScale=0;
        }
        if(GameFinished==false)
        {
            GameFinishedCanvas.SetActive(false);
        }

        if(Hero.transform.position.y< -0.2)
        {
            GameFinished=true;
        }
    }

}
