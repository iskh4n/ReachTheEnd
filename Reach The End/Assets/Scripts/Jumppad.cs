using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumppad : MonoBehaviour
{
    public GameObject player;

    Vector3 direction;

    public float jumpForce = 35f;
    // Start is called before the first frame update
     void Start()
    {
        player.GetComponent<Rigidbody>();
        player.GetComponent<CharacterController>();
    }

    // Update is called once per frame

    void Update()
        {

            direction = transform.TransformDirection(Vector3.up * jumpForce);
        }
    void OnCollisionEnter(Collision other)
    {
       
      
        if (other.gameObject.CompareTag("Player")) //applies only to objects tagged with “Player”
         {
        player = other.gameObject;
        //apply force to the Player's rigidbody to let him "jump"
        player.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
         }
    }
    
}
