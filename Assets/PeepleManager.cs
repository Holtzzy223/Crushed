using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeepleManager : MonoBehaviour
{
    [SerializeField]private int maxPeeple = 10;
    [SerializeField]private int peepleCount = 0;
    [SerializeField]private GameObject peeplePre;
    [SerializeField]private GameObject bigBoyPre;
    [SerializeField]private int peepleCost = 2;
    [SerializeField]private int bigBoyCost = 5;
    

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
            if (SoulManager.instance.SoulCount >= peepleCost)
            {
                AddPeeple(peeplePre, peepleCost);
            }
        }
        //check right mouse
        if (Input.GetMouseButtonDown(1))
        {
            if (SoulManager.instance.SoulCount >= bigBoyCost)
            {
                AddPeeple(bigBoyPre, bigBoyCost);
            }
        }

    }
    void AddPeeple(GameObject prefab,int cost)
    {
        if (peepleCount < maxPeeple)
        {
             //create a new peeple
            GameObject newPeeple = Instantiate(prefab);
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            //set new peeple position
            newPeeple.transform.position = worldPos;
            peepleCount++;
            SoulManager.instance.RemoveSoul(cost);
        }
    }

    public void RemovePeeple()
    {
        peepleCount--;
    }
}
