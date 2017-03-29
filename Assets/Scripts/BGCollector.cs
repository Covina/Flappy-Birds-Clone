using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCollector : MonoBehaviour {

	private GameObject[] backgrounds;
	private GameObject[] grounds;


	private float lastBGX;
	private float lastGroundX;


	void Awake ()
	{
		backgrounds = GameObject.FindGameObjectsWithTag ("Background");
		grounds = GameObject.FindGameObjectsWithTag ("Ground");

		lastBGX = backgrounds [0].transform.position.x;
		lastGroundX = grounds [0].transform.position.x;


		foreach (GameObject bg in backgrounds) {
			// SJ - check if its bigger, if so assign it, otherwise leave value the same
			// variable = (condition) ? true : false
			lastBGX = (bg.transform.position.x > lastBGX) ? bg.transform.position.x : lastBGX;

		}

		foreach (GameObject gr in grounds) {
			// SJ - check if its bigger, if so assign it, otherwise leave value the same
			lastGroundX = (gr.transform.position.x > lastGroundX) ? gr.transform.position.x : lastGroundX;

		}

		//Debug.Log("lastGroundX: [" + lastGroundX + "]; lastBGX: [" + lastBGX + "]");

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D (Collider2D collider)
	{

		if (collider.tag == "Background") {

			// get the position of the bg, preparing to move it
			Vector3 temp = collider.transform.position;

			// typecast the bg into its box collider and get the X Size
			float width = ((BoxCollider2D)collider).size.x;

			// now move it to the end
			temp.x = lastBGX + width;
			collider.transform.position = temp;

			// update newly added panel to be last X position
			lastBGX = temp.x;


		} else if (collider.tag == "Ground") {

			// get the position of the bg, preparing to move it
			Vector3 temp = collider.transform.position;

			// typecast the bg into its box collider and get the X Size
			float width = ((BoxCollider2D)collider).size.x;

			// now move it to the end
			temp.x = lastGroundX + width;
			collider.transform.position = temp;

			// update newly added panel to be last X position
			lastGroundX = temp.x;


		}		


	}
}
