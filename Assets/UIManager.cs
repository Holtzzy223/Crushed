using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI soulText;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void LateUpdate()
    {
        UpdateSouls();
    }

    public void UpdateSouls() 
    {
        soulText.text = SoulManager.instance.SoulCount.ToString();
    }

}
