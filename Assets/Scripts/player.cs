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
        transform.position += moveDirection * speed * Time.deltaTime;
    }

    public void setMovementDirection(Vector2 direction)
    {
        Debug.Log("Getting Input");
        moveDirection = direction;
    }

}
