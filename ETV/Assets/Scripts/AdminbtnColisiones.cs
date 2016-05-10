using UnityEngine;
using System.Collections;

public class AdminbtnColisiones : MonoBehaviour {

 
    public GameObject btn;
    public GameObject btnDos;
    public GameObject btnTres;

    void Start()
    {
     
        btn.transform.localScale = new Vector3(0, 0, 0);
        btnDos.transform.localScale = new Vector3(0, 0, 0);
        btnTres.transform.localScale = new Vector3(0, 0, 0);
    }

    void OnTriggerEnter(Collider col)
    {
   

        switch (col.tag)
        {
            case "theContenedor":

                btn.transform.localScale = new Vector3(1, 1, 1);
            
                AdminWater.UpdateObj(1, btn);


                break;
            case "thetire":
         
                btn.transform.localScale = new Vector3(1, 1, 1);
       
                AdminWater.UpdateObj(2, btn);
                break;
            case "theBucket":

                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminWater.UpdateObj(3, btn);
                break;

            case "theTrash":

                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminWater.UpdateObj(4, btn);
                break;

            case "theRecycling":

                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminWater.UpdateObj(5, btn);
                break;

            case "thefountain":

                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminWater.UpdateObj(6, btn);
                break;

            case "theScaletta":
                btnDos.transform.localScale = new Vector3(1, 1, 1);
                AdminWater.UpdateObj(7, btn);
                break;



        }


    }


    void OnTriggerExit(Collider col)
    {

    
        btn.transform.localScale = new Vector3(0, 0, 0);
        btnDos.transform.localScale = new Vector3(0, 0, 0);

    }
}
