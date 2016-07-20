using UnityEngine;
using System.Collections;

public class UISeguirAlvo : MonoBehaviour {

	private Transform _alvo;
	private float _distancia;
	public Transform _ui;

	// Use this for initialization
	void Start () {
		_alvo = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		_ui.transform.position = Camera.main.WorldToScreenPoint (_alvo.position);
		_distancia = Vector3.Distance (Camera.main.transform.position,_alvo.position);

		if (_distancia >= 4 && _distancia <= 15) {
			_ui.gameObject.SetActive (true);
		} else {
			_ui.gameObject.SetActive(false);
		}

	}
}
