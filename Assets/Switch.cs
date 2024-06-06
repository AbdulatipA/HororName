using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    [SerializeField] public GameObject Light;
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
                if (hit.collider.CompareTag("Switch"))
                {
                    Light gameObject = hit.collider.GetComponent<Light>();
                    //Light gameObject = FindObjectOfType<Light>();

                    if (Light != null)
                    {
                        //Light.SetActive(false);
                        //gameObject.SetActiveFalse();
                        Light.SetActive(!Light.activeSelf);
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

//using System;
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
//                if (hit.collider.CompareTag("Switch"))
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