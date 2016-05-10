using UnityEngine;
using System.Collections;

public class SubirEscalera : MonoBehaviour {

    public GameObject btntres;

    public Animation anim;

    public void subirEscalera(bool esconder)
    {

      //  Debug.Log("Suba");
        anim=GameObject.FindGameObjectWithTag("theFPC").GetComponent<Animation>();
        anim.Play();
        btntres.transform.localScale = new Vector3(0, 0, 0);

    }



    public void SetDownState()
    {
        
        subirEscalera(true);

    }

}
