using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSize : MonoBehaviour
{
    public GameObject canvas;
    public float height;
    public float width;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        RectTransform objectRectTransform = gameObject.GetComponent<RectTransform>();
        height = objectRectTransform.rect.height;
        width = objectRectTransform.rect.width;
        position = objectRectTransform.rect.position;
        
        Debug.Log("height = " + height);
        Debug.Log("width = " + width);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
