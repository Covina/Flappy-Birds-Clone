using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController instance;


	// store the high score lookup key for playerprefs
	private const string HIGH_SCORE = "High Score";
	private const string SELECTED_BIRD = "Selected Bird";
	private const string GREEN_BIRD = "Green Bird";
	private const string BLUE_BIRD = "Blue Bird";
	private const string RED_BIRD = "Red Bird";


	void Awake ()
	{
		MakeSingleton();

		// init the player prefs
		IsThisPlayersFirstTime();

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MakeSingleton()
	{

		// Create a singleton
		if (instance != null) {
			Destroy(gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

	}


	// Set the prefs
	void IsThisPlayersFirstTime() 
	{

		// have we init values before?
		if( !PlayerPrefs.HasKey("IsPlayersFirstTime") ) {

			// If not, init
			PlayerPrefs.SetInt(HIGH_SCORE, 0);
			PlayerPrefs.SetInt(SELECTED_BIRD, 0);
			PlayerPrefs.SetInt(GREEN_BIRD, 0);
			PlayerPrefs.SetInt(BLUE_BIRD, 1);
			PlayerPrefs.SetInt(RED_BIRD, 0);
			PlayerPrefs.SetInt("IsPlayersFirstTime", 0);


		}

	}


	// SJ - Adding Getters and Setters, foregoing the set/get function approach in the lesson.
	public int HighScore 
	{
		get { return PlayerPrefs.GetInt(HIGH_SCORE); }

		set { PlayerPrefs.SetInt(HIGH_SCORE, value); }
	}

	public int SelectedBird 
	{
		get { return PlayerPrefs.GetInt(SELECTED_BIRD); }

		set { PlayerPrefs.SetInt(SELECTED_BIRD, value); }
	}

	public int IsGreenBirdUnlocked 
	{
		get { return PlayerPrefs.GetInt(GREEN_BIRD); }

		set { PlayerPrefs.SetInt(GREEN_BIRD, value); }
	}


	public int IsRedBirdUnlocked 
	{
		get { return PlayerPrefs.GetInt(RED_BIRD); }

		set { PlayerPrefs.SetInt(RED_BIRD, value); }
	}

}
