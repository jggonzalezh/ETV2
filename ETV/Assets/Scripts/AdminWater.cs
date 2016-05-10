using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AdminWater : MonoBehaviour {


    public GameObject bucket;
    public GameObject contenedor;
    public GameObject tire;
    public GameObject trash;
    public GameObject recycling;
    public GameObject fountain;

    public GameObject bucketWater;
    public GameObject contenedorWater;
    public GameObject tireWater;
    public GameObject trashWater;
    public GameObject recyclingWater;
    public GameObject ftgWater1;
    public GameObject ftgWater2;
    public GameObject ftgWater3;
    public GameObject ftgWater4;
    static GameObject btndos;


    static int obj=0;

	// Use this for initialization
	void Start () {
        bucketWater = GameObject.FindGameObjectWithTag("bckwater");
        contenedorWater = GameObject.FindGameObjectWithTag("cntwater");
        tireWater  = GameObject.FindGameObjectWithTag("tiwater");
        trashWater= GameObject.FindGameObjectWithTag("trwater");
        recyclingWater= GameObject.FindGameObjectWithTag("rckwater");
        ftgWater1= GameObject.FindGameObjectWithTag("ftwater1");
        ftgWater2 = GameObject.FindGameObjectWithTag("ftwater2");
        ftgWater3 = GameObject.FindGameObjectWithTag("ftwater3");
        ftgWater4 = GameObject.FindGameObjectWithTag("ftwater4");






    
        bucketWater.SetActive(false);
        contenedorWater.SetActive(false);
        tireWater.SetActive(false);
        trashWater.SetActive(false);
        recyclingWater.SetActive(false);
        ftgWater1.SetActive(false);
        ftgWater2.SetActive(false);
        ftgWater3.SetActive(false);
        ftgWater4.SetActive(false);
    }


    //public static void UpdateObj(int addedValue,Button btn)
    public static void UpdateObj(int addedValue, GameObject btn)
    {
        obj = addedValue;
        btndos = btn;

    }


    public void agregarAgua()
    {

        switch (obj)
        {
            case 1  :

             
                contenedorWater.SetActive(true);         
                ScoreTracker.UpdateScore(1);
                ScoreTracker.UpdateMsg("sumo 1");
                contenedor = GameObject.FindGameObjectWithTag("theContenedor");
                contenedor.GetComponent<BoxCollider>().enabled = false;
                btndos.transform.localScale = new Vector3(0, 0, 0);
                obj = 0;




                break;
            case 2:
                tireWater.SetActive(true);
                ScoreTracker.UpdateScore(1);
                ScoreTracker.UpdateMsg("sumo 1");
                tire= GameObject.FindGameObjectWithTag("thetire");
                tire.GetComponent<BoxCollider>().enabled = false;
                btndos.transform.localScale = new Vector3(0, 0, 0);
                obj = 0;
                break;
            case 3:

                bucketWater.SetActive(true);
                ScoreTracker.UpdateScore(1);
                ScoreTracker.UpdateMsg("sumo 1");
                bucket = GameObject.FindGameObjectWithTag("theBucket");
                bucket.GetComponent<BoxCollider>().enabled = false;
                btndos.transform.localScale = new Vector3(0, 0, 0);
                obj = 0;

                break;

            case 4:

                trashWater.SetActive(true);                
                ScoreTracker.UpdateScore(1);
                ScoreTracker.UpdateMsg("sumo 1");

                trash = GameObject.FindGameObjectWithTag("theTrash");
                trash.GetComponent<BoxCollider>().enabled = false;
                btndos.transform.localScale = new Vector3(0, 0, 0);
                obj = 0;

                break;

            case 5:


                recyclingWater.SetActive(true);
                ScoreTracker.UpdateScore(1);
                ScoreTracker.UpdateMsg("sumo 1");
                recycling = GameObject.FindGameObjectWithTag("theRecycling");
                recycling.GetComponent<BoxCollider>().enabled = false;
                btndos.transform.localScale = new Vector3(0, 0, 0);
                obj = 0;

                break;

            case 6:


                ftgWater1.SetActive(true);
                ftgWater2.SetActive(true);
                ftgWater3.SetActive(true);
                ftgWater4.SetActive(true);
                ScoreTracker.UpdateScore(1);
                ScoreTracker.UpdateMsg("sumo 1");


                fountain = GameObject.FindGameObjectWithTag("thefountain");
                fountain.GetComponent<BoxCollider>().enabled = false;
                btndos.transform.localScale = new Vector3(0, 0, 0);
                obj = 0;

                break;


        }




    }



    public void SetDownState()
    {
        agregarAgua();

    }


    public void SetUpState()
    {
        Debug.Log("Up");
    }



}
