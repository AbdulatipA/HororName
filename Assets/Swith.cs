using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swith : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    public float raycastDistance = 3f;
    [SerializeField] public GameObject Light;

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
                    //Light gameObject = hit.collider.GetComponent<Light>();
                    Light gameObject = FindObjectOfType<Light>();

                    if (gameObject != null)
                    {
                        //Light.SetActive(false);
                        //gameObject.SetActiveFalse();
                        //Light.SetActive(!Light.activeSelf);
                        //gameObject.SetActiveFalse();
                        if (gameObject.value)
                        {
                            gameObject.SetActiveFalse();
                        }
                        else {
                            gameObject.SetActiveTrue();
                        }
                    }
                }
            }
        }
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Switch : MonoBehaviour
//{
//    [SerializeField] public Camera mainCamera;
//    public float raycastDistance = 3f;
//    [SerializeField] public GameObject lightObject;

//    void Start()
//    {
//        mainCamera = Camera.main;
//    }

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0)) // ЛКМ для включения/выключения света
//        {
//            RaycastHit hit;
//            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

//            if (Physics.Raycast(ray, out hit, raycastDistance))
//            {
//                if (hit.collider.CompareTag("Swith"))
//                {
//                    if (lightObject != null)
//                    {
//                        lightObject.SetActive(!lightObject.activeSelf);
//                    }
//                }
//            }
//        }
//    }
//}