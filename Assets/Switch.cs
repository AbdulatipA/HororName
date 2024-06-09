using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    //public GameObject Light;
    [SerializeField] public Lights mainLights;
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
                //if (hit.collider.CompareTag("Switch"))
                //{
                //    Light gameObject = hit.collider.GetComponent<Light>();

                //    if (Light != null) Light.SetActive(!Light.activeSelf);
                //}



                if (hit.collider.CompareTag("Switch"))
                {
                    if (mainLights.value)
                    {
                        mainLights.SetActiveFalse();
                    }
                    else {
                        mainLights.SetActiveTrue();
                    }
                }
            }
        }
    }
}






