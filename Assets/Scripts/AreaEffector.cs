using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Juan Rodolfo Alonzo Molina
//15470

public class AreaEffector : MonoBehaviour {

    public float time;
    public bool objeto = true;

	// Use this for initialization
	void Start () {
      //  coroutine;
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;

        if (time >= 3f)
        {
            gameObject.SetActive(false);
        }

        if (time >= 6f)
        {
            gameObject.SetActive(true);
            time = 0;
        }
	}
}
