using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public void RotateObject90Degrees() {
        transform.Rotate(Vector3.forward, 90f);
    }
}
