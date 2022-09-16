using System;
using UnityEngine;

public class WinController : MonoBehaviour
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
        if (other.gameObject.CompareTag("CollectedCube"))
        {
            CubeCollector.yPos -= 1.03f;
            other.gameObject.transform.SetParent(null);
            CubeCollector.collectedCubeAmount--;
        }
        
        else if (other.gameObject.CompareTag("ParentCube"))
        {
            characterAnimCont.DancingAnimation();
            playerMovement.speedX = 0;
            playerMovement.speedY = 0;
            playerMovement.speedZ = 0;
        }
    }
}
