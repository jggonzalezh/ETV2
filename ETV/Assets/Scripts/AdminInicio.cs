using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdminInicio : MonoBehaviour {

    public GameObject fpc;
    public GameObject cnv;

    // Use this for initialization
    void Start () {
        fpc = GameObject.FindGameObjectWithTag("theFPC");
        cnv = GameObject.FindGameObjectWithTag("theCanvas");
       // fpc.transform.localScale = new Vector3(0, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {
	
	}



    public void iniciarNivel() {

        fpc.transform.localScale = new Vector3(1, 1, 1);
        Destroy(cnv);
    }
}
