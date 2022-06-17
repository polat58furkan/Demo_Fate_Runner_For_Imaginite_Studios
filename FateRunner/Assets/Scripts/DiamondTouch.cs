using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondTouch : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Diamond")
        {
            Diamond.DiamondNumber+=1;
            Destroy(other.gameObject);
        }
    }

}
