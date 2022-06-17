using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameObject WhippedCreamPosition;
    public GameObject WhippedCream;
    public GameObject Rotor;
    
    public float x;
    public float timer,timer2 = 0;
    void Awake() 
    {
        this.transform.position= new Vector3(-1,4.5f,10);
        
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime * 10;
        x = Mathf.Sin(timer)*2;
        transform.position = Vector3.Lerp(transform.position, transform.position+new Vector3(x,0,1f),0.1f) ;
        
        timer2 += Time.deltaTime;
        
        if(timer2-1f>0)
        {
            timer2 = 0;
            GameObject WhippedCreams = Instantiate(WhippedCream, WhippedCreamPosition.transform.position, Quaternion.identity);
            
        }
        
        if(transform.position.z>=75)
        {
            Destroy(this.gameObject);
        }

        Rotor.transform.Rotate(0,0,10f);
    }
}
