using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public GameObject quitMenu;
	public GameObject instructionMenu;
	public GameObject startText;
	public GameObject exitText;
	public GameObject tutorialText;


	// Use this for initialization
	void Start () {

	}



	private void InstructionPress(){

		Debug.Log ("ENTROU INSTRUCTION");

		instructionMenu.SetActive (true);
		quitMenu.SetActive(false);
		startText.SetActive (false);
		exitText.SetActive(false);
	}

	private void ExitPress(){

		Debug.Log ("ENTROU EXIT_PRESS");
		quitMenu.SetActive(true); 
		startText.SetActive (false);
		exitText.SetActive(false);
		instructionMenu.SetActive (false);

	}
		
	private void NoPress(){

		instructionMenu.SetActive(false);;
		quitMenu.SetActive(false); 
		startText.SetActive(true);
		exitText.SetActive(true);
		tutorialText.SetActive(true);
	}

	private void StartLevel(){

		SceneManager.LoadScene(1);

	}


	private void ExitGame(){

		Application.Quit();

	}





}

