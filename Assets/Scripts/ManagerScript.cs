using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

    public static int length;
    public GameObject[] childObjects = new GameObject[length];

    void Start()
    {

    }

    void Update()
    {
        for(int i = 0; i < length; i++)
        {
            if(!childObjects[i].activeInHierarchy)
            {
                switch(i)
                {
                    case 0:
                        Debug.Log(childObjects[i].name + " selected");
                        break;
                    case 1:
                        Debug.Log(childObjects[i].name + " selected");
                        break;
                    case 2:
                        Debug.Log(childObjects[i].name + " selected");
                        break;
                }
            }
        }
    }
}


