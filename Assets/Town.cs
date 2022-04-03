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
        transform.DOScale(new Vector3(2f * Mathf.Sin(transform.localScale.x), 2f * Mathf.Sin(transform.localScale.y)), 1f);

    }
    //check trigger for boulder
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Boulder"))
        {
        Helpers.ReloadScene(); 
        }
    }
}
