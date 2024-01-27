using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int LeftLimit = 5;
    public int RightLimit = 5;

    public GameObject LeftDoor;
    public GameObject RightDoor;    
    
    public GameObject LeftParticle;
    public GameObject RightParticle;

    public float doorSpeed = 0.1f;

    private float leftDoorTranslationAmount = 0f;
    private float rightDoorTranslationAmount = 0f;

    void Start()
    {

    }

    void Update()
    {
        if (SceneFlag.Instance.TryToOpenDoor) {
            LeftParticle.SetActive(true);
            RightParticle.SetActive(true);
            if (leftDoorTranslationAmount <= LeftLimit)
            {
                LeftParticle.transform.Translate(Vector3.left * doorSpeed * Time.deltaTime);
                LeftDoor.transform.Translate(Vector3.left * doorSpeed * Time.deltaTime);
                leftDoorTranslationAmount += doorSpeed * Time.deltaTime;
            }

            if (rightDoorTranslationAmount <= RightLimit)
            {
                RightParticle.transform.Translate(Vector3.right * doorSpeed * Time.deltaTime);
                RightDoor.transform.Translate(Vector3.right * doorSpeed * Time.deltaTime);
                rightDoorTranslationAmount += doorSpeed * Time.deltaTime;
            }
        }

    }
}
