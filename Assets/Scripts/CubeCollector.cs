using UnityEngine;

public class CubeCollector : MonoBehaviour
{
    /*private GameObject _parentObject;
    public static float yPos = 1.03f;
    public static int collectedCubeAmount = 1;
    [SerializeField] private CharacterAnimationController characterAnimCont;
    
    private void Start()
    {
        characterAnimCont = FindObjectOfType<CharacterAnimationController>();
        _parentObject = GetComponent<GameObject>();
        _parentObject = GameObject.Find("InitialCube");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CollectableCube"))
        {
            characterAnimCont.isBouncy = true;
            other.gameObject.tag = "CollectedCube";
            other.gameObject.GetComponent<Collider>().isTrigger = false;
            _parentObject.transform.position = new Vector3(_parentObject.transform.position.x,
                _parentObject.transform.position.y + 0.721f, _parentObject.transform.position.z);
            other.gameObject.transform.SetParent(_parentObject.transform);
            other.transform.localPosition = new Vector3(0f, -yPos, 0f);
            yPos += 1.03f;
            collectedCubeAmount++;
        }
        
        else if (other.gameObject.CompareTag("DoubleCollectableCube"))
        {
            characterAnimCont.isBouncy = true;
            other.gameObject.GetComponent<Collider>().enabled = false;
            _parentObject.transform.position = new Vector3(_parentObject.transform.position.x,
                _parentObject.transform.position.y + 1.442f, _parentObject.transform.position.z);
            
            GameObject childObject1 = other.gameObject.transform.GetChild(0).gameObject;
            GameObject childObject2 = other.gameObject.transform.GetChild(1).gameObject;
            
            childObject1.transform.SetParent(_parentObject.transform);
            childObject2.transform.SetParent(_parentObject.transform);
            
            childObject1.transform.localPosition = new Vector3(0f, -yPos, 0f);
            childObject2.transform.localPosition = new Vector3(0f, -(yPos + 1.03f), 0f);
            
            yPos += 2.06f;
            collectedCubeAmount += 2;
        }
    }*/
}
