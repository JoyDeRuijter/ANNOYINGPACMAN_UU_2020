﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A script with the purpose of getting the height, width and position of the advertisementcanvas.
//This is necessary since our canvas scales with the maincamera (and thus the screensize) and is therefore not always the same size.
public class CanvasSize : MonoBehaviour
{
    public float height;
    public float width;
    public Vector3 position;

 //An awake method that stores the height, width and position of the canvas.   
    void Awake()
    {
        RectTransform objectRectTransform = gameObject.GetComponent<RectTransform>();
        height = objectRectTransform.rect.height;
        width = objectRectTransform.rect.width;
        position = new Vector2(0, 0);
    }
}
