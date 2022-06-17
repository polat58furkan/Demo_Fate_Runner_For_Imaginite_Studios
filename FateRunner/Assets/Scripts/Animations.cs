using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator animator;

    public static bool AnimationWalk=false;
    public static bool AnimationSad=false;
    public static bool AnimationRun=false;
    public static bool AnimationIdle=false;
    public static bool AnimationBalance=false;
    void Awake()
    {
        animator=this.gameObject.GetComponent<Animator>();
        AnimationWalk=false;
        AnimationSad=false;
        AnimationRun=false;
        AnimationIdle=false;
        AnimationBalance=false;

    }


    void FixedUpdate() 
    {
        if(AnimationWalk==true)
        {
            animator.SetBool("run",false);
            animator.SetBool("sad",false);
            animator.SetBool("balance",false);
            animator.SetBool("walk",true);
        }

        if(AnimationSad==true)
        {
            Movement.walk=false;
            Movement.LeftRight=false;
            ForRun.Run=false;
            animator.SetBool("walk",false);
            animator.SetBool("run",false);
            animator.SetBool("balance",false);
            animator.SetBool("sad",true);
            
            StartCoroutine(Cry(3f));
            
        }
        if(AnimationIdle==true)
        {
            animator.SetBool("sad",false);
            animator.SetBool("walk",false);
            animator.SetBool("run",false);
            animator.SetBool("balance",false);
        }
        if(AnimationRun==true)
        {
            animator.SetBool("walk",false);
            animator.SetBool("sad",false);
            animator.SetBool("balance",false);
            animator.SetBool("run",true);
        }

        if(AnimationBalance==true)
        {         
            animator.SetBool("sad",false);
            animator.SetBool("walk",false);
            animator.SetBool("run",false);
            animator.SetBool("balance",true);

        }
    }
    IEnumerator Cry(float time )
    {
        while(0<=time)
        {
            time-= Time.deltaTime;
            if(time<=0.01)
            {
                GameManager.GameFinished=true;
            }
            yield return 0;
        }
    }
}
