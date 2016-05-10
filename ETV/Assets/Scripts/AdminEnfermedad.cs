using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdminEnfermedad : MonoBehaviour {

    public GameObject p;
    public GameObject pdos;
    public GameObject ptres;


    void Start()
    {
      

        p.transform.localScale = new Vector3(0, 0, 0);
        pdos.transform.localScale = new Vector3(0, 0, 0);
        ptres.transform.localScale = new Vector3(0, 0, 0);

    }




    public void CambiarEnfermedad(string panel)
    {

        switch (panel)
        {
            case "pndengue":
                p.transform.localScale = new Vector3(1, 1, 1);
                pdos.transform.localScale = new Vector3(0, 0, 0);
                ptres.transform.localScale = new Vector3(0, 0, 0);


                break;

            case "pnck":
                p.transform.localScale = new Vector3(0, 0, 0);
                pdos.transform.localScale = new Vector3(1, 1, 1);
                ptres.transform.localScale = new Vector3(0, 0, 0);
                break;

            case "pnzika":
                p.transform.localScale = new Vector3(0, 0, 0);
                pdos.transform.localScale = new Vector3(0, 0, 0);
                ptres.transform.localScale = new Vector3(1, 1, 1);

                break;



        }


      


    }
}
