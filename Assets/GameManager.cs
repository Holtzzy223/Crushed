using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Game State enum
    public enum GameState
    {
        Menu,
        Playing,
        Paused,
        GameOver
    }
    public GameState state;
    public AudioClip music;
    public AudioSource musicSource;
    public static GameManager instance;
    public int gameScore =0;
    public int highScore;

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
        ResetTimeScale();
        //play music
        musicSource.clip = music;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //pause game
    public void PauseGame()
    {
        Time.timeScale = 0;
        state = GameState.Paused;
    }

    //unpause game
    public void ResetTimeScale()
    {
        Time.timeScale = 1;
        state = GameState.Playing;
    }
    //slowmotion
    public void SlowMotion()
    {
        Time.timeScale = 0.5f;
    }

    public IEnumerator AddScoreOverTime(int amount, float waitTime)
    {
        while (true)
        {

            Debug.Log("adding souls in " + waitTime + " seconds...");
            yield return new WaitForSeconds(waitTime);
            AddScore(amount);

        }
    }

    private void AddScore(int amount)
    {
        gameScore += amount;
    }
    //check fro escape press
    public void CheckForEscapePress()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (state == GameState.Paused)
            {
                ResetTimeScale();
            }
            else
            {
                PauseGame();
            }
        }
    }
}
