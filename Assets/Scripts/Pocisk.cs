using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocisk : MonoBehaviour
{
	[SerializeField] private float predkoscPocisku = 3f;

	// Update is called once per frame
	void Update()
	{
		transform.position += Vector3.forward * predkoscPocisku;
	}
}
