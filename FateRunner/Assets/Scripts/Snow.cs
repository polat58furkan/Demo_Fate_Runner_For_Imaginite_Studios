using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    void Awake() 
    {
        this.gameObject.transform.position=new Vector3(0,0,0);
    }
    void FixedUpdate()
    {
        this.gameObject.transform.position-=new Vector3(0,0.01f,0);
        if(this.transform.position.y<=0)
        {
            this.gameObject.transform.position= new Vector3(this.transform.position.x,8,this.transform.position.z);
        }
        
    }
}
