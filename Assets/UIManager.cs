using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{ 
    public TextMeshProUGUI soulText;
    public TextMeshProUGUI scoreText;
    public GameObject peepleTut;
    public GameObject peepleTut2;
    public GameObject bigBoyTut;
    public GameObject townTut;
    public GameObject townTut2;
    public GameObject boulderTut;
    public GameObject boulderTut2;
    //Gameover
    public GameObject gameOver;
    
    public TextMeshProUGUI gameOverScore;
    public TextMeshProUGUI gameOverHighScore;

    //singleton
    public static UIManager instance;
    
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
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = GameManager.instance.gameScore.ToString();
    }

    public void UpdateSouls() 
    {
        soulText.text = SoulManager.instance.SoulCount.ToString();
    }
    //enable peeple tutorial
    // Town>>Peeple>>Boulder
    public void EnablePeepleTut()
    {
        peepleTut.SetActive(true);
    }
    
    public void DisablePeepleTut()
    {
        peepleTut.SetActive(false);
    }
    public void EnablePeepleTut2()
    {
        peepleTut2.SetActive(true);
    }
    //disable peepletut2
    public void DisablePeepleTut2()
    {
        peepleTut2.SetActive(false);
    }


    public void EnableBigBoyTut()
    {
        bigBoyTut.SetActive(true);
    }
 
    public void DisableBigBoyTut()
    {
        bigBoyTut.SetActive(false);
    }
    public void NextPeepleTut()
    {

            DisablePeepleTut();
            EnablePeepleTut2();

    }
    public void NextBigTut()
    {
        DisablePeepleTut2();
        EnableBigBoyTut();
    }
    public void EndPeepleTut()
    {
        GameManager.instance.ResetTimeScale();
        DisableBigBoyTut();
        StartCoroutine(CameraManager.instance.TargetBoulder());
    }

    public void EnableBoulderTut()
    {
        boulderTut.SetActive(true);
    }
    public void DisableBoulderTut()
    {
        boulderTut.SetActive(false);
    }
    public void EnableBoulderTut2()
    {
        boulderTut2.SetActive(true);
    }
    
    public void DisableBoulderTut2()
    {
        boulderTut2.SetActive(false);
    }
    public void NextBoulderTut()
    {
        DisableBoulderTut();
        EnableBoulderTut2();
    }
    public void EndBoulderTut()
    {
        GameManager.instance.ResetTimeScale();
        DisableBoulderTut2();
        //finish tut
        PlayerPrefs.SetInt("FirstTime", 1);        
        FindObjectOfType<Boulder>().StartBoulder();
        GameManager.instance.StartCoroutine(GameManager.instance.AddScoreOverTime(10,1));
    }
    public void EnableTownTut()
    {
        townTut.SetActive(true);
    }
    public void DisableTownTut()
    {
        townTut.SetActive(false);
    }
    public void EnableTownTut2()
    {
        townTut2.SetActive(true);
    }
    public void DisableTownTut2()
    {
        townTut2.SetActive(false);
    }
    public void NextTownTut()
    {
        DisableTownTut();
        EnableTownTut2();
    }
    public void EndTownTut()
    {
        DisableTownTut2();
        EnablePeepleTut();
    }

    //enable gameover
    public void EnableGameOver()
    {
        gameOver.SetActive(true);
    }
    public void InitGameOver()
    {
        EnableGameOver();
        gameOverScore.text = GameManager.instance.gameScore.ToString();
        gameOverHighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void RestartGame() 
    {
        HoltzzyHelper.Helpers.ReloadScene();
    }
}
