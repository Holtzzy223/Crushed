using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

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
        if (transform.localScale.x > 1.5f)
        {
            FindObjectOfType<CameraManager>().ZoomVirtualCam(1 + transform.localScale.x / 10f);
        }
    }
    public void Grow() 
    {
        //do scale
        transform.DOScale(transform.localScale*scaleMod, growTime);
        //scale rigidbody mass
        rb.mass = rb.mass * scaleMod;

    }

    

    public float GetMass()
    {
        return rb.mass;

    }
}
