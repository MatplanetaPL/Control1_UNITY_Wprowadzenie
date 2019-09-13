using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrzeciwnikSpawn : MonoBehaviour
{
	[SerializeField] private GameObject przeciwnikPrefab;
	[SerializeField] private float odstep;

	private float min_X = -30f;
	private float max_X = 30f;


	private float nastepnySpawn = 0;

	void Update()
	{
		if (Time.time >= nastepnySpawn)
		{
			Vector3 miejsce = transform.position + 
							  new Vector3(1, 0, 0) * Random.Range(min_X, max_X);

			Instantiate(przeciwnikPrefab, miejsce, transform.rotation);
			nastepnySpawn = Time.time + odstep;
		}
	}
}
