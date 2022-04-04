using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using HoltzzyHelper;
public class Town : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
    }
    //check trigger for boulder
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Boulder"))
        {
            GameManager.instance.PauseGame();
        }
    }
}
