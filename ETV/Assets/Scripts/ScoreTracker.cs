using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreTracker : MonoBehaviour {


    static Text  ptosText;
    static Text timeText;
    public static int ptos=0;
    public static float time=240;


    // Use this for initialization
    void Start () {

        ptosText = GameObject.FindGameObjectWithTag("ptosText").GetComponent<Text>();
        timeText = GameObject.FindGameObjectWithTag("timeText").GetComponent<Text>();

        UpdateScore(ptos);
              
    }

    // Update is called once per frame
    void Update()
    {

        if (time > 0)
        {
            time -= Time.deltaTime;
            timeText.text = time.ToString();
        }
        else {
            string e = "Nivel1lose";
            CambiarEscena(e);
        }

    }



    public static void UpdateScore(int addedValue) {
        ptos += addedValue;
        ptosText.text = ""+ptos;

        if (ptos == 6) {
            string e = "Nivel1win";
           CambiarEscena(e);

        }
        


    }


    public static void finjuego() {

        string e = "Nivel2win";
        CambiarEscena(e);

    }



    // Update is called once per frame
    public static void UpdateMsg(string message) {
  
      


    }


    public static void CambiarEscena(string escena)
    {

        SceneManager.LoadScene(escena);


    }




}
