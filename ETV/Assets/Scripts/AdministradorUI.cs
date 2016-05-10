using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdministradorUI : MonoBehaviour {

    public void CambiarEscena(string escena)
    {
     
        SceneManager.LoadScene(escena);


    }
}
