using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMoving : MonoBehaviour
{
    public const float speed = 0.01f;
    private GameObject camera;
    private int childIndexForMove = 0;
    private int lastChildIndex = 0;
    private float height = 0;
    
    void Start()
    {
        camera = GameObject.Find("Main Camera");
        lastChildIndex = transform.childCount - 1;
        height = gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().bounds.size.z;
    }

    // Update is called once per frame
    void Update()
    {
        move(gameObject);

        Transform childFormMoveTransform = gameObject.transform.GetChild(childIndexForMove);

        if (childFormMoveTransform.position.z < camera.transform.position.z - 2)
        {
            childFormMoveTransform.position = new Vector3(
                childFormMoveTransform.position.x, 
                childFormMoveTransform.position.y, 
                gameObject.transform.GetChild(lastChildIndex).transform.position.z + height);
            lastChildIndex++;
            childIndexForMove++;
            lastChildIndex = lastChildIndex % transform.childCount; 
            childIndexForMove = childIndexForMove % transform.childCount;
        }
    }

  

    void move(GameObject gameObject)
    {
        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x,
            gameObject.transform.position.y,
            gameObject.transform.position.z - speed);
    }
}