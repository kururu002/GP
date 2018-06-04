using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementUI : MonoBehaviour {

	public GameObject target;

	private Transform trans;

	// Use this for initialization
	void Start () {
		trans = target.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeToSphere() {
		Destroy (trans.GetChild (0).gameObject);
		GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphere.transform.name = "Sphere";
		sphere.transform.parent = trans;
		sphere.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		sphere.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
	}

	public void ChangeToCube() {
		Destroy (trans.GetChild (0).gameObject);
		GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.transform.name = "Cube";
		cube.transform.parent = trans;
		cube.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		cube.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
	}

	public void Carbon() {
		Destroy (trans.GetChild (0).gameObject);
		GameObject Carbon = (GameObject)Instantiate (Resources.Load ("_Prefabs/Carbon"));
		Carbon.transform.name = "Carbon";
		Carbon.transform.parent = trans;
		Carbon.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		Carbon.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
	}

	public void CovalentBond() {
		Destroy (trans.GetChild (0).gameObject);
		GameObject CovalentBond = (GameObject)Instantiate (Resources.Load ("_Prefabs/CovalentBond"));
		CovalentBond.transform.name = "CovalentBond";
		CovalentBond.transform.parent = trans;
		CovalentBond.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		CovalentBond.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
	}

	public void H2O() {
		Destroy (trans.GetChild (0).gameObject);
		GameObject H2O = (GameObject)Instantiate (Resources.Load ("_Prefabs/H2O"));
		H2O.transform.name = "H2O";
		H2O.transform.parent = trans;
		H2O.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		H2O.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
	}

	public void Hydrogen() {
		Destroy (trans.GetChild (0).gameObject);
		GameObject Hydrogen = (GameObject)Instantiate (Resources.Load ("_Prefabs/Hydrogen"));
		Hydrogen.transform.name = "Hydrogen";
		Hydrogen.transform.parent = trans;
		Hydrogen.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		Hydrogen.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
	}

	public void Methane() {
		Destroy (trans.GetChild (0).gameObject);
		GameObject Methane = (GameObject)Instantiate (Resources.Load ("_Prefabs/Methane"));
		Methane.transform.name = "Methane";
		Methane.transform.parent = trans;
		Methane.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		Methane.transform.localPosition = new Vector3 (0.0f, -2.0f, -0.7f);
	}

	public void Oxygen() {
		Destroy (trans.GetChild (0).gameObject);
		GameObject Oxygen = (GameObject)Instantiate (Resources.Load ("_Prefabs/Oxygen"));
		Oxygen.transform.name = "Oxygen";
		Oxygen.transform.parent = trans;
		Oxygen.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		Oxygen.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
	}
}
