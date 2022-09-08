using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    /*[SerializeField] private Transform playerContainer;
    [SerializeField] private float lerpMultiplier;
    private Vector3 _offset;
    private bool _cameraPositionController = true;
    
    void Start()
    {
        _offset = transform.position - playerContainer.transform.position;
    }
    
    void LateUpdate()
    {
        CameraMovement();
        CameraOffsetUpdate();
    }

    private void CameraMovement()
    {
        transform.position =
            Vector3.Lerp(transform.position, playerContainer.position + _offset, lerpMultiplier * Time.deltaTime);
        transform.LookAt(playerContainer);
    }

    private void CameraOffsetUpdate()
    {
        if (CubeCollector.collectedCubeAmount == 5 && _cameraPositionController)
        {
            _offset += new Vector3(1f, 2f, -2f);
            _cameraPositionController = false;
        }
    }*/
}
