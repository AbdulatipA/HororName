//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Light : MonoBehaviour
//{

//    public bool value;

//    public void start()
//    {
//        value = gameObject.activeSelf;
//        //mylight = getcomponent<light>();
//    }



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




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public bool value = true;
    public Light lightComponent;

    public void SetActiveFalse() {
        value = false;
        lightComponent.GetComponent<Light>().enabled = false;
    }

    public void SetActiveTrue()
    {
        value = true;
        lightComponent.GetComponent<Light>().enabled = true;
    }
}