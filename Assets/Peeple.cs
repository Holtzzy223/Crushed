using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peeple : MonoBehaviour
{
   [SerializeField] private float killTimer = 0;
   [SerializeField] private float killTimerMax = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //check if colliding with boulder then destroy
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boulder")
        {
            killTimer = 0;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Boulder")
        {
            killTimer += Time.deltaTime;
            if (killTimer >= killTimerMax)
            {
                KillPeeple();
            }
        }
    }

    private void KillPeeple()
    {
        FindObjectOfType<PeepleManager>().RemovePeeple();
        FindObjectOfType<Boulder>().Grow();
        Destroy(gameObject);
    }
}
