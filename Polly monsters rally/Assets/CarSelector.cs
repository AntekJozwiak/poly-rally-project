using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public int car;
    public bool menu;
    public GameObject[] cars;

    void Start()
    {
        try
        {
            car = PlayerPrefs.GetInt("carNum");
        }

        catch
        {

        }


    }


    void Update()
    {
        if (Input.GetKeyDown("e") && menu == true)
        {
            car += 1; 
            if (car > cars.Length)
            {
                car = 0;
            }

            PlayerPrefs.SetInt("carNum", car);

        }

        GameObject childeren;
        int childerenCount = transform.childCount;
        for (int i = 0; i < childerenCount; ++i)
        {
            childeren = transform.GetChild(i).gameObject;
            if (childeren.tag != cars[car].tag)
            {
                foreach (Transform child in transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                GameObject NewCar = Instantiate(cars[car], transform.position, transform.rotation);


                NewCar.transform.parent = this.gameObject.transform;

            }
        }
    }
}
