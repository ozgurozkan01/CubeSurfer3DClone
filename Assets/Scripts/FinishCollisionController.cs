using UnityEngine;

public class FinishCollisionController : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private CharacterAnimationController characterAnimCont;
    
    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerMovement = FindObjectOfType<PlayerMovement>();

        characterAnimCont = GetComponent<CharacterAnimationController>();
        characterAnimCont = FindObjectOfType<CharacterAnimationController>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectedCube") || other.gameObject.CompareTag("ParentCube"))
        {
            characterAnimCont.DancingAnimation();
            playerMovement.speedX = 0;
            playerMovement.speedY = 0;
            playerMovement.speedZ = 0;
        }
    }
}
