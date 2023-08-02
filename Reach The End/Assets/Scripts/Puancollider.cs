using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puancollider : MonoBehaviour
{
    
    private Score scoremanager;
    public GameObject adam;
    // Start is called before the first frame update
    void Start()
    {
        scoremanager = FindObjectOfType<Score>();
        

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider adam)
    {
        if (adam.gameObject.CompareTag("Player"))
        {
            scoremanager.ScoreCount += 5;
           transform.position += new Vector3(0, 0, transform.forward.z+15);
        }
     

    }



}
