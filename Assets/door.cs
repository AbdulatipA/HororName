using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
   
    // Start is called before the first frame update

    public void RotateObject90Degrees() {
        transform.Rotate(Vector3.forward, 90f);
    }


}
