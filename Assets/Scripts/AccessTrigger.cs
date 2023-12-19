using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessTrigger : MonoBehaviour
{
    [SerializeField] private string name = "";
    void OnTriggerEnter(Collider other)
    {
        if (name == "Door")        CameraController.instance.OnDoorCrossed();
        else if (name == "Stair")  CameraController.instance.OnStairCrossed();
    }
}
