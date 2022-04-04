using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
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
    void Update()
    {
        
    }

    //pause game
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    //unpause game
    public void ResetTimeScale()
    {
        Time.timeScale = 1;
    }
    //slowmotion
    public void SlowMotion()
    {
        Time.timeScale = 0.5f;
    }
    
}
