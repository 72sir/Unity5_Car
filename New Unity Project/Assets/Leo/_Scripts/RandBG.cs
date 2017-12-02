using UnityEngine;
using System.Collections;

public class RandBG : MonoBehaviour {

	public Material[] materials;

	// Use this for initialization
	void Start () {
		GetComponent <Skybox> ().material = materials [Random.Range(0, materials.Length)];
	}

}
