using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peeple : MonoBehaviour
{
    [SerializeField] private float killTimer = 0;
    [SerializeField] private float killTimerMax = 2;
    [SerializeField] private float speed = 0;
    [SerializeField] private float speedMax = 0;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private SpriteRenderer myRenderer;
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
            myRenderer.sprite = sprites[1];
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boulder"))
        {
            killTimer += Time.deltaTime;

            if (killTimer >= killTimerMax - (FindObjectOfType<Boulder>().GetMass()*.01f))
            {
                StartCoroutine(Scream());
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boulder"))
        {
            killTimer = 0;
            myRenderer.sprite = sprites[0];
        }
    }

    private void KillPeeple()
    {
        if (tag == "peeple")
        {
            SoulManager.instance.AddSoul(1);
        }
        else 
        {
            SoulManager.instance.AddSoul(3);
        }
        FindObjectOfType<PeepleManager>().RemovePeeple();
        FindObjectOfType<Boulder>().Grow();
        Destroy(gameObject);
    }
    private IEnumerator Scream() 
    {
        myRenderer.sprite = sprites[2];
        yield return new WaitForSeconds(0.35f);
        KillPeeple();
    }
}
