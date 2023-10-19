using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class playerControler : MonoBehaviour
{

    private static Controls _controls;


    public static void Init(player mainPlayer)
    {

        _controls = new Controls();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        /*
        _controls.Game.Movement.performed += ctx =>
        {
            mainPlayer.setMovementDirection(ctx.ReadValue<Vector3>());

        };//end Movement
        */
       
        _controls.Game.Right.performed += ctx =>
        {
            Debug.Log("Right");
            Vector3 right = new Vector3(1, 0, 0);
            mainPlayer.setMovementDirection(right);

        };//end Right

        _controls.Game.Left.performed += ctx =>
        {
            Debug.Log("Left");
            Vector3 left = new Vector3(-1, 0, 0);
            mainPlayer.setMovementDirection(left);

        };//end Left
        
    }//end Init

}
