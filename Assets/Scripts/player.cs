using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    private Vector3 moveDirection;
    [SerializeField] private float speed;

    void Start()
    {
        playerControler.Init(this);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            moveDirection = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection = Vector3.right;
        }
        else
        {
            moveDirection = Vector3.zero;
        }

        transform.position += moveDirection * speed * Time.deltaTime;
    }

    public void setMovementDirection(Vector2 direction)
    {
        Debug.Log("Getting Input");
        moveDirection = direction;
    }

}
