using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    //public Waypoints1 waypoints1Script;
    public GameObject Buddy;

    public List<GameObject> waypoints;
    //public List<GameObject> waypoints2;
    //public List<GameObject> waypoints3;
    public float speed;
    int index = 0;

    private Animator anim;

    public Transform target1;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject PressSpacebarText;

    private bool PLayerHasEntered;

    //private bool PLayerHasArrivedBy1;
    //private bool PLayerHasArrivedBy2;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        Buddy.GetComponent<Waypoints1>().enabled = false;
        Buddy.GetComponent<Waypoints2>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PLayerHasEntered = true;
            Text1.SetActive(false);

            //anim.SetBool("Walk", true);
            GetComponent<BoxCollider>().enabled = false;

        }
    }

    // Update is called once per frame
    void Update()
    {

        if (PLayerHasEntered)
        {

            Debug.Log("firstWalk is aan de beurt");
            anim.SetBool("Walk", true);
            Vector3 destination = waypoints[index].transform.position;
            Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed);
            transform.position = newPos;
            transform.LookAt(target1);

            float distance = Vector3.Distance(transform.position, destination);
            if (distance <= 0.05)
            {
                index++;
                Debug.Log("ik ga lopen naar 1");

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
                    anim.SetBool("Walk", false);

                }

                if (index >= waypoints.Count)
                {

                    Invoke(nameof(Update), 150f);
                    Debug.Log("ffe wachten 10 sec");
                    Buddy.GetComponent<Waypoints1>().enabled = true;
                    Debug.Log("script is off");
                }

            }


        }
    }
}


//    private void SecondWalk()
//    {

//        anim.SetBool("Walk", true);
//        Vector3 destination2 = waypoints2[index].transform.position;
//        Vector3 newPos2 = Vector3.MoveTowards(transform.position, destination2, speed = Time.deltaTime);
//        transform.position = newPos2;
//        transform.LookAt(target2);

//        float distance2 = Vector3.Distance(transform.position, destination2);
//        if (distance2 <= 0.05)
//        {
//            index++;


//            if (index == 1)
//            {
//                Text2.SetActive(true);
//                PressSpacebarText.SetActive(true);
//            }

//            if (index == 2)
//            {
//                Text2.SetActive(false);
//                PressSpacebarText.SetActive(false);
//                Text3.SetActive(true);
//            }

//            if (index == 3)
//            {
//                Text3.SetActive(true);
//            }

//            if (index == 4)
//            {
//                anim.SetBool("Walk", false);
//                Text3.SetActive(false);
//            }

//            if (index >= waypoints2.Count)
//            {

//                Invoke(nameof(ThirdWalk), 100f);
//            }
//        }



//    }

//    private void ThirdWalk()
//    {


//        anim.SetBool("Walk", true);
//        Vector3 destination3 = waypoints3[index].transform.position;
//        Vector3 newPos3 = Vector3.MoveTowards(transform.position, destination3, speed = Time.deltaTime);
//        transform.position = newPos3;
//        transform.LookAt(target3);

//        float distance3 = Vector3.Distance(transform.position, destination3);
//        if (distance3 <= 0.05)
//        {
//            index++;


//            if (index == 1)
//            {
//                Text2.SetActive(true);
//                PressSpacebarText.SetActive(true);
//            }

//            if (index == 2)
//            {
//                Text2.SetActive(false);
//                PressSpacebarText.SetActive(false);
//                Text3.SetActive(true);
//            }

//            if (index == 3)
//            {
//                Text3.SetActive(true);
//            }

//            if (index == 4)
//            {
//                Text3.SetActive(false);
//                anim.SetBool("Walk", false);
//            }

//            if (index >= waypoints3.Count)
//            {

//            }
//        }



//    }
//}



