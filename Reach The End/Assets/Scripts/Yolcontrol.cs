using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yolcontrol : MonoBehaviour
{
    
    public GameObject adam;
    public GameObject ev1;
    public GameObject ev2;
    public bool var;
    public bool yok;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private  void OnTriggerExit(Collider adam)
    {
        if (adam.gameObject.CompareTag("Player"))
        {
            
                ev1.SetActive(var);
                ev2.SetActive(yok);
           
            transform.position += new Vector3(0, 0, transform.GetChild(0).GetComponent<Renderer>().bounds.size.z * 2);
        }
    }
}
