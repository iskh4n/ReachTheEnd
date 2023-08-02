using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValueChangeText : MonoBehaviour
{
    public Text PerText;
    void Start()
    {
        PerText = GetComponent<Text>();
    }

    public void TextUpdate(float value)
     {

    PerText.text =" "+ Mathf.RoundToInt(value);
    }
}
