using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject playerContainer;
    public float speedZ;
    public float speedX;
    public float speedY;
    private Vector3 _movementDirection;
    private Rigidbody _rigidbody;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

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
        playerContainer.transform.Translate(playerContainer.transform.forward * (speedZ * Time.deltaTime), Space.World);
        _rigidbody.velocity = new Vector3(horizontalDir * speedX * Time.deltaTime, -speedY * Time.deltaTime, 0f);
    }
}
