using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GravityNpc : MonoBehaviour
{
	public bool GravityOn = true;
	private float GravityValue = 0.976f;
	private float gravidadeFiltrado;
	private float gravidadeFiltradoParachute;
	private float gravityInc;
	private float gravityIncPar;
	bool teclaC = false;
	public GameObject parachute;
	public Text winLose;
	float randomAltura;
	Vector3 movimentacao;
	public InputField entrada;

	void Start()
	{
		transform.position = new Vector3 (transform.position.x, 30f, transform.position.z);
		gravidadeFiltrado = 0;
		parachute.SetActive (false);
		randomAltura = Random.Range (2.0f,14.0f);

	}

	// Update is called once per frame
	void FixedUpdate ()
	{

		GravityValue = float.Parse( entrada.text);


		if (GravityOn) {

			gravidadeFiltrado = -GravityValue * Time.deltaTime;
			gravityInc = gravityInc + gravidadeFiltrado;
			transform.position = new Vector3 (transform.position.x, transform.position.y + gravityInc, transform.position.z);
		}



		if (randomAltura >= transform.position.y){

			teclaC = true;
			GravityOn = false;
		}


		if (teclaC) {

			parachute.SetActive (true);
			gravidadeFiltradoParachute = ((-GravityValue * 0.25f) * Time.deltaTime);
			gravityIncPar = gravityIncPar + gravidadeFiltradoParachute;
			transform.position = new Vector3 (transform.position.x, transform.position.y + gravityIncPar, transform.position.z);

		} 

		//41% DA ALTITUDE SALTADA PARA ABRIR PARA QUEDAS


		if (transform.position.y <= 0) {

			transform.position = new Vector3 (transform.position.x, 0f, transform.position.z);
			GravityOn = false;

			}	
		}
	}



