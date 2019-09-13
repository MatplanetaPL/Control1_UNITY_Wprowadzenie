using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruch : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = transform.position + Vector3.right * 0.1f;
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = transform.position + Vector3.left * 0.1f;
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = transform.position + Vector3.forward * 0.1f;
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = transform.position + Vector3.back * 0.1f;
		}
	}
}
