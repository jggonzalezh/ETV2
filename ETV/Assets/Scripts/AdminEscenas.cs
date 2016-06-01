using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdminEscenas : MonoBehaviour {

    public void CambiarEscena(string escena)
    {

        SceneManager.LoadScene(escena);
        ScoreTracker.ptos = 0;
        ScoreTracker.time = 40;


    }
}
