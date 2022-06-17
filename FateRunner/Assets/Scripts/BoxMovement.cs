using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public float x=0;
    void FixedUpdate()
    {
        x+=Time.deltaTime;
        if(x>=360)x=0;
        if(this.gameObject.tag=="TNT")
        {
            this.gameObject.GetComponent<Rigidbody>().velocity= new Vector3(Mathf.Sin(x)*2f,0,0);
        }
    }
}
