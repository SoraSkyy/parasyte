using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour {
	public float speed = 5;
	private GameObject itemPickUp;
	[SerializeField]
	private Element_type currentElement = Element_type.GRASS_MELEE;

	public List<GameObject> itemList = new List<GameObject>();

	// Use this for initialization
	void Start () {
		Debug.Log ("hi");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
				transform.position += new Vector3 (0, 1, 0) * Time.deltaTime * speed;
		} else if (Input.GetKey (KeyCode.S)) {
				transform.position += new Vector3 (0, -1, 0) * Time.deltaTime * speed;
		};

		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (1, 0, 0) * Time.deltaTime * speed;
			transform.localScale = new Vector3 (1, 1, 1);
		} else if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-1, 0, 0) * Time.deltaTime * speed;
			transform.localScale = new Vector3 (-1, 1, 1);
		};
	
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (itemList.Count > 0) {
				item test = itemList[0].GetComponent<item>();
				currentElement = test.GetElementType ();
				test.PickItem ();
				itemList.RemoveAt(0);
			}
		};
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		Debug.Log ("test");
	}

	void OnTriggerEnter2D(Collider2D colliderThing) { //returns object which you have collided with
		itemPickUp = colliderThing.gameObject;
		itemList.Add (itemPickUp);
	}

	void OnTriggerExit2D(Collider2D colliderThing) {
		itemList.Remove (colliderThing.gameObject);
		itemPickUp = null;
	}
}
