using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player3rdPersonCamera;
    public GameObject followCamera;
    public GameObject lookAtCamera;

    private int currentObjectIndex = 0;

    void Start()
    {
        player3rdPersonCamera.SetActive(true);
        followCamera.SetActive(false);
        lookAtCamera.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentObjectIndex++;

            if (currentObjectIndex > 2)
            {
                currentObjectIndex = 0;
            }

            if (currentObjectIndex == 0)
            {
                player3rdPersonCamera.SetActive(true);
                followCamera.SetActive(false);
                lookAtCamera.SetActive(false);
            }
            else if (currentObjectIndex == 1)
            {
                player3rdPersonCamera.SetActive(false);
                followCamera.SetActive(true);
                lookAtCamera.SetActive(false);
            }
            else if (currentObjectIndex == 2)
            {
                player3rdPersonCamera.SetActive(false);
                followCamera.SetActive(false);
                lookAtCamera.SetActive(true);
            }
        }
    }
}
