using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Text1.SetActive(false);
            Text2.SetActive(true);

            WaitForSeconds(10f);
            Text2.SetActive(false);
            Text3.SetActive(true);

        }
    }

    

}
