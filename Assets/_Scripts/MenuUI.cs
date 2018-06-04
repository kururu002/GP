using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour {

	public GameObject target;
	private Transform trans;
	
	private bool isshow = false;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (isshow);
		trans = target.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void showMenu() {
		isshow = !isshow;
		gameObject.SetActive (isshow);
	}

	void OnGUI() {
		GUILayout.Label ("当前模型位置" + trans.GetChild(0).transform.position);
		GUILayout.Label ("C的位置" + trans.GetChild (0).GetChild (0).transform.position);
	}
}
