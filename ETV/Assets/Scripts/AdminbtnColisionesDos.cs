﻿using UnityEngine;
using System.Collections;

public class AdminbtnColisionesDos : MonoBehaviour {

    public GameObject btn;
    public Animation anim;

    void Start()
    {

        btn.transform.localScale = new Vector3(0, 0, 0);
  
    }

    void OnTriggerEnter(Collider col)
    {


        switch (col.tag)
        {
            case "theContenedor":

                btn.transform.localScale = new Vector3(1, 1, 1);

                AdminHuevos.UpdateObj(1, btn);


                break;
            case "thetire":

                btn.transform.localScale = new Vector3(1, 1, 1);

                AdminHuevos.UpdateObj(2, btn);
                break;
            case "theBucket":

                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminHuevos.UpdateObj(3, btn);
                break;

            case "theTrash":

                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminHuevos.UpdateObj(4, btn);
                break;

            case "theRecycling":

                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminHuevos.UpdateObj(5, btn);
                break;

            case "thefountain":

                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminHuevos.UpdateObj(6, btn);
                break;

            case "theScaletta":
                subirEscalera(true);
                break;



        }


    }


    void OnTriggerExit(Collider col)
    {


        btn.transform.localScale = new Vector3(0, 0, 0);
 

    }


    public void subirEscalera(bool esconder)
    {

        
        anim = GameObject.FindGameObjectWithTag("theFPC").GetComponent<Animation>();
        anim.Play();
        

    }

}
