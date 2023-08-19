using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float zoomSpeed = 1f; // Speed Zoom

    void Update()
    {
        
        float zoomInput = Input.GetAxis("Mouse ScrollWheel");
        
        Camera mainCamera = Camera.main;
        
        float newOrthographicSize = mainCamera.orthographicSize - (zoomInput * zoomSpeed);
        
        newOrthographicSize = Mathf.Clamp(newOrthographicSize, 1f, 10f);
        
        mainCamera.orthographicSize = newOrthographicSize;
    }
}
