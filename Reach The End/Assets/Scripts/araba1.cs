using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba1 : MonoBehaviour
{
    public float health = 50f;
    private Score scoremanager;
  
    // Start is called before the first frame update
    void Start()
    {
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
        transform.Translate(0, 0, 15 * Time.deltaTime);
       

    }
}
