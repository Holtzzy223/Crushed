using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Boulder : MonoBehaviour
{
    public float scaleMod;
    public float growTime;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Grow() 
    {
        //do scale
        transform.DOScale(scaleMod, growTime);
        //scale rigidbody mass
        rb.mass = rb.mass * scaleMod;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("peeple"))
            Grow();
    }
}
