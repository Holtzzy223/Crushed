using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeepleManager : MonoBehaviour
{
    public int maxPeeple = 10;
    public int peepleCount = 0;
    public GameObject peeplePre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if mouse button clicked
        if (Input.GetMouseButtonDown(0))
        {
            AddPeeple();
        }
        
    }
    void AddPeeple()
    {
        if (peepleCount < maxPeeple)
        {
             //create a new peeple
            GameObject newPeeple = Instantiate(peeplePre);
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            //set new peeple position
            newPeeple.transform.position = worldPos;
            peepleCount++;
        }
    }

    public void RemovePeeple()
    {
        peepleCount--;
    }
}
