using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Dealer : MonoBehaviour
{
    public enum DealerState  {MOVE, IDLE}
    public DealerState CurrentState;
    public GameObject hand;
    public float time = 0;
    private float WaitTime = 1f;


    // Start is called before the first frame update
    void Start()
    {
        CurrentState = DealerState.IDLE;
        Quaternion originalRotation = hand.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        switch (CurrentState)
        {
            case DealerState.MOVE:
                //rotate
                time += Time.deltaTime;
                if (time >= WaitTime)
                {
                    //hand.transform.rotation = Quaternion.Euler(0f, 0.0f, 45f);
                    // hand.transform.rotation = originalRotation;
                    StopAnimation();
                    CurrentState = DealerState.IDLE;
                }

                break;

            case DealerState.IDLE:
                //function
                
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    PlayAnimation();
                    //hand.transform.Rotate(0f, 0.0f, 45f, Space.Self);
                    CurrentState = DealerState.MOVE;
                    time = 0; 
                }
                break;
        }
    }
    
    public void ChangeState() 
    {
        print("HI");
    }

    public void PlayAnimation()
    {
        //hand.GetComponent<Animator>().SetBool("Start", true);
        hand.GetComponent<Animator>().SetTrigger("D_Start");
    }
    public void StopAnimation()
    {
        //hand.GetComponent<Animator>().SetBool("Start", false);
    }

}
