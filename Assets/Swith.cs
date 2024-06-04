using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swith : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    public float raycastDistance = 3f;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, raycastDistance))
            {
                if (hit.collider.CompareTag("Swith"))
                {
                    Light gameObject = hit.collider.GetComponent<Light>();

                    if (gameObject != null)
                    {
                        gameObject.SetActiveFalse();
                    } 
                    //else
                    //{
                    //    gameObject.SetActiveTrue();
                    //}
                }
            }
        }
    }
}

