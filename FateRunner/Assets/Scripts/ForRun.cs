using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForRun : MonoBehaviour
{
    public static bool Run=false;

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Hero")
        {
            Movement.walk=false;
            Run=true;
        }
    }
}
