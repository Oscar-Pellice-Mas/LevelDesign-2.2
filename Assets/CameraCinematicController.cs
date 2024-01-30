using System.Collections;
using UnityEngine;
using Cinemachine;
using UnityEngine.Rendering;

public class CameraCinematicController : MonoBehaviour
{
    [SerializeField] private GameObject cameraGO1;
    [SerializeField] private GameObject cameraGO2;
    [SerializeField] private GameObject cameraGO3;
    [SerializeField] private GameObject cameraGO4;

    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;
    [SerializeField] private CinemachineVirtualCamera camera3;
    [SerializeField] private CinemachineVirtualCamera camera4;
    [SerializeField] private CinemachineVirtualCamera camera5;

    [SerializeField] private CinemachineDollyCart cart1;
    [SerializeField] private CinemachineDollyCart cart2;
    [SerializeField] private CinemachineDollyCart cart3;
    [SerializeField] private CinemachineDollyCart cart4;

    [SerializeField] private float switchInterval1 = 1f;
    [SerializeField] private float switchInterval2 = 3f;
    [SerializeField] private float switchInterval3 = 2f;
    [SerializeField] private float switchInterval4 = 5f;

    public CinemachineBrain brain;

    void Start()
    {
        cameraGO1.SetActive(true);
        cameraGO2.SetActive(false);
        cameraGO3.SetActive(false);
        cameraGO4.SetActive(false);

        // Set initial camera priority
        camera1.Priority = 20;
        camera2.Priority = 19;
        camera3.Priority = 18;
        camera4.Priority = 17;
        camera5.Priority = 10;

        cart1.m_Speed = 0;
        cart2.m_Speed = 0;
        cart3.m_Speed = 0;
        cart4.m_Speed = 0;

        // Start the camera switch sequence
        StartCoroutine(SwitchCamerasSequence());
    }

    private IEnumerator SwitchCamerasSequence()
    {
        cart1.m_Speed = 5;
        yield return new WaitForSeconds(switchInterval1);
        camera1.Priority = 0;

        cameraGO2.SetActive(true);
        cart2.m_Speed = 5;
        yield return new WaitForSeconds(switchInterval2);
        camera2.Priority = 0;

        cameraGO3.SetActive(true);
        cart3.m_Speed = 5;
        yield return new WaitForSeconds(switchInterval3);
        camera3.Priority = 0;

        cameraGO4.SetActive(true);
        cart4.m_Speed = 5;
        yield return new WaitForSeconds(switchInterval4);
        brain.m_DefaultBlend.m_Style = CinemachineBlendDefinition.Style.EaseOut;
        camera4.Priority = 0;
    }
}
