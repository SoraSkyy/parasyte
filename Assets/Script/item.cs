using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {
	[SerializeField]
	private Element_type currentElement = Element_type.GRASS_MELEE;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Element_type GetElementType() {
		return currentElement;
	}

	public void PickItem() {
		Destroy (this.gameObject);
	}
}
