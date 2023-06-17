using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundController : MonoBehaviour {

	public Text roundText;
	private int roundcount;
	public Text beginCount;
	public GameObject winText;
	public GameObject loseText;
	public GameObject diedText;
	private int count;
	public GameObject p1;
	public GameObject p2;
	public Placar s1;
	private bool isGrounded = false;
	public GameObject restartCanvas;
	public GameObject winCanvas;
	public GameObject loseCanvas;
	public Gravity gravity;
	public GravityNpc gravityNpc;
	Gravity gravidade = new Gravity();





	void Start () {

		s1 = GameObject.Find ("Placar").GetComponent<Placar>();
		roundcount = 1;
		roundText.text  = "ROUND " + roundcount.ToString();
		count = 3;
		InvokeRepeating("UpdateEach2Seconds", 0.5f,0.5f);
		gravidade = new Gravity();

	}


	void Update () {

		if(p1.transform.position.y == 0 && p2.transform.position.y == 0){

			restartCanvas.SetActive (true);	
		}

		if (s1.playerScore == 3) {

			Debug.Log ("S1 ENTROU");
			winCanvas.SetActive (true);
			winText.SetActive (false);
			restartCanvas.SetActive (false);
			

		}

		if (s1.pcScore == 3) {

			loseCanvas.SetActive (true);
			loseText.SetActive (false);
			restartCanvas.SetActive (false);
		
		}

		if (isGrounded == true && gravidade.activeParachute == false) {

			Debug.Log ("TESTE");
			diedText.SetActive (true);
		}



		if (p1.transform.position.y == 0 && p1.transform.position.y < p2.transform.position.y && isGrounded == false ) {
			
			isGrounded = true;
			restartCanvas.SetActive (true);	

			if (gravidade.activeParachute == true) {

				winText.SetActive (true);
				s1.playerScore++;

			} else {

				loseText.SetActive (true);
			}

				
		} 


		if(p2.transform.position.y == 0 && p2.transform.position.y < p1.transform.position.y && isGrounded == false){


			s1.pcScore++;
			isGrounded = true;
			restartCanvas.SetActive (true);	

			loseText.SetActive(true);
		}

	}

	void UpdateEach2Seconds(){
		beginCount.text = (count.ToString ());


		if (count > 0) {
			count--;
		}else

			if (count == 0) { 	

				beginCount.text = ("GO");

			
				count--;

			gravity.GravityOn = true;
			gravityNpc.GravityOn = true;	

			} else

		if (count <= -1) {
			beginCount.GetComponent<Text> ().enabled = false;

					Gravity g = new Gravity();
					g.GravityOn  = false;

			GravityNpc gNpc = new GravityNpc ();
			gNpc.GravityOn = true;
			}
	
		}
	}

		

