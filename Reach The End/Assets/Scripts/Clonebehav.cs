using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonebehav : MonoBehaviour
{
 
    //public GameObject altin;
    Playerr player;
   // public GameObject temas_kutusu;
   // public SimpleCollectibleScript miknatisicin;
    //float  mesafe;
   // public Rigidbody rb;
   // Vector3 playerDirection;
    //public GameObject araba1;
   // public GameObject robot1prop;
    //private Score scoremanager;
    //public GameObject teker;
    //public AudioClip coinsound;
        void Start()
    {
       // rb=GetComponent<Rigidbody>();
        //  scoremanager = FindObjectOfType<Score>();
        //player = GameObject.Find("FPSController").GetComponent<Playerr>();
       // temas_kutusu = GameObject.Find("FPSController/FirstPersonCharacter").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (miknatisicin.gameObject.GetComponent<SimpleCollectibleScript>().miknatis_alindi==true)
     //   {
      //      playerDirection = -(transform.position - temas_kutusu.transform.position).normalized;
      //      mesafe = Vector3.Distance(transform.position,temas_kutusu.transform.position);

           
                //transform.position = Vector3.MoveTowards(transform.position,temas_kutusu.transform.position,Time.deltaTime*10.0f);
       //         rb.velocity = new Vector3(playerDirection.x,playerDirection.z)*(Time.deltaTime * 10.0f);
            
       // }
       
       //altin.transform.Rotate(0, 0, Time.deltaTime * 100);
       // teker.transform.Rotate(Time.deltaTime * 100, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
       // player = other.gameObject;
        //if (player.gameObject.tag == "Player")
        //{
         //   AudioSource.PlayClipAtPoint(coinsound, transform.position);
          //  Destroy(altin.gameObject);
           // scoremanager.ScoreCount += 10;

        //}






    }



}
