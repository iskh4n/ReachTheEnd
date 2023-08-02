using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour
{
    public GameObject altin;
    public GameObject robot1;
    public GameObject araba1;
    public GameObject lvl1;
    public GameObject boga;
    public GameObject miknatis;
   
    public Transform player;
    SimpleCollectibleScript collectibleMiknatis;

    

    float deltime = 6.0f;
    float sagX = -3.19f;
    float solX = -9.18f;

    private Score scoremanager;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoremanager = FindObjectOfType<Score>();
        InvokeRepeating("doClone",0,1f);
    }
    void Update()
    {
        if (count == 0 && scoremanager.ScoreCount > 300.0f)
        {
           lvl1.SetActive(true);
            count++;
        }
    }
    // Update is called once per frame
    void doClone()
    {
        int randomsayi = Random.Range(0, 100);
        if (randomsayi > 0 && randomsayi < 50)
        {
            doingClone(altin, 1.0f);
        }
        if (randomsayi > 60 && randomsayi < 75)
        {
            doingClone(robot1, 4.0f);
        }
        if (randomsayi >75 && randomsayi < 85)
        {
            doingClone(araba1, 0f);
        }
        if (randomsayi > 85 && randomsayi < 100)
        {
            //if (collectibleMiknatis.gameObject.GetComponent<SimpleCollectibleScript>().miknatis_alindi==false)
           // GameObject m = GameObject.FindGameObjectWithTag("miknatis");
          //  miknatis.GetComponent<SimpleCollectibleScript>();
           // if(SimpleCollectibleScript.miknatis_alindi==false)
            //{
                doingClone(miknatis, 1f);

           // }
        }



    }


 


    void doingClone(GameObject nesne,float Y_coordinate)
    {
        float randomsayii = Random.Range(sagX, solX);
        GameObject newclone = Instantiate(nesne);
        int randomsayi = Random.Range(0,100);
        if (randomsayi<50)
        {
            newclone.transform.position = new Vector3(randomsayii, Y_coordinate, player.position.z + 50.0f);
        }
        else if (randomsayi>50)
        {
            newclone.transform.position = new Vector3(randomsayii, Y_coordinate, player.position.z + 50.0f);

        }
        Destroy(newclone,deltime);
    }



   







}
