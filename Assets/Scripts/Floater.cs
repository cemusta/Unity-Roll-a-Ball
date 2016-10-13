using UnityEngine;
using System.Collections;

public class Floater : MonoBehaviour {

	public float normalValue = 0.723f;
	public float floatingParam = 0.15f;
	
	// Use this for initialization
	void Start () {
		normalValue = transform.position.y;
	}

	// Update is called once per frame
	void Update () {

		float sin = normalValue + floatingParam * Mathf.Sin (Time.time);

		this.transform.position = new Vector3(transform.position.x,sin,transform.position.z);
	}
}
