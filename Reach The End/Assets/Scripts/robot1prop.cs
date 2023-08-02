using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class robot1prop : MonoBehaviour
{

    public float health=50f;
    public float maxhealth=50f;
    public Transform prob1;
    public GameObject healthbarUi;
    public Slider sliderr;
    private Score scoremanager;
    // Start is called before the first frame update
    void Start()
    {

        health = maxhealth;
        sliderr.value = calcH();
        scoremanager = FindObjectOfType<Score>();
    }

    public void TakeDamagee(float amount)
    {
        health -= amount;
        if (health<=0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 500, 0);
        
        prob1.transform.Translate(0, 0, 15 * Time.deltaTime);


        sliderr.value = calcH();
        if (health < maxhealth)
        {
            healthbarUi.SetActive(true);

        }
        else if (health > maxhealth)
        {
            health = maxhealth;
        }



    }



    float calcH()
    {
        return health / maxhealth;
    }



}
