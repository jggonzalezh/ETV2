using UnityEngine;
using System.Collections;

public class AdminColisionesTres : MonoBehaviour {

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
            

            case "laPareduno":
                subirEscalera(1);
                break;

            case "laParedDos":
                subirEscalera(0);
                break;

            case "boy":
                btn.transform.localScale = new Vector3(1, 1, 1);
                AdminPacientes.UpdateObj(7, btn);
                break;

        

        }


    }


    void OnTriggerExit(Collider col)
    {


        btn.transform.localScale = new Vector3(0, 0, 0);


    }


    public void subirEscalera(int n)
    {


        anim = GameObject.FindGameObjectWithTag("theFPC").GetComponent<Animation>();

        if (n == 0)
        {
            anim.Play("SubirEscaleras");
        }
        else {
            anim.Play("SubirParedUno");
        }

    }
}
