using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;
using System;

public class CameraManager : MonoBehaviour
{
    public Camera regularCam;
    public CinemachineVirtualCamera vCam;
    public GameObject townTarget;
    public GameObject boulderTarget;
    //singleton
    public static CameraManager instance;
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
        vCam.m_Lens.OrthographicSize = 1f;
    }
    void Start()
    {
       
        StartCoroutine(TargetTown(1f));
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void ZoomVirtualCam(float zoomSize)
    {
        vCam.m_Lens.OrthographicSize = Mathf.Lerp(vCam.m_Lens.OrthographicSize,zoomSize, Time.deltaTime);
    }
    private IEnumerator TargetTown(float wait)
    {
        if (vCam.Follow == null)
        {
            vCam.Follow = townTarget.transform;
            vCam.LookAt = townTarget.transform;
        }
        while (vCam.m_Lens.OrthographicSize < 2.2f)
        {
            ZoomVirtualCam(2.3f);
            yield return new WaitForEndOfFrame();
        }

        //pause
        GameManager.instance.PauseGame();
        UIManager.instance.EnableTownTut();
    }
   
    public IEnumerator TargetBoulder()
    {
        vCam.Follow = null;
        vCam.LookAt = null;
        vCam.transform.DOMove(new Vector3(boulderTarget.transform.position.x, boulderTarget.transform.position.y, -10), 10f);
        yield return new WaitForSeconds(10f);
        vCam.Follow = boulderTarget.transform;
        vCam.LookAt = boulderTarget.transform;
        yield return new WaitForSeconds(1f);
        while (vCam.m_Lens.OrthographicSize > 1f)
        {
            ZoomVirtualCam(0.99f);
            yield return new WaitForEndOfFrame();
        }
        GameManager.instance.PauseGame();
        UIManager.instance.EnableBoulderTut();
    }
}
