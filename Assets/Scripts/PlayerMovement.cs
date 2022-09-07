using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject playerContainer;
    [SerializeField] private float speedZ;
    [SerializeField] private float speedX;
    
    private Vector3 _movementDirection;

    private Rigidbody _rigidbody;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetMovementHorizontalInput();
    }

    private void GetMovementHorizontalInput()
    { 
        float directionHorizontal = Input.GetAxis("Horizontal");
        
        PlayerMove(directionHorizontal);
    }

    private void PlayerMove(float horizontalDir)
    {
        playerContainer.transform.Translate(transform.forward * (speedZ * Time.deltaTime));
        _rigidbody.velocity = new Vector3(horizontalDir * speedX * Time.deltaTime, 0f, 0f);
    }
}
