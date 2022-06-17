using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    public void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag=="Hero")
        {
            Movement.walk=false;
            Animations.AnimationSad=true;
        }
    }
}
