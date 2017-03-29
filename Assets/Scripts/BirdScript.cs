using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour {

	public static BirdScript instance;

	[SerializeField] private Rigidbody2D myRigidBody2D;

	[SerializeField] private Animator animator;

	private float forwardSpeed = 3.0f;
	private float bounceSpeed = 4.0f;

	private bool didFlap;
	public bool isAlive;


	private Button flapButton;

	void Awake ()
	{
		if (instance == null) {
			instance = this;
		}

		isAlive = true;

		// get the Flap Button panel
		flapButton = GameObject.FindGameObjectWithTag("FlapButton").GetComponent<Button>();

		// Add an OnClick listener to run the FlapTheBird function
		flapButton.onClick.AddListener( () => FlapTheBird() );
	}


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		if (isAlive) {

			// get position of the bird and move it forward
			Vector3 temp = transform.position;
			temp.x += forwardSpeed * Time.deltaTime;
			transform.position = temp;

			//Debug.Log(transform.position + ";  move amt [" + temp.x + "]");

			// only flap once when tapped
			if (didFlap) {
				didFlap = false;

				myRigidBody2D.velocity = new Vector2 (0, bounceSpeed);

				animator.SetTrigger ("Flap");

			}


			// check Y velocity, if its above zero we do no angle change
			if (myRigidBody2D.velocity.y >= 0) {
				transform.rotation = Quaternion.Euler (0, 0, 0);
			} else {

				// we're heading downward!
				float angle = 0;

				// TODO - lookup mathf.lerp
				angle = Mathf.Lerp (0, -80, -myRigidBody2D.velocity.y / 7);
				transform.rotation = Quaternion.Euler(0,0,angle);

			}


		}

		
	}



	public void FlapTheBird ()
	{

		didFlap = true;

	}


	// get the X position
	public float GetPositionX ()
	{
		return transform.position.x;

	}

	// SJ - Calculate the camera X-position offset to put bird on left
	private void SetCamerasX ()
	{

		// update the Camera static offset value
		//CameraScript.offsetX = (Camera.main.transform.position.x - transform.position.x) - 1f;



	}

}
