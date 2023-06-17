	using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class PointsController : MonoBehaviour {

	public Text playerPoints;
	public Text pcPoints;
	public  GameObject pc;
	private int p1 = 0;
	private int p2 = 0;

	void Start () {

		playerPoints.text = (" Player : " + p1); 
		pcPoints.text = (" Pc : " + p2);

	}

		

	void fixedUpdate () {

		if (transform.position.y == 0 && pc.transform.position.y > 0) {

			p1++;

		} else if (transform.position.y > 0 && pc.transform.position.y == 0) {

			p2++;
		} 

		playerPoints.text = (" Player : " + p1); 
		pcPoints.text = (" Pc : " + p2);
	}
}
