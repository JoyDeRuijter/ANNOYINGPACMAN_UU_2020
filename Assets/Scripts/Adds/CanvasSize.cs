using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSize : MonoBehaviour
{
    public float height;
    public float width;
    public Vector3 position;

    
    void Start()
    {
        RectTransform objectRectTransform = gameObject.GetComponent<RectTransform>();
        height = objectRectTransform.rect.height;
        width = objectRectTransform.rect.width;
        position = objectRectTransform.rect.position;
        
        //Debug.Log("height = " + height);
        //Debug.Log("width = " + width);

    }
}
