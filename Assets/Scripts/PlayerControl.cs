using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed = 10;
	public Rigidbody rb;

	public Text countText;
	public GameObject winText;

	private int countPickups = 0;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		countPickups = 0;
		SetCountText ();
		winText.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Vector3 force = new Vector3 (x, 0f, z);

		rb.AddForce(force * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("pickup")) {
			other.gameObject.SetActive (false);

			countPickups++;
			SetCountText ();

			if (countPickups >= 11)
				winText.SetActive (true);
		}
	}

	void SetCountText(){
		countText.text = "Count :" + countPickups;
	}
}
