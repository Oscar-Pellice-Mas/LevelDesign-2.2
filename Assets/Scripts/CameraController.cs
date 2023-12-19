using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    [SerializeField] private GameObject secondFloor;
    [SerializeField] private GameObject roof;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    private void SetRoof(bool value) { 
        roof.SetActive(value);
    }   
    
    private void SetFloor(bool value)
    {
        secondFloor.SetActive(value);
    }

    public void OnDoorCrossed()
    {
        if (secondFloor.activeSelf)
        {
            SetFloor(false);
            SetRoof(false);
        }
        else
        {
            SetRoof(true);
            SetFloor(true);
        }
    }

    public void OnStairCrossed()
    {
        if (secondFloor.activeSelf)
        {
            SetFloor(false);
            SetRoof(false);
        }
        else
        {
            SetRoof(false);
            SetFloor(true);
        }
    }
}