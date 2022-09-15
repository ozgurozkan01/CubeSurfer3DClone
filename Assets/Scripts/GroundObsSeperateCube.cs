using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundObsSeperateCube : MonoBehaviour
{
    [SerializeField] private CharacterAnimationController characterAnimCont;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject playerContainer;
    
    private void Start()
    {
        _playerMovement = FindObjectOfType<PlayerMovement>();
        characterAnimCont = FindObjectOfType<CharacterAnimationController>();

        character = GetComponent<GameObject>();
        character = GameObject.Find("Character");
        
        playerContainer = GetComponent<GameObject>();
        playerContainer = GameObject.Find("PlayerContainer");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectedCube"))
        {
            characterAnimCont.isBouncy = true;
            CubeCollector.yPos -= 1.03f;
            other.gameObject.transform.SetParent(null);
            CubeCollector.collectedCubeAmount--; 
        }
        
        // Game Over
        else if (other.gameObject.CompareTag("ParentCube"))
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
            character.transform.SetParent(playerContainer.transform);
            character.GetComponent<PlayerRagdollController>().RagdollController(true);
            _playerMovement.speedX = 0;
            _playerMovement.speedY = 0;
            _playerMovement.speedZ = 0;
            Destroy(other.gameObject);
        }
    }
}
