using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 300f;
    public float impactForce = 30f;
    public Camera FPScam;
    public ParticleSystem atesEfekt;
    public GameObject vurmaNoktasıEfekt;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        atesEfekt.Play();
        RaycastHit hit;
        if (Physics.Raycast(FPScam.transform.position, FPScam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            robot1prop robot = hit.transform.GetComponent<robot1prop>();
            if (robot!=null)
            {
                robot.TakeDamagee(damage);
            }
            araba1 araba = hit.transform.GetComponent<araba1>();
            if (araba != null)
            {
                araba.TakeDamagee(damage);
            }
            boga boga = hit.transform.GetComponent<boga>();
            if (boga != null)
            {
                boga.TakeDamagee(damage);
            }
            if (hit.rigidbody!=null)
            {
                hit.rigidbody.AddForce(-hit.normal*impactForce);
            }
            GameObject impact= Instantiate(vurmaNoktasıEfekt,hit.point,Quaternion.LookRotation(hit.normal));
            Destroy(impact,2f);
        }






    }
}
