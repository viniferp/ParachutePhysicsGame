using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class ButtonHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void StartLevel(){

		SceneManager.LoadScene(1);

	}

	public void backMenu(){

		SceneManager.LoadScene(0);
	}

	public void quitGame(){

		Application.Quit();
	}
}
