using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerr : MonoBehaviour
{
   
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9f;
    public float jumphei = 3f;
    public float jumpForce = 30f;
    public Transform groundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;
    public int maxHealth = 100;
    public int currentHealth;
    public Healthbar healthbar;

    public DeathMenu deathMenu;

    private Score scoremanager;
    public Animator anim;
    public bool Kollar;
    public bool KollarZiplama;
    

    private void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        scoremanager = FindObjectOfType<Score>();
        Cursor.lockState = CursorLockMode.Locked;
        anim =GetComponentInChildren<Animator>();
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, GroundDistance, groundMask);
        if(isGrounded&& velocity.y<0)
        {
            velocity.y = -2f;

        }   
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move*speed*Time.deltaTime);
        Kollar = true;
        if(Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumphei * -2f*gravity);
            Kollar = false;
            KollarZiplama = true;
            anim.SetBool("Ziplama",true);
        }
        else
        {
            KollarZiplama = false;
            anim.SetBool("Ziplama",false);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);


     



    }


  



   public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.setHealth(currentHealth);

        if (healthbar.slider.value == 0f)
        {
            OnDeath();
        }
    }

   public void TakeHeal(int heal)
    {
        currentHealth += heal;
        healthbar.setHealth(currentHealth);
        if(healthbar.slider.value==maxHealth)
        {
            currentHealth = maxHealth;
        }
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        switch (hit.gameObject.tag)
        {
            case ("Jumppad"):
                velocity.y = jumpForce;
                break;
            case ("Enemy"):
                TakeDamage(10);
                if (hit.gameObject.CompareTag("Enemy"))
               {
                    Destroy(hit.gameObject);
               }
                
                break;
            case ("Heal"):
                TakeHeal(10);
                //Destroy(GameObject.FindGameObjectsWithTag("Heal"));
                break;
            //case("miknatis"):

               // miknatis_alindi = true;

             

               // break;
          

            default:
                break;
        }

      


    }

   




    public void OnDeath()
    {
        Cursor.lockState = CursorLockMode.None;
        deathMenu.ToggleEndMenu(scoremanager.ScoreCount);
        deathMenu.gameObject.SetActive(true);
        Time.timeScale = 0;

    }




}
