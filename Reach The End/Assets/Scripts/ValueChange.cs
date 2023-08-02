using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueChange : MonoBehaviour
{
   
    public Slider sensSlider;
    public static float sensivity=130.0f;
    public Mouselook mouselook;

    void Start()
    {
     
        //PerText = GetComponentInChildren<Text>();
        sensSlider = GetComponentInChildren<Slider>();
        mouselook = GetComponent<Mouselook>();
        mouselook = FindObjectOfType<Mouselook>();

       //Mouselook.mouseSens = sensivity;
       sensSlider.value = Mouselook.mouseSens;
       
    }
    
  
    public void adjustSens(float NewSens)
    {
      sensivity =Mathf.RoundToInt(NewSens);
      //PerText.text = " " +Mathf.RoundToInt(NewSens);
    }

}
