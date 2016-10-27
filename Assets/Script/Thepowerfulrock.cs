using UnityEngine;
using System.Collections;

public class Thepowerfulrock : MonoBehaviour {

    public int hp = 100;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
	}
}
