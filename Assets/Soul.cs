using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soul : MonoBehaviour
{
    public Sprite[] soulSprites;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = soulSprites[Random.Range(0, soulSprites.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
