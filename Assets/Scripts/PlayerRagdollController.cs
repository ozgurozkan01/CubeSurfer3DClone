using UnityEngine;

public class PlayerRagdollController : MonoBehaviour
{
    /*[SerializeField] private Collider mainCollider;
    [SerializeField] private Rigidbody mainRigidbody;
    private Collider[] _colliders;
    private Rigidbody[] _rigidbodies;
    [SerializeField] private Animator animator;

    private void Start()
    {
        _colliders = GetComponentsInChildren<Collider>();
        _rigidbodies = GetComponentsInChildren<Rigidbody>();
        RagdollController(false);
    }
    
    public void RagdollController(bool isRagdoll)
    {
        foreach (var col in _colliders)
        {
            col.enabled = isRagdoll;
        }

        foreach (var rb in _rigidbodies)
        {
            rb.isKinematic = !isRagdoll;
        }

        animator.enabled = !isRagdoll;
        mainCollider.enabled = !isRagdoll;
        mainRigidbody.isKinematic = isRagdoll;
    }*/
}
