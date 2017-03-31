using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public static MenuController instance;
	[SerializeField] GameObject[] birds;

//	private bool isGreenBirdUnlocked, isRedBirdUnlocked;



	void Awake ()
	{

		MakeSingleton ();

	}

	// Use this for initialization
	void Start () {

		// Activate the stored bird
		//Debug.Log("Selected Bird: " + GameController.instance.SelectedBird);
		birds[GameController.instance.SelectedBird].SetActive(true);



		// check what is unlocked
//		CheckIfBirdsAreUnlocked();



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MakeSingleton ()
	{
		if (instance == null) {
			instance = this;
		}
	}

//
//	// Set bools for tracking whether birds are unlocked
//	void CheckIfBirdsAreUnlocked ()
//	{
//		if (GameController.instance.IsRedBirdUnlocked == 1) {
//			isRedBirdUnlocked = true;
//		}
//
//		if (GameController.instance.IsGreenBirdUnlocked == 1) {
//			isGreenBirdUnlocked = true;
//		}
//	}


	public void ChangeBird ()
	{

		// first run
		Debug.Log("Check Blue: [" + GameController.instance.SelectedBird + "] and green unlocked: [" + GameController.instance.IsGreenBirdUnlocked + "]");


		// Is blue bird selected but Green Bird Available?
		if (GameController.instance.SelectedBird == 0 && GameController.instance.IsGreenBirdUnlocked == 1) {
			Debug.Log("Blue changing to green");
			// disable blue bird
			birds [0].SetActive (false);

			// enable Green bird
			GameController.instance.SelectedBird = 1;
			birds [GameController.instance.SelectedBird].SetActive (true);

		} else if (GameController.instance.SelectedBird == 1 && GameController.instance.IsRedBirdUnlocked == 1) {
			// Is Green bird selected but Red Bird available?
			Debug.Log("green changing to red");
			// disable Green bird
			birds [1].SetActive (false);

			// enable Red bird
			GameController.instance.SelectedBird = 2;
			birds [GameController.instance.SelectedBird].SetActive (true);

		} else {
			Debug.Log("ELSE back to blue");

			// Cycle Back or Set to Blue Bird as default behavior
			birds [1].SetActive (false);
			birds [2].SetActive (false);

			// enable next bird
			GameController.instance.SelectedBird = 0;
			birds [GameController.instance.SelectedBird].SetActive (true);
			

		}

	}


	// Create function to allow Start Game button to work from main menu.
	public void StartGame ()
	{
		SceneManager.LoadScene("Gameplay");

	}


}
