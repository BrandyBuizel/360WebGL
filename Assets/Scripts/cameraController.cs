using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
    private float x;
    private float y;
    private Vector3 rotateValue;
 
    void Update()
    {
        if(Input.GetMouseButton(0)){
            Screen.lockCursor = true;

            y = Input.GetAxis("Mouse X");
            x = Input.GetAxis("Mouse Y");

            Debug.Log(x + ":" + y);
            rotateValue = new Vector3(x, y * -1, 0);
            transform.eulerAngles = transform.eulerAngles - rotateValue;
        }else{
            Screen.lockCursor = false;
        }
    }
}
