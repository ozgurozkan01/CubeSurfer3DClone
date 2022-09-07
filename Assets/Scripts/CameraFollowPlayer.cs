using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerContainer;
    [SerializeField] private float lerpMultiplier;
    private Vector3 _offset;
    
    void Start()
    {
        _offset = transform.position - playerContainer.transform.position;
    }
    
    void LateUpdate()
    {
        transform.position =
            Vector3.Lerp(transform.position, playerContainer.position + _offset, lerpMultiplier * Time.deltaTime);
    }
}
