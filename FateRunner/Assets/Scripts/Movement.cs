using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    Animator animator;
    public float speed=4f;
    public float LeftRightSpeed=1f;
    
    public static bool walk=false;
    public static bool LeftRight=true;
    public static bool balance=false;
    public float x;

    public bool once=true;
    void Awake()
    {
        this.gameObject.transform.position=new Vector3(0,0,0);
        rb=this.gameObject.GetComponent<Rigidbody>();
        animator=this.gameObject.GetComponent<Animator>();
        LeftRight=true;
        once=true;
        ForRun.Run=false;
        balance=false;
        walk=false;
    }

    void Update() 
    {
        if(Input.touchCount>0)
        {   
            if(once==true)
            {
                walk=true;
                once=false;
            }
            Touch finger =Input.GetTouch(0);
            // x = finger Last Position - First Position
            x=finger.deltaPosition.x;
        }
        else
        {
            x=0;
        } 
    }

    void FixedUpdate()
    {
        if(walk==true)
        {
            Walk();
        }
        if(LeftRight==true)
        {
            MoveRightOrLeft();
        }

        if(ForRun.Run==true)
        {
            Run();
        }
        if(balance==true)
        {
            Balance();
        }
    }

    public void Walk()
    {

        ForRun.Run=false;
        balance=false;
        speed=4f;
        rb.MovePosition(this.transform.position+new Vector3(0,0,1)*Time.deltaTime*speed);
        Animations.AnimationBalance=false;
        Animations.AnimationWalk=true;
    }

    public void MoveRightOrLeft()
    {
        if(x>10)x=10;
        if(x<-10)x=-10;
        rb.velocity=new Vector3(x,0,0)*LeftRightSpeed;
        
    }
    public void Run()
    {   
        walk=false;
        speed=8f;
        rb.MovePosition(this.transform.position+new Vector3(0,0,1)*Time.deltaTime*speed);
        Animations.AnimationRun=true;
    }

    public void Balance()
    {
        walk=false;
        speed=4f;
        rb.MovePosition(this.transform.position+new Vector3(0,0,1)*Time.deltaTime*speed);
        Animations.AnimationBalance=true;


    }
    
}
