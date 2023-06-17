using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {

		offset.x = 0f;
		offset.y = player.transform.position.y;
		offset.z = -15f;

		transform.position = offset;

	}
	
	
	void LateUpdate(){


		if (transform.position.y > 5.0f) { 

			offset.y = player.transform.position.y;

			transform.position = offset;

		} else {


		}
	}
}
