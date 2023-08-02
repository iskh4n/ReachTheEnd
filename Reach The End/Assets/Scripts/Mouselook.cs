using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mouselook : MonoBehaviour
{

    public static float mouseSens=130.0f;
    public Transform playerbody;
    float xrotation = 0f;
    ValueChange valuechange;
    // public Slider SenSlider;
    

    void Start()
    {
        //mouseSens =Mathf.RoundToInt(ValueChange.sensivity)+mouseSens;
        Cursor.lockState = CursorLockMode.Locked;

       
        mouseSens = ValueChange.sensivity;
    }
   

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") *mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        xrotation -= mouseY;
        xrotation = Mathf.Clamp(xrotation,-90f,90f);
        transform.localRotation = Quaternion.Euler(xrotation,0f,0f);
        playerbody.Rotate(Vector3.up*mouseX);

    }
}
