using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{

    public List<GameObject> waypoints;
    public List<GameObject> waypoints2;
    public List<GameObject> waypoints3;
    public float speed;
    int index = 0;

    private Animator anim;

    public Transform target1;
    public Transform target2;
    public Transform target3;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject PressSpacebarText;

    private bool PLayerHasEntered;
    private bool PLayerHasArrivedBy1;
    private bool PLayerHasArrivedBy2;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PLayerHasEntered = true;
            Text1.SetActive(false);
            
            anim.SetBool("Walk", true);

        }

        if (other.tag == "Buddy")
        {
            PLayerHasArrivedBy1 = true;

        }
    }

    // Update is called once per frame
    void Update()
    {

        if (PLayerHasEntered)
        {
            Vector3 destination = waypoints[index].transform.position;
            Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed = Time.deltaTime);
            transform.position = newPos;
            transform.LookAt(target1);

            float distance = Vector3.Distance(transform.position, destination);
            if (distance <= 0.05)
            {
                index++;


                if (index == 1)
                {
                    Text2.SetActive(true);
                    PressSpacebarText.SetActive(true);
                }

                if (index == 2)
                {
                    Text2.SetActive(false);
                    PressSpacebarText.SetActive(false);
                    Text3.SetActive(true);
                }

                if (index == 3)
                {
                    Text3.SetActive(false);
                }

                if (index == 4)
                {
                    
                }

                if (index >= waypoints.Count)
                {
                    PLayerHasEntered = false;
                    anim.SetBool("Walk", false);
                    Invoke(nameof(SecondWalk), 600f);
                }

            }

        }
    }

    private void SecondWalk()
    {

        if (PLayerHasArrivedBy1)
        {

            Vector3 destination2 = waypoints[index].transform.position;
            Vector3 newPos2 = Vector3.MoveTowards(transform.position, destination2, speed = Time.deltaTime);
            transform.position = newPos2;
            transform.LookAt(target1);

            float distance2 = Vector3.Distance(transform.position, destination2);
            if (distance2 <= 0.05)
            {
                index++;


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
                //    Text3.SetActive(true);
                //}

                //if (index == 4)
                //{
                //    Text3.SetActive(false);
                //}

                if (index >= waypoints.Count)
                {
                    PLayerHasArrivedBy1 = false;
                    anim.SetBool("Walk", false);
                    Invoke(nameof(ThirdWalk), 600f);
                }
            }
        }


    }

    private void ThirdWalk()
    {

        if (PLayerHasArrivedBy2)
        {

            Vector3 destination3 = waypoints[index].transform.position;
            Vector3 newPos3 = Vector3.MoveTowards(transform.position, destination3, speed = Time.deltaTime);
            transform.position = newPos3;
            transform.LookAt(target1);

            float distance3 = Vector3.Distance(transform.position, destination3);
            if (distance3 <= 0.05)
            {
                index++;


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
                //    Text3.SetActive(true);
                //}

                //if (index == 4)
                //{
                //    Text3.SetActive(false);
                //}

                if (index >= waypoints.Count)
                {
                    PLayerHasArrivedBy2 = false;
                    anim.SetBool("Walk", false);
                }
            }
        }


    }
}


