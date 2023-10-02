using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWalk : MonoBehaviour
{
    public GameObject Text1;
    public Waypoints waypoints;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //waypoints.FirstWalk();
            Text1.SetActive(false);

            //anim.SetBool("Walk", true);

        }
    }
}
