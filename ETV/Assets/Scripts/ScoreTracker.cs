using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreTracker : MonoBehaviour {


    static Text  ptosText;
    static int ptos=0;
    


    // Use this for initialization
    void Start () {

        ptosText = GameObject.FindGameObjectWithTag("ptosText").GetComponent<Text>();
        UpdateScore(ptos);
      

        
    }


    public static void UpdateScore(int addedValue) {
        ptos += addedValue;
        ptosText.text = ""+ptos;

    }

    // Update is called once per frame
    public static void UpdateMsg(string message) {
  
      


    }
}
