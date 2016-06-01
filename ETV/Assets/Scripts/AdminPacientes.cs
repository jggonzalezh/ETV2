using UnityEngine;
using System.Collections;

public class AdminPacientes : MonoBehaviour {


 
    public GameObject boy;
    public GameObject remmy;

   
    static GameObject btndos;


    static int obj = 0;
    public Animation anim;



    // Use this for initialization
    void Start()
    {
       
        remmy = GameObject.FindGameObjectWithTag("remmy");

        remmy.SetActive(false);

       
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
          
            case 7:
                subirEscalera(0);
                ScoreTracker.UpdateScore(1);
                boy = GameObject.FindGameObjectWithTag("boy");
                boy.GetComponent<BoxCollider>().enabled = false;
                btndos.transform.localScale = new Vector3(0, 0, 0);
                obj = 0;
                remmy.SetActive(true);

                break;

            case 8:
                CharacterControl.salir();
                subirEscalera(1);          
                remmy.GetComponent<BoxCollider>().enabled = false;
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

    public void subirEscalera(int n)
    {


        anim = GameObject.FindGameObjectWithTag("theFPC").GetComponent<Animation>();

        if (n == 0)
        {
            anim.Play("picar");
        }
        else {
            anim.Play("picarDos");
            Invoke("acabar", 5);


        }


    }

    public void acabar()
    {

        ScoreTracker.finjuego();


    }
}
