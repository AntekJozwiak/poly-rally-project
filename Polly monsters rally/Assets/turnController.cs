using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turnController : MonoBehaviour
{
    public Image image;
    public string turnName;
    public Sprite[] turnImages;

    void Start()
    {
        
    }

    void Update()
    {
        foreach (Sprite I in turnImages)
        {
            if (turnName != I.name)
            {
                foreach (Sprite i in turnImages)
                {
                    if (turnName == i.name)
                    {
                        image.sprite = i;
                    }
                }
            }
        }
    }
}
