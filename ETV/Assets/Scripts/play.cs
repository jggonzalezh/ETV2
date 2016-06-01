using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour {

	public void jugar(string  escena)
    {

        SceneManager.LoadScene(escena);
    }
}
