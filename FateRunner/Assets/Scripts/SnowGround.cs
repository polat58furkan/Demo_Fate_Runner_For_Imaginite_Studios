using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowGround : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Hero")
        {

            Movement.balance=true;
            Movement.walk=false;
        }

    }
    
    void OnCollisionExit(Collision other) 
    {
        if(other.gameObject.tag=="Hero")
        {
            Movement.walk=true;
            Movement.balance=false;
        }
        
    }
}
