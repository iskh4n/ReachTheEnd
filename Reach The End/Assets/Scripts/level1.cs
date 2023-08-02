using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1 : MonoBehaviour
{
    private Score scoremanager;
    float deltime = 6.0f;
    float sagX = 5.06f;
    float solX = -17.18f;
    public Transform playerZ;
    public GameObject boga;
    public GameObject robot1;
    public GameObject heal;

    public Transform dogmanoktasi1;
    public Transform dogmanoktasi2;
    public Transform dogmanoktasi3;
    public Transform dogmanoktasi4;

    void Start()
    {
        InvokeRepeating("ndoClone", 0, 1f);
        InvokeRepeating("doHeal", 0, 1f);
    }
    void Update()
    {
    }
    void ndoClone()
    {
                int Nrandomsayi = Random.Range(0, 100);
                if (Nrandomsayi > 0 && Nrandomsayi < 50)
                {
                    ndoingClone(boga, 0f);
                }
              
                //if (randomsayi > 75 && randomsayi < 85)
                //{
                // doingClone(araba1, 0f);
                //}
    }
    void ndoingClone(GameObject Nnesne, float Y_coordinate)
    {
        float randomsayii = Random.Range(sagX, solX);
        GameObject nnewclone = Instantiate(Nnesne);
        int Nrandomsayi = Random.Range(0, 100);
        if (Nrandomsayi < 50)
        {
            nnewclone.transform.position = new Vector3(sagX, Y_coordinate, playerZ.position.z + 50.0f);
        }
        else if (Nrandomsayi > 50)
        {
            nnewclone.transform.position = new Vector3(solX, Y_coordinate, playerZ.position.z + 50.0f);
        }
        Destroy(nnewclone, deltime+2);
    }


    void doHeal()
    {
        int randomsayi = Random.Range(0, 100);
        if (randomsayi > 0 && randomsayi < 50)
        {
            doingHeal(heal, 0f);
        }

        //if (randomsayi > 75 && randomsayi < 85)
        //{
        // doingClone(araba1, 0f);
        //}
    }





    void doingHeal(GameObject heal, float Y_coordinate)
    {
        float randomsayii = Random.Range(sagX, solX);
        GameObject newHeal = Instantiate(heal);
        int randomsayi = Random.Range(0, 100);
        if (randomsayi > 0 && randomsayi <25)
        {
            newHeal.transform.position = dogmanoktasi1.transform.position;
        }
        else if (randomsayi > 25 && randomsayi < 50)
        {
            newHeal.transform.position = dogmanoktasi2.transform.position;

        }
        else if (randomsayi >50 && randomsayi < 75)
        {
            newHeal.transform.position = dogmanoktasi3.transform.position;
        }
        else if (randomsayi > 75 && randomsayi < 100)
        {
            newHeal.transform.position = dogmanoktasi4.transform.position;

        }
        Destroy(newHeal, deltime);
    }








}
