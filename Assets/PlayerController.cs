using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    public float raycastDistance = 3f;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, raycastDistance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    Door rotateObject = hit.collider.GetComponent<Door>();
                    if (rotateObject != null)
                    {
                        rotateObject.RotateObject90Degrees();
                    }
                }


                //if (hit.collider.CompareTag("Weapon")) для поднятие предметов
                //{
                //    Door rotateObject = hit.collider.GetComponent<Door>();
                //    if (rotateObject != null)
                //    {
                //        rotateObject.RotateObject90Degrees();
                //    }
                //}

            }

        }



        //if (Input.GetMouseButtonDown(2))
        //{
        //    RaycastHit hit;
        //    Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        //    if (Physics.Raycast(ray, out hit, raycastDistance))
        //    {
        //        if (hit.collider.CompareTag("Swith"))
        //        {
        //            Light gameObject = hit.collider.GetComponent<Light>();

        //            if (gameObject != null)
        //            {
        //                gameObject.SetActiveFalse();
        //            }
        //            //else
        //            //{
        //            //    gameObject.SetActiveTrue();
        //            //}
        //        }
        //    }
        //}

    }
}
