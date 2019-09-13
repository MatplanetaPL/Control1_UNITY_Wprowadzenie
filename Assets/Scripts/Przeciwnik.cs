using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przeciwnik : MonoBehaviour
{

	[SerializeField] private int Zycie = 10;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Pociski"))
		{
			Destroy(other.gameObject);
			Zycie--;

			if (Zycie <= 0)
			{
				Destroy(gameObject);
			}
		}		
	}

	[SerializeField] private float predkosc = 0.1f;

	private void Update()
	{
		transform.position += transform.forward * predkosc;
	}
}
