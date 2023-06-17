using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gravity : MonoBehaviour
{
	public bool GravityOn = true;
	public float GravityValue = 0.976f;
	private float gravidadeFiltrado;
	private float gravidadeFiltradoParachute;
	private float gravityInc;
	private float gravityIncPar;

	private bool teclaC = false;
	public GameObject parachute;
	public Text velocidade;
	public Text altura;
	public Text veloParaquedas;
	public bool activeParachute = true; 
	public InputField entrada;

	Vector3 tempPos;
	Vector3 movimentacao;


	void Start()
	{
		transform.position = new Vector3 (transform.position.x, 30f, transform.position.z);
		tempPos = transform.position;
		gravidadeFiltrado = 0;
		parachute.SetActive (false);
		GravityOn = false;
		altura.text = (tempPos.y).ToString() + " m";
		velocidade.text = (gravityInc*Time.deltaTime).ToString() + " m/s" ;


	}

	// Update is called once per frame
	void FixedUpdate ()
	{

		GravityValue = float.Parse( entrada.text);

		tempPos = transform.position;
		altura.text = (tempPos.y).ToString() + " m";
		velocidade.text = (gravityInc*Time.deltaTime*-1000).ToString() + " m/s" ;

		if (GravityOn) {



			gravidadeFiltrado = -GravityValue * Time.deltaTime;
			//Debug.Log("Velocidade eicho Y =  " + (gravidadeFiltrado * 3.6f) + "km/h");
			//  movimentacao += new Vector3(0,gravidadeFiltrado , 0);
			//  controlador.Move(movimentacao * Time.deltaTime);

			gravityInc = gravityInc + gravidadeFiltrado;
			transform.position = new Vector3 (transform.position.x, transform.position.y + gravityInc, transform.position.z);
		}



		if (Input.GetKey (KeyCode.C)) {

			teclaC = true;
			//alturaParaquedas = tempPos.y;
			GravityOn = false;


		}


		if (teclaC) {

			parachute.SetActive (true);
			activeParachute = true;

			gravidadeFiltradoParachute = ((-GravityValue * 0.25f) * Time.deltaTime);
			//Debug.Log("Velocidade eicho Y =  " + (gravidadeFiltrado * 3.6f) + "km/h");
			//  movimentacao += new Vector3(0,gravidadeFiltrado , 0);
			//  controlador.Move(movimentacao * Time.deltaTime);

			gravityIncPar = gravityIncPar + gravidadeFiltradoParachute;
			transform.position = new Vector3 (transform.position.x, transform.position.y + gravityIncPar, transform.position.z);

			if (transform.position.y >= 0) {
				veloParaquedas.text = (gravityIncPar * Time.deltaTime * -1000).ToString () + " m/s";
			}
		} 

		//41% DA ALTITUDE SALTADA PARA ABRIR PARA QUEDAS

		if (parachute.activeInHierarchy == false && tempPos.y <= 0f) {


			altura.text = 0.ToString() + " m";

		
		}

		if (transform.position.y <= 0) {

			transform.position = new Vector3 (transform.position.x, 0f, transform.position.z);
			GravityOn = false;
			altura.text = 0.ToString() + " m";

		}
	}
}


