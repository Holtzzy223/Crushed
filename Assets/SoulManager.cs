using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulManager : MonoBehaviour
{
    public static SoulManager instance;
    [SerializeField] private int soulsToAdd;
    [SerializeField] private int waitTime;
    private int soulCount = 30;
    private int maxSoulCount = 100;
    public int SoulCount { get { return soulCount; } set { soulCount = value; } }
    public int MaxSoulCount { get { return maxSoulCount; } set { soulCount = value; } }      
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddSoulOverTime(soulsToAdd,waitTime));
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Current Souls: " +soulCount);
    }
    //add souls
    public void AddSoul(int amount)
    {
        SoulCount += amount;
        if (soulCount > maxSoulCount)
        {
            soulCount = maxSoulCount;
        }
    }
    //remove souls
    public void RemoveSoul(int amount)
    {
        SoulCount -= amount;
        if (soulCount < 0)
        {
            soulCount = 0;
        }
    }
    //coroutine to add souls over time
    public IEnumerator AddSoulOverTime(int amount, float waitTime)
    {
        while (true)
        {
            
            Debug.Log("adding souls in "+waitTime+" seconds...");
            yield return new WaitForSeconds(waitTime);
            AddSoul(amount);
            Debug.Log("Souls Added..");
            Debug.Log("Current Souls: "+soulCount);
        }
    }

}
