using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    [SerializeField]
    private GameObject Advert;

    public void DestroyAdvert()
    {
        Debug.Log("Button clicked");
        Destroy(Advert);
    }
    
}
