using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //public float speed;

    //public float lifeTime;

    public int damageToGive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //if (lifeTime <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("sla de enemy");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("ik sla de enemy");
                other.gameObject.GetComponent<EnemyHealth>().HurtEnemy(damageToGive);

            }
        }
    }
}
