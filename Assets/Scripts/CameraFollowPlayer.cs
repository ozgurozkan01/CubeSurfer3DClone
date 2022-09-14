using System;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    /*[SerializeField] private Transform initialCube;
    [SerializeField] private Transform ground;
    private Vector3 offsetInitCube;
    private Vector3 offsetGround;
    [SerializeField] private float lerpMultiplier;
    [SerializeField] private Transform firstPosition;
    [SerializeField] private Transform secondPosition;
    [SerializeField] private Transform thirdPosition;
    [SerializeField] private Transform fourthPosition;

    private void Start()
    {
        offsetInitCube = transform.position - initialCube.position;
    }

    private void Update()
    {
        offsetGround = initialCube.position - ground.position;
    }

    void LateUpdate()
    {
        CameraPosYUpdate();
        CameraPosZUpdate();
    }

    private void CameraPosYUpdate()
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, transform.position.z),
            new Vector3(transform.position.x, initialCube.position.y + (offsetInitCube.y / 2), transform.position.z), lerpMultiplier * Time.deltaTime);
    }

    private void CameraPosZUpdate()
    {
        if (CubeCollector.collectedCubeAmount <= 4)
        {
            if (Vector3.Distance(transform.position, firstPosition.position) > 0)
            {
                transform.position = Vector3.Lerp(transform.position, firstPosition.position, lerpMultiplier * Time.deltaTime);
            }
        }
        
        else if (CubeCollector.collectedCubeAmount > 4 && CubeCollector.collectedCubeAmount <= 8)
        {
            if (Vector3.Distance(transform.position, secondPosition.position) > 0)
            {
                transform.position = Vector3.Lerp(transform.position, secondPosition.position, lerpMultiplier * Time.deltaTime);
            }
        }
            
        else if (CubeCollector.collectedCubeAmount > 8 && CubeCollector.collectedCubeAmount <= 12)
        {
            if (Vector3.Distance(transform.position, thirdPosition.position) > 0)
            {
                transform.position = Vector3.Lerp(transform.position, thirdPosition.position, lerpMultiplier * Time.deltaTime);
            }
        }
        
        else if (CubeCollector.collectedCubeAmount > 12)
        {
            if (Vector3.Distance(transform.position, fourthPosition.position) > 0)
            {
                transform.position = Vector3.Lerp(transform.position, fourthPosition.position, lerpMultiplier * Time.deltaTime);
            }
        }
    }*/
}
