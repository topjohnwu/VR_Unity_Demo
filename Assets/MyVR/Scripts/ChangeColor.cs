using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	public Material inactiveMaterial;
	public Material gazedAtMaterial;

	// Use this for initialization
	void Start () {
		setGazedAt (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setGazedAt(bool gazedAt) {
//		GetComponent<Renderer> ().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
	}
}
