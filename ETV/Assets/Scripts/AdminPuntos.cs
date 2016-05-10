using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdminPuntos : MonoBehaviour {

    public Button btn;

    
    void Start()
    {
        Debug.Log("Desactivo");
        

        btn.interactable = false;
        btn.transform.localScale = new Vector3(0, 0, 0);

    }

        void OnTriggerEnter(Collider col) {
        Debug.Log("Entro");

        switch (col.tag)
        {
            case "theContenedor":


        

                btn.transform.localScale = new Vector3(1, 1, 1);
                btn.interactable = true;
                //AdminWater.UpdateObj(1, btn);


                break;
            case "thetire":
                
                btn.transform.localScale = new Vector3(1, 1, 1);
                btn.interactable = true;
                //AdminWater.UpdateObj(2,btn);
                break;
            case "theBucket":

                
                btn.transform.localScale = new Vector3(1, 1, 1);
                btn.interactable = true;
                //AdminWater.UpdateObj(3,btn);
                break;

        }


    }


    void OnTriggerExit(Collider col)
    {

       btn.interactable = false;
       btn.transform.localScale = new Vector3(0, 0, 0);

     
    }


   



}
