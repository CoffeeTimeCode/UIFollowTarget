using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TesteDeUIFollowObj : MonoBehaviour {

	private Transform _target;
	public Transform _ui;

	// Use this for initialization
	void Start () {
		_target = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		_ui.transform.position = Camera.main.WorldToScreenPoint(_target.position);
		if(Vector3.Distance(Camera.main.transform.position,_target.position) < 15 && Vector3.Distance(Camera.main.transform.position,_target.position) > 4){
			_ui.gameObject.SetActive(true);
		}else{
			_ui.gameObject.SetActive(false);
		}
	}
}
