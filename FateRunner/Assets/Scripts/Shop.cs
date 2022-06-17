using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject ShopCamera;
    public GameObject ShopCanvas;
    public GameObject ShopComponent;

    public GameObject WhipperNumberCanvas;
    public static int WhipperNumber=0;
    //bool nextStep=false;
    //bool nextStep2=false;

    void Awake() 
    {
        WhipperNumber=0;
        ShopCamera.SetActive(false);
        ShopCanvas.SetActive(false);
        ShopComponent.SetActive(true);

    }
    void FixedUpdate()
    {
        WhipperNumberCanvas.GetComponent<Text>().text=WhipperNumber.ToString();
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Hero")
        {
            Movement.walk=false;
            Movement.LeftRight=false;
            Animations.AnimationIdle=true;
            
            ShopCamera.SetActive(true);
            ShopCanvas.SetActive(true);

        }
    }

    public void Convert()
    {
        //Convert the whippercreams to diamonds
        Diamond.DiamondNumber+= WhipperNumber*10;;
        WhipperNumber=0;
        WhipperNumberCanvas.GetComponent<Text>().text=WhipperNumber.ToString();
        ShopCamera.SetActive(false);
        ShopCanvas.SetActive(false);
        ShopComponent.SetActive(false);

        Movement.walk=true;
        Movement.LeftRight=true;
        Animations.AnimationIdle=false;
    }
}
