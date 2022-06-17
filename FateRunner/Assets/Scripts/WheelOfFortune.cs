using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WheelOfFortune : MonoBehaviour
{
    public GameObject TurnToWheelOfFortune;
    public static bool TouchToWheelOfFortune=false;
    [SerializeField] public List<GameObject> cinemachines= new List<GameObject>(); 
    bool nextStep=false;
    bool nextStep2=false;
    bool nextStep3=false;
    public static bool WheelOfFortuneFinished=false;
    public static bool WheelOfFortuneFinishedForLittle=false;
    public float y=0;
    public float timer=0;
    public float First,Last;
    void Awake() 
    {
        cinemachines[0].SetActive(true);
        cinemachines[1].SetActive(false);
        WheelOfFortuneFinished=false;
        WheelOfFortuneFinishedForLittle=false;
    }
    void Update()
    {
        if(nextStep==true)
        {
            if (Input.touchCount>0)
            {
                Touch finger =Input.GetTouch(0);
                // y = finger Last Position - First Position
                //y=finger.deltaPosition.y;

                if (finger.phase == TouchPhase.Began)
                {
                    First=finger.position.y;
                }

                if (finger.phase == TouchPhase.Ended)
                {
                    Last=finger.position.y;

                    y=Last-First;
                    y=Mathf.Abs(y);

                    if(y!=0)
                    {
                        nextStep=false;
                        nextStep2=true;
                    }
                    else
                    {
                        nextStep=true;
                    }
                }

            }

        }
    }

    void FixedUpdate() 
    {
        if(TouchToWheelOfFortune==true)
        {
            Movement.walk=false;
            Movement.LeftRight=false;
            ForRun.Run=false;
            Animations.AnimationIdle=true;
            Animations.AnimationWalk=false;
            Animations.AnimationRun=false;
            cinemachines[0].SetActive(false);
            cinemachines[1].SetActive(true);
            nextStep=true;
            TouchToWheelOfFortune=false;
            
        }
        
        if(nextStep2==true)
        {
 
            float maxAngle =y*30f;
            float randomTime =100f;
            StartCoroutine (Spin(randomTime , maxAngle));
            
        }
        if(nextStep3==true)
        {
 
            WheelOfFortuneFinished=true;
            WheelOfFortuneFinishedForLittle=true;
            nextStep3=false;
        }

    }

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag=="Hero")
        {
            TouchToWheelOfFortune=true;
        }   
    }

    IEnumerator Spin(float time , float maxAngle)
    {
        maxAngle=maxAngle-0f;
        while(timer<time)
        {
            float angle=maxAngle*(timer/time);
            TurnToWheelOfFortune.transform.eulerAngles= new Vector3(0,0,angle);
            timer+=Time.deltaTime;
            yield return 0;
        }
        TurnToWheelOfFortune.transform.eulerAngles= new Vector3(0,0,maxAngle);
        nextStep2=false;
        nextStep3=true;
    }
}
