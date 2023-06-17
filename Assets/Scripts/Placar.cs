using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Placar : MonoBehaviour {

	public int playerScore = 0;
	public int pcScore = 0;
	public Text playerText;
	public Text pcText;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		if(playerText == null)	playerText = GameObject.Find ("PlayerPoints").GetComponent<Text> ();
		if(pcText == null)	 pcText =  GameObject.Find ("PcPoints").GetComponent<Text> ();

		updateLabels();
	
	}

	void updateLabels(){

		playerText.text = ("Player: " + playerScore);
		pcText.text = ("Pc: " + pcScore);


	}

}