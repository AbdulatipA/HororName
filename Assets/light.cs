using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    //public Light light; 
    public bool value = true;

    //public void Start() {
    //    value = gameObject.activeSelf;
    //    //light = GetComponent<Light>();
    //}
    public void SetActiveFalse()
    {
        value = false;
        //gameObject.SetActive(value);
        GetComponent<Light>().enabled = true;
    }

    public void SetActiveTrue()
    {
        value = true;
        //gameObject.SetActive(value);
        GetComponent<Light>().enabled = false;
    }
}





//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Light : MonoBehaviour
//{
//    private bool isLightOn;

//    void Start()
//    {
//        isLightOn = gameObject.activeSelf;
//    }

//    public void ToggleLight()
//    {
//        isLightOn = !isLightOn;
//        gameObject.SetActive(isLightOn);
//    }

//    public void SetActiveFalse()
//    {
//        gameObject.SetActive(false);
//        isLightOn = false;
//    }

//    public void SetActiveTrue()
//    {
//        gameObject.SetActive(true);
//        isLightOn = true;
//    }
//}