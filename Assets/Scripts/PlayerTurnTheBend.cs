using System;
using UnityEngine;

public class PlayerTurnTheBend : MonoBehaviour
{
    /*[SerializeField] private float lerpMultiplier = 2f;
    [SerializeField] private bool _isRotatable;
    private GameObject _collideObject;

    private void Update()
    {
        if (_isRotatable)
        {
            CollideObjectTurn();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectedCube") || other.gameObject.CompareTag("ParentCube"))
        {
            _collideObject = other.gameObject;
            _isRotatable = true;
        }
    }

    private void CollideObjectTurn()
    {
        if (_collideObject.transform.rotation != Quaternion.Euler(0f, 90f, 0f))
        {
            _collideObject.transform.rotation = Quaternion.Slerp(_collideObject.transform.rotation, Quaternion.Euler(0f, -90f, 0f), lerpMultiplier * Time.deltaTime );
        }

        else
        {
            _isRotatable = false;
        }
    }*/
}
