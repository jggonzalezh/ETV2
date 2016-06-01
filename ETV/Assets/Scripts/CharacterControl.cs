using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {
    /*public float speed = 10.0F;
    public float rotationSpeed = 100.0F;*/

    public static Animator anim;
    public GameObject btn;

    void Update()
    {
        /*float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);*/
        anim = GetComponent<Animator>();
      
    }


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Entro");
        
        anim.SetTrigger("estaManoteando");
        btn.transform.localScale = new Vector3(1, 1, 1);
        AdminPacientes.UpdateObj(8, btn);



    }

    void OnTriggerExit()
    {
        Debug.Log("Salio");
        btn.transform.localScale = new Vector3(0, 0, 0);
        anim.SetTrigger("estaMirando");

    }


    public static void salir() {

        anim.SetTrigger("estaMirando");

    }



}
