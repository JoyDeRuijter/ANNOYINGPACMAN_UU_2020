using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSize : MonoBehaviour
{
    public float height;
    public float width;
    public Vector3 position;

    
    void Awake()
    {
        RectTransform objectRectTransform = gameObject.GetComponent<RectTransform>();
        height = objectRectTransform.rect.height;
        width = objectRectTransform.rect.width;
        position = new Vector2(0, 0);
    }
}
