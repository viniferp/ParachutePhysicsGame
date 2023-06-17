using UnityEngine;
using System.Collections;

public class DontDestroyOnLoadScript : MonoBehaviour {

	public static DontDestroyOnLoadScript Instance;

	public void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);

		if(Instance)
			DestroyImmediate(gameObject);
		else
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
	}
}