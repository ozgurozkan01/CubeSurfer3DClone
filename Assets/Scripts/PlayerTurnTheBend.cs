using UnityEngine;

public class PlayerTurnTheBend : MonoBehaviour
{
    [SerializeField] private bool _isRotatable;
    [SerializeField] private GameObject parentCube;
    [SerializeField] private PlayerMovement initialCube;
    [SerializeField] private float lerpMultiplier = 1.5f;

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
            _isRotatable = true;
        }
    }

    private void CollideObjectTurn()
    {
        parentCube.transform.localRotation = Quaternion.Slerp(parentCube.transform.rotation, Quaternion.Euler(0f, -90f, 0f), lerpMultiplier * Time.deltaTime);
    }
}
