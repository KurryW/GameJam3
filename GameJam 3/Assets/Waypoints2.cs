using System.Collections.Generic;
//using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Waypoints2 : MonoBehaviour
{
    //public Waypoints3 waypoints3Script;

    public List<GameObject> waypoints3;
    public float speed;
    int index = 0;

    private Animator anim;

    public Transform target3;

    private bool PLayerHasArrivedBy2;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }


    // Update is called once per frame
    public void Update()
    {

        anim.SetBool("Walk", true);
        Vector3 destination3 = waypoints3[index].transform.position;
        Vector3 newPos3 = Vector3.MoveTowards(transform.position, destination3, speed = Time.deltaTime);
        transform.position = newPos3;
        transform.LookAt(target3);

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

            if (index == 4)
            {
            //    Text3.SetActive(false);
                  anim.SetBool("Walk", false);
            }

            if (index >= waypoints3.Count)
            {
                //waypoints3Script.Update();
            }
        }
       
    }





    
}



