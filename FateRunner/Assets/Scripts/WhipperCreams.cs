using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipperCreams : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Hero")
        {
            Shop.WhipperNumber +=1;
            Destroy(this.gameObject);
        }

    }
}
