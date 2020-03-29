using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvertSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject adv0, adv1, adv2, adv3, adv4, adv5, adv6, adv7, adv8, adv9, adv10;

    public float leftBorder;
    public float rightBorder;
    public float topBorder;
    public float botBorder;

    Vector2 advertPosition;



    CanvasSize canvasSize;
    
    Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAdvert()
    {

        int randomAdvert = Random.Range(0, 10);


        switch (randomAdvert)
        {
            case 0:
                GameObject adv0clone = Instantiate(adv0, position, Quaternion.identity);
                break;
           


        }

    }

   private Vector2 AdvertPosition(int ID)
    {
        leftBorder = canvasSize.position.x - (canvasSize.width / 2);
        rightBorder = canvasSize.position.x + (canvasSize.width / 2);
        topBorder = canvasSize.position.y + (canvasSize.height / 2);
        botBorder = canvasSize.position.y - (canvasSize.height / 2);

        float xPosition = Random.Range(leftBorder, rightBorder - 50);
        float yPosition = Random.Range(botBorder, topBorder);

        advertPosition.x = xPosition;
        advertPosition.y = yPosition;

        return advertPosition;
    }
 
}
