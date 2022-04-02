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
    private CameraManager cm;
    // Start is called before the first frame update
    void Start()
    {
        cm = FindObjectOfType<CameraManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x >= 1.35f && transform.localScale.x <= 2)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 2 && transform.localScale.x <= 3)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 3 && transform.localScale.x <= 4)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 4 && transform.localScale.x <= 5)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 5 && transform.localScale.x <= 6)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 6 && transform.localScale.x <= 7)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 7 && transform.localScale.x <= 8)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 8 && transform.localScale.x <= 9)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 9 && transform.localScale.x <= 10)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 10 && transform.localScale.x <= 11)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 11 && transform.localScale.x <= 12)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 12 && transform.localScale.x <= 13)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 13 && transform.localScale.x <= 14)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }
        else if (transform.localScale.x >= 14 && transform.localScale.x <= 15)
        {
            cm.ZoomVirtualCam(1 + transform.localScale.x / 2);
        }


    }
    public void Grow() 
    {
        //do scale
        transform.DOScale(transform.localScale*scaleMod, growTime);
        //scale rigidbody mass
        rb.mass = rb.mass +7;
        //scale down drag
        rb.drag = rb.drag / scaleMod;

    }

    

    public float GetMass()
    {
        return rb.mass;

    }
}
