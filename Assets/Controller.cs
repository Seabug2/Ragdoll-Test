using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localPosition = Vector3.forward * 2 + Vector3.left * .1f;
            return;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localPosition = Vector3.forward * 2 + Vector3.right * .1f;
            return;
        }
        else if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition = Vector3.forward * 2;
            return;
        }
    }
}
