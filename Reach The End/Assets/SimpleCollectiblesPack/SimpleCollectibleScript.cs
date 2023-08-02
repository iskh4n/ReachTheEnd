using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SimpleCollectibleScript : MonoBehaviour {

	public enum CollectibleTypes {NoType, Type1, Type2, Type3, Type4, Type5}; // you can replace this with your own labels for the types of collectibles in your game!

	public CollectibleTypes CollectibleType; // this gameObject's type

	public bool rotate; // do you want it to rotate?

	public float rotationSpeed;

	public AudioClip collectSound;

	public GameObject collectEffect;
	private Score scoremanager;
	public Healthbar healthbar;
	public Playerr player;
	public bool miknatis_alindi = false;
	public float timer = 0.0f;
	

	// Use this for initialization
	void Start () {
		scoremanager = FindObjectOfType<Score>();
		player = FindObjectOfType<Playerr>();
		//miknatis_alindi = false;
		//GameObject M = GameObject.FindGameObjectWithTag("miknatis");
		//GameObject[] Altin = GameObject.FindGameObjectsWithTag("altin");


		



	}
	
	// Update is called once per frame
	void Update () {

		if (miknatis_alindi == true)
		{
			timer += 1 * Time.deltaTime;
			if (timer >= 10)
			{
				miknatis_alindi = false;
				timer = 0;
			}
		}

		GameObject[] Altinlar = GameObject.FindGameObjectsWithTag("altin");
		GameObject[] tum_miknatislar = GameObject.FindGameObjectsWithTag("miknatis");
		GameObject P = GameObject.FindGameObjectWithTag("Player");
		GameObject M = GameObject.FindGameObjectWithTag("miknatis");
		foreach (GameObject altin in Altinlar)
		{
			if (miknatis_alindi == true)
			{
				if (Vector3.Distance(altin.transform.position, P.transform.position) < 10)
				{
					altin.transform.Translate((P.transform.position - altin.transform.position).normalized * 4 * Time.deltaTime, Space.World);
				}
			}

		}








		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			Collect ();
		}
	}


	public void Collect()
	{
		
		if (collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		if(collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);

		//Below is space to add in your code for what happens based on the collectible type

		if (CollectibleType == CollectibleTypes.NoType) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type1) {

			scoremanager.ScoreCount += 10;

			Debug.Log ("Coin");
		}
		if (CollectibleType == CollectibleTypes.Type2) {

			//Add in code here;
			//player.currentHealth += 10;
			//healthbar.setHealth(player.currentHealth);
			player.TakeHeal(10);

			Debug.Log ("Health bar");
		}
		if (CollectibleType == CollectibleTypes.Type3) {

			//Add in code here;

			GameObject[] Altinlar = GameObject.FindGameObjectsWithTag("altin");
			GameObject[] tum_miknatislar = GameObject.FindGameObjectsWithTag("miknatis");
			GameObject P = GameObject.FindGameObjectWithTag("Player");
			GameObject M = GameObject.FindGameObjectWithTag("miknatis");

			foreach (GameObject Miknatis in tum_miknatislar)
			//	{
			//Destroy(Miknatis);
			//	}
			

			if (M != null)
			{

				if (miknatis_alindi == false)
				{
					miknatis_alindi = true;
				}

			}



			scoremanager.ScoreCount += 10;

			Debug.Log ("Miknatis");
		}
		if (CollectibleType == CollectibleTypes.Type4) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type5) {

			//Add in code here;

			Debug.Log ("Do NoType Command");
		}

		Destroy (gameObject);

		Destroy(GameObject.FindGameObjectWithTag("ParticleEff"), 0.5f);
	}
	
}
