using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ruch : MonoBehaviour
{
	[Range(0, 5)]
	[SerializeField] private float predkosc = 0.5f;

	[SerializeField] private GameObject pociskPrefab;

	private Vector3 pozycjaStatku;
	

	// Start is called before the first frame update
	void Start()
	{
		pozycjaStatku = transform.position;

		int x = 3;
		int maksymalny_x = 5;

		if (x < maksymalny_x)
		{
			// zwiększ x;
		}

	}

	// Update is called once per frame
	void Update()
	{
		pozycjaStatku = transform.position;

		if (Input.GetKey(KeyCode.RightArrow))
		{
			pozycjaStatku = pozycjaStatku + Vector3.right * predkosc;
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			pozycjaStatku = pozycjaStatku + Vector3.left * predkosc;
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			pozycjaStatku = pozycjaStatku + Vector3.forward * predkosc;
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			pozycjaStatku = pozycjaStatku + Vector3.back * predkosc;
		}

		float pozX = Mathf.Clamp(pozycjaStatku.x, -30, 30);
		float pozZ = Mathf.Clamp(pozycjaStatku.z, -15, 15);
		transform.position = new Vector3(pozX, pozycjaStatku.y, pozZ);

		if (Input.GetKey(KeyCode.Space))
		{
			print("Strzelam!");
			Instantiate(pociskPrefab, transform.position, Quaternion.identity);
		}
	}
}
