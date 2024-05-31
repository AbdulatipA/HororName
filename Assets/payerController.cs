using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class payerController : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0)) { 
           RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, raycastDistance)) {
                if (hit.collider.CompareTag("Door")) {
                    door rotateObject = hit.collider.GetComponent<door>();
                    if (rotateObject != null) {
                        rotateObject.RotateObject90Degrees();
                    }
                }
            }
        }


        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, raycastDistance))
            {
                if (hit.collider.CompareTag("TogleLight"))
                {
                    Light light = hit.collider.GetComponent<Light>();
                    if (light != null)
                    {
                       light.gameObject.SetActive(false);
                    }
                }
            }
        }

    }
}
