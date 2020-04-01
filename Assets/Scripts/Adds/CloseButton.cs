using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A script with the purpose of destroying an advertisement if its closebutton is clicked on. 
public class CloseButton : MonoBehaviour
{
    [SerializeField]
    private GameObject Advert;

 //A method that destroys the connected advertisement object.
    public void DestroyAdvert()
    {
        Destroy(Advert);
    }
    
}
