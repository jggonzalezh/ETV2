using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdminSeleccion : MonoBehaviour {

    public Dropdown menu;


    public void CambiarSeleccion()
    {



        switch (menu.value)
        {
            case 0:
             
                    
                break;
            case 1:

                SceneManager.LoadScene("AEDESE");


                break;
            case 2:

                SceneManager.LoadScene("AEDESA");


                break;
        }



    }
}
