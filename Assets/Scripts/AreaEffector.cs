using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    public float time;
    public IEnumerator coroutine;

	// Use this for initialization
	void Start () {
      //  coroutine;
	}
	
	// Update is called once per frame
	void Update () {
        time = Time.deltaTime;
      
	}
}
