using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject playerContainer;
    public float speedZ;
    public float speedX;
    public float speedY;
    private Vector3 _movementDirection;
    [HideInInspector] public Rigidbody _rigidbody;
    private float directionHorizontal;
    private Vector3 _localVelocity;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.velocity = transform.InverseTransformDirection(_rigidbody.velocity);
    }

    void Update()
    {
        PlayerContainerMove();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerContainerMove()
    {
        playerContainer.transform.Translate(playerContainer.transform.forward * (speedZ * Time.deltaTime), Space.World);
    }
    
    private void PlayerMove()
    {
        _rigidbody.velocity = (transform.right * (Input.GetAxis("Horizontal") * speedX) + transform.up * speedY) * Time.deltaTime ;
    }
}