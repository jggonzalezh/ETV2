using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdminInicio : MonoBehaviour {

    //public GameObject fpc;
    public GameObject cnv;
    public GameObject dtc;



    // Use this for initialization
    void Start () {
        //fpc = GameObject.FindGameObjectWithTag("theFPC");
        cnv = GameObject.FindGameObjectWithTag("theCanvas");
        dtc= GameObject.FindGameObjectWithTag("dtc");
        dtc.GetComponent<Canvas>().enabled = false;

    }

    // Update is called once per frame
    void Update () {
	
	}



    public void iniciarNivel() {

        dtc.GetComponent<Canvas>().enabled = true;
        ScoreTracker.ptos = 0;
        ScoreTracker.time = 240;
        Destroy(cnv);
    }
}
