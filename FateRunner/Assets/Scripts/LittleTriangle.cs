using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleTriangle : MonoBehaviour
{
    public static int NextMap;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="LittleTriangle")
        {
            
            if( WheelOfFortune.WheelOfFortuneFinishedForLittle == true)
            {
                int x =int.Parse(this.gameObject.GetComponentInChildren<TextMesh>().text);
                NextMap=x;
                WheelOfFortune.WheelOfFortuneFinishedForLittle=false;
            }
        }
    }
    void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.tag=="LittleTriangle")
        {
            
            if( WheelOfFortune.WheelOfFortuneFinishedForLittle == true)
            {
                int x =int.Parse(this.gameObject.GetComponentInChildren<TextMesh>().text);
                NextMap=x;
                WheelOfFortune.WheelOfFortuneFinishedForLittle=false;
            }
        }    
    }

}
