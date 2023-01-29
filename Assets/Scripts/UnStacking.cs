using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnStacking : MonoBehaviour
{
    public GameObject parentGameObject;
    public Transform firstChild;

    public Vector3 newPosition;
    public float verticalSpacing = 0.5f;



    void Start()
    {
        
    }

    IEnumerator MoveChildren()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            yield return new WaitForSeconds(0.1f);
            Vector3 childPosition = newPosition;
            childPosition.y += i * verticalSpacing;
            transform.GetChild(i).transform.position = childPosition;
        }
    }
            void Update()
    {

        if (Input.GetKey(KeyCode.F))
        {
            StartCoroutine(MoveChildren());


            //firstChild.transform.position = new Vector3(-0.5f, 1.3f, -4.2f);
        }
    }
}
