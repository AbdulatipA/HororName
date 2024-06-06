//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Light : MonoBehaviour
//{

//    public bool value;

//public void start()
//{
//    value = gameObject.activeSelf;
//    //mylight = getcomponent<light>();
//}



//    public void SetActiveFalse()
//    {
//        value = false;
//        ////gameObject.SetActive(value);
//        //GetComponent<Light>().enabled = false;
//        gameObject.SetActive(false);
//    }

//    public void SetActiveTrue()
//    {
//        value = true;
//        gameObject.SetActive(true);
//    }
//}










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