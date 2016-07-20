using UnityEngine;
using System.Collections;

public class SeguirOAlvo : MonoBehaviour {

	public Transform _alvo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = Camera.main.WorldToScreenPoint (_alvo.position);
	}
}
