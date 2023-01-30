using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class protagonist_control : MonoBehaviour 
{
    // Start is called before the first frame update
    //private carte_de_control controleur ;

    void Start()
    {        
        Debug.Log("WELCOME!");    
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTestaction(InputValue touche)
    {
        Debug.Log(touche);
    }

    public void testaction(InputAction.CallbackContext context)
    {
       Debug.Log("oooooooooo!");
    }

}
