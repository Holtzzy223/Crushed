using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeepleManager : MonoBehaviour
{
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
        //create a new peeple
        GameObject newPeeple = Instantiate(peeplePre);
        //get mouse position
        Vector3 mousePos = Input.mousePosition;
        //convert mouse position to world position
        mousePos.z = 10;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        //set new peeple position
        newPeeple.transform.position = worldPos;
    }
}
