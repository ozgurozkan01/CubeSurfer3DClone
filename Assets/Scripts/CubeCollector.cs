using UnityEngine;

public class CubeCollector : MonoBehaviour
{
    /*private GameObject _parentObject;
    public static float yPos = 1.03f;
    public static int collectedCubeAmount;
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
            other.gameObject.AddComponent<CubeCollector>();
            _parentObject.transform.position = new Vector3(_parentObject.transform.position.x,
                _parentObject.transform.position.y + 0.721f, _parentObject.transform.position.z);
            other.gameObject.transform.SetParent(_parentObject.transform);
            other.transform.localPosition = new Vector3(0f, -yPos, 0f);
            yPos += 1.03f;
            collectedCubeAmount++;
        }
    }*/
}
