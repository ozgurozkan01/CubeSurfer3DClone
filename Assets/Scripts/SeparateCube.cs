using UnityEngine;

public class SeparateCube : MonoBehaviour
{
    [SerializeField] private CharacterAnimationController characterAnimCont;
    
    private void Start()
    {
        characterAnimCont = FindObjectOfType<CharacterAnimationController>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectedCube"))
        {
            characterAnimCont.isBouncy = true;
            CubeCollector.yPos -= 1.03f;
            other.gameObject.transform.SetParent(null);
        }
    }
}
