using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class boga : MonoBehaviour
{
    public float health;
    public float maxhealth;
    public GameObject healthbarUi;
    public Slider sliderr;
    private Score scoremanager;
    
    public Transform player;
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
        if (health <= 0f)
        {
            Die();
        }
      
       


    }
    void Die()
    {
        Destroy(gameObject);
        scoremanager.ScoreCount += 10;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 10 * Time.deltaTime);
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
