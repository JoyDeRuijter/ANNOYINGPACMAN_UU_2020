using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AdvertSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject adv0, adv1, adv2, adv3, adv4, adv5, adv6, adv7, adv8, adv9, adv10;
    [SerializeField]
    private GameObject canvas;

    [SerializeField] 
    private Transform advertCanvas;
    
    public float leftBorder;
    public float rightBorder;
    public float topBorder;
    public float botBorder;

    
    //CanvasSize canvasSize;
    //AdvertSize advertSize;
    
    //Vector2 position;
    Vector2 advertPosition;

    private void Start()
    {
        CanvasSize canvasSize = canvas.GetComponent<CanvasSize>();
        
        leftBorder = canvasSize.position.x - (canvasSize.width / 2);
        rightBorder = canvasSize.position.x + (canvasSize.width / 2);
        topBorder = canvasSize.position.y + (canvasSize.height / 2);
        botBorder = canvasSize.position.y - (canvasSize.height / 2);
    }


    public void SpawnAdvert()
    {

        int randomAdvert = Random.Range(0, 1);


        switch (randomAdvert)
        {
            case 0:
                GameObject adv0clone = Instantiate(adv0, AdvertPosition(0), Quaternion.identity);
                adv0clone.transform.SetParent(advertCanvas, false);
                //adv0clone.transform.parent = canvas.transform;
                break;
            case 1:
                GameObject adv1clone = Instantiate(adv1, AdvertPosition(1), Quaternion.identity);
                adv1clone.transform.SetParent(advertCanvas, false);
                //adv1clone.transform.parent = canvas.transform;
                break;
            case 2:
                GameObject adv2clone = Instantiate(adv2, AdvertPosition(2), Quaternion.identity);
                adv2clone.transform.parent = canvas.transform.parent;
                break;
            case 3:
                GameObject adv3clone = Instantiate(adv3, AdvertPosition(3), Quaternion.identity);
                adv3clone.transform.parent = canvas.transform.parent;
                break;
            case 4:
                GameObject adv4clone = Instantiate(adv4, AdvertPosition(4), Quaternion.identity);
                adv4clone.transform.parent = canvas.transform.parent;
                break;
            case 5:
                GameObject adv5clone = Instantiate(adv0, AdvertPosition(5), Quaternion.identity);
                adv5clone.transform.parent = canvas.transform.parent;
                break;
            case 6:
                GameObject adv6clone = Instantiate(adv6, AdvertPosition(6), Quaternion.identity);
                adv6clone.transform.parent = canvas.transform.parent;
                break;
            case 7:
                GameObject adv7clone = Instantiate(adv7, AdvertPosition(7), Quaternion.identity);
                adv7clone.transform.parent = canvas.transform.parent;
                break;
            case 8:
                GameObject adv8clone = Instantiate(adv8, AdvertPosition(8), Quaternion.identity);
                adv8clone.transform.parent = canvas.transform.parent;
                break;
            case 9:
                GameObject adv9clone = Instantiate(adv9, AdvertPosition(9), Quaternion.identity);
                adv9clone.transform.parent = canvas.transform.parent;
                break;
            case 10:
                GameObject adv10clone = Instantiate(adv10, AdvertPosition(10), Quaternion.identity);
                adv10clone.transform.parent = canvas.transform.parent;
                break;
           


        }

    }

   private Vector2 AdvertPosition(int ID)
    {
        //Vector2 advertPosition;
        //float xPosition, yPosition;

        switch (ID)
        {
            case 0: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv0.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv0.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 1: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv1.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv1.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 2: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv2.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv2.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 3: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv3.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv3.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 4: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv4.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv4.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 5: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv5.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv5.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 6: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv6.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv6.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 7: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv7.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv7.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 8: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv8.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv8.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 9: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv9.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv9.GetComponent<AdvertSize>().height, topBorder);
                break;
            case 10: 
                advertPosition.x = Random.Range(leftBorder, rightBorder - adv10.GetComponent<AdvertSize>().width); 
                advertPosition.y = Random.Range(botBorder + adv10.GetComponent<AdvertSize>().height, topBorder);
                break;
            default:
                break;

        }

        //advertPosition.x = xPosition;
        //advertPosition.y = yPosition;

        return advertPosition;
    }
 
}
