using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class UIManager : MonoBehaviour
{ 
    public TextMeshProUGUI soulText;
    public GameObject peepleTut;
    public GameObject bigBoyTut;
    public static UIManager instance;
    
    //singleton
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
    //enable peeple tutorial
    public void EnablePeepleTut()
    {
        peepleTut.SetActive(true);
    }
    
    public void DisablePeepleTut()
    {
        peepleTut.SetActive(false);
    }
   
    public void EnableBigBoyTut()
    {
        bigBoyTut.SetActive(true);
    }
 
    public void DisableBigBoyTut()
    {
        bigBoyTut.SetActive(false);
    }
    public void NextTut() 
    {
        DisablePeepleTut();
        EnableBigBoyTut();
    }
    public void EndPeepleTut()
    {
        GameManager.instance.ResetTimeScale();
        DisableBigBoyTut();
        StartCoroutine(CameraManager.instance.TargetBoulder());
    }

}
