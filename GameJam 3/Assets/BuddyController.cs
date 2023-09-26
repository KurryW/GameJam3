using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BuddyController : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            anim.SetInteger("Animatie1", 1);

        }
        
    }
}
