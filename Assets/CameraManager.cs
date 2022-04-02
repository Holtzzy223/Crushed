using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class CameraManager : MonoBehaviour
{
    public Camera regularCam;
    public CinemachineVirtualCamera vCam;
    // Start is called before the first frame update
    void Start()
    {
        vCam.m_Lens.OrthographicSize = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ZoomVirtualCam(float zoomSize)
    {
        vCam.m_Lens.OrthographicSize = Mathf.Lerp(vCam.m_Lens.OrthographicSize,zoomSize, Time.deltaTime * 2);
    }

}
