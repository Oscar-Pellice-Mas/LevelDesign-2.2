using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{
    public float breatheSpeed = 0.1f;
    public float rotateSpeed = 1.0f;
    public float moveSpeed = 0.5f;
    public float maxMove = 1.0f;

    void Update()
    {
        Material skyboxMaterial = RenderSettings.skybox;

        float breatheScale = Mathf.PingPong(Time.time * breatheSpeed, 1.0f) + 0.5f;
        float rotation = Mathf.Sin(Time.time * rotateSpeed) * maxMove;
        float moveOffset = Mathf.Sin(Time.time * moveSpeed) * maxMove;

        skyboxMaterial.SetFloat("_Exposure", breatheScale);
        skyboxMaterial.SetFloat("_Rotation", rotation);
        skyboxMaterial.SetFloat("_Offset", moveOffset);
    }
}
