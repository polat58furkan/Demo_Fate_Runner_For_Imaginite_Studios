using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triangle : MonoBehaviour
{
    public bool calculate=false;
    public bool onetime=true;
    public int x;

    private void Awake() 
    {
        onetime=true;
    }
    void FixedUpdate() 
    {
        if(calculate==true & onetime==true)
        {
            x =int.Parse(this.gameObject.GetComponentInChildren<TextMesh>().text);
            if(x!=1 & x!=-1)
            {
                Diamond.DiamondNumber+=x;
            }
            else if(x==1)
            {
                //Joker = All Diamond x2
                Diamond.DiamondNumber*=2;
            }
            else if (x==-1)
            {
                //Loss  = Lose All Diamond;
                Diamond.DiamondNumber*=0;
            }
            GameManager.GoToNextMap=true;
            calculate=false;
            onetime=false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Triangle")
        {
            
            if(WheelOfFortune.WheelOfFortuneFinished==true)
            {
                calculate=true;
                WheelOfFortune.WheelOfFortuneFinished=false;
            }   
        }
    }
    
}
