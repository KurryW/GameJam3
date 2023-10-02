using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Waypoints1 : MonoBehaviour
{
    //public Waypoints2 waypoints2Script;
    public GameObject Buddy;
    public NavMeshAgent agent;
    public List<GameObject> waypoints2;

    public Transform target2;

    public float speed;
    int index = 0;

    private Animator anim;


    //private bool PLayerHasArrivedBy1;

    //public enum State
    //{
    //    Idle, Moving, LongWait
    //}
    //public State state = State.Moving;

    //private bool PLayerHasArrivedBy2;
    //private float waitTimer = 0;
    //public float waitTime = 3f;
    //public float LongWaitTimer = 10f;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    public void Update()
    {
        anim.SetBool("Walk", true);
        Vector3 destination = waypoints2[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed);
        transform.position = newPos;
        transform.LookAt(target2);

        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= 0.05)
        {
            index++;
            //Debug.Log("ik ga lopen naar 1");

            //if (index == 1)
            //{
            //    Text2.SetActive(true);
            //    PressSpacebarText.SetActive(true);
            //}

            //if (index == 2)
            //{
            //    Text2.SetActive(false);
            //    PressSpacebarText.SetActive(false);
            //    Text3.SetActive(true);
            //}

            //if (index == 3)
            //{
            //    Text3.SetActive(false);
            //}

            //if (index == 4)
            //{
            //    anim.SetBool("Walk", false);

            //}

            if (index >= waypoints2.Count)
            {

                Invoke(nameof(Update), 150f);
                Debug.Log("ffe wachten 10 sec");
                Buddy.GetComponent<Waypoints2>().enabled = true;
                Debug.Log("script is off");
            }

        }


    }
}

    //    if (PLayerHasEntered)
    //    {
    //        if (state == State.Idle)
    //        {
    //            anim.SetBool("Walk", false);

    //            if (waitTimer <= 0)
    //            {
    //                state = State.Moving;
    //            }
    //            else
    //            {
    //                waitTimer -= Time.deltaTime;
    //            }
    //        }
    //        else if (state == State.Moving)
    //        {

    //            anim.SetBool("Walk", true);
    //            Vector3 destination = waypoints[index].transform.position;
    //            float distance = Vector3.Distance(transform.position, destination);
    //            if (distance <= agent.stoppingDistance)
    //            {
    //                index++;
    //                state = State.Idle;
    //                waitTimer = waitTime;
    //            }
    //            else
    //            {
    //                if (destination != agent.destination)
    //                {
    //                    agent.SetDestination(destination);
    //                }
    //            }
    //        }
    //    }

    //    if (waypoints[4])
    //    {
    //        waitTimer = LongWaitTimer;
    //        if (state == State.Idle)
    //        {
    //            anim.SetBool("Walk", false);

    //            if (waitTimer <= 0)
    //            {
    //                state = State.Moving;
    //            }
    //            else
    //            {
    //                waitTimer -= Time.deltaTime;
    //            }
    //        }


    //        else if (state == State.Moving)
    //        {

    //            anim.SetBool("Walk", true);
    //            Vector3 destination2 = waypoints2[index].transform.position;
    //            float distance2 = Vector3.Distance(transform.position, destination2);
    //            if (distance2 <= agent.stoppingDistance)
    //            {
    //                index++;
    //                state = State.Idle;
    //                waitTimer = waitTime;
    //            }
    //            else
    //            {
    //                if (destination2 != agent.destination)
    //                {
    //                    agent.SetDestination(destination2);
    //                }
    //            }

    //        }

    //        if (waypoints2[3])
    //        {
    //            if (state == State.Idle)
    //            {
    //                anim.SetBool("Walk", false);

    //                if (waitTimer <= 0)
    //                {
    //                    state = State.Moving;
    //                }
    //                else
    //                {
    //                    waitTimer -= Time.deltaTime;
    //                }
    //            }
    //            else if (state == State.Moving)
    //            {

    //                anim.SetBool("Walk", true);
    //                Vector3 destination3 = waypoints3[index].transform.position;
    //                float distance3 = Vector3.Distance(transform.position, destination3);
    //                if (distance3 <= agent.stoppingDistance)
    //                {
    //                    index++;
    //                    state = State.Idle;
    //                    waitTimer = waitTime;
    //                }
    //                else
    //                {
    //                    if (destination3 != agent.destination)
    //                    {
    //                        agent.SetDestination(destination3);
    //                    }
    //                }
                    
                    
    //                //Vector3 newPos2 = Vector3.MoveTowards(transform.position, destination2, speed = Time.deltaTime);
    //                //transform.position = newPos2;
    //                //transform.LookAt(target2);


    //            }
    //        }




    //    }

    //}
