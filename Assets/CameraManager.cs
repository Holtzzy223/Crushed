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
    // Start is called before the first frame update
    void Start()
    {
        vCam.m_Lens.OrthographicSize = 1;
        StartCoroutine(TargetTown(1f));
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void ZoomVirtualCam(float zoomSize)
    {
        vCam.m_Lens.OrthographicSize = Mathf.Lerp(vCam.m_Lens.OrthographicSize,zoomSize, Time.deltaTime * 2);
    }
    private IEnumerator TargetTown(float wait)
    {
        vCam.Follow = townTarget.transform;
        vCam.LookAt = townTarget.transform;
        while (vCam.m_Lens.OrthographicSize < 2f)
        {
            ZoomVirtualCam(2.2f);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(wait);
        StartCoroutine(TargetBoulder());
    }

    private IEnumerator TargetBoulder()
    {
        vCam.Follow = null;
        vCam.LookAt = null;
        vCam.transform.DOMove(new Vector3(boulderTarget.transform.position.x, boulderTarget.transform.position.y, -10), 10f);
        yield return new WaitForSeconds(10f);
        vCam.Follow = boulderTarget.transform;
        vCam.LookAt = boulderTarget.transform;
        boulderTarget.GetComponent<Boulder>().StartBoulder();
    }
}
