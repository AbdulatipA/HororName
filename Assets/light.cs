using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetActiveFalse() {
        gameObject.SetActive(false);
    }
    public void SetActiveTrue()
    {
        gameObject.SetActive(true);
    }
}
