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
        if (transform.localScale.x >= 1.35f && transform.localScale.x <= 2f)
        {
            FindObjectOfType<CameraManager>().ZoomVirtualCam(1 + transform.localScale.x / 2);
        } else if (transform.localScale.x >= 2 && transform.localScale.x <= 3f)
        {
            FindObjectOfType<CameraManager>().ZoomVirtualCam(1 + transform.localScale.x / 2);
        } else if (transform.localScale.x>=3 && transform.localScale.x <= 4f) 
        {
            FindObjectOfType<CameraManager>().ZoomVirtualCam(1 + transform.localScale.x / 2);
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
