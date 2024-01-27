using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventPoint : MonoBehaviour
{
    [SerializeField]
    int TriggerMission = -1;
    [SerializeField]
    int TriggerEvent = -1;

    [SerializeField]
    bool Active = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Active && other.CompareTag("Player"))
        {
            if(TriggerMission >= 0)
            {
                SetConsecuenceByMissionID();
            }
            else 
            {
                SetConsecuenceByEventID();

            }
            
        }
    }

    private void SetConsecuenceByMissionID() {
        InfoUIController infoUIController = FindObjectOfType<InfoUIController>();
        SceneFlag sceneFlag = SceneFlag.Instance;

        if (TriggerMission == 1)
        {   
            if (!sceneFlag.NoteChecked) {
                infoUIController.SetText("A strange door made of organic, seemingly resistant to force. ");
                infoUIController.SetUIActive();

                sceneFlag.DoorChecked = true;

                MissionList.Instance.SetCurrentMissionID(TriggerMission);
            }
            Active = false;
        }
        if (TriggerMission == 2)
        {
            infoUIController.SetText("An ancient manuscript, containing instructions on how to open the door.");
            infoUIController.SetUIActive();

            sceneFlag.NoteChecked = true;
            MissionList.Instance.SetCurrentMissionID(TriggerMission);
            Active = false;
        }
    }

    private void SetConsecuenceByEventID()
    {
        Inventory inventory = Inventory.Instance;
        InfoUIController infoUIController = FindObjectOfType<InfoUIController>();

        if (TriggerEvent == 0) {
            inventory.AddItem(ItemType.BATTERY);

            infoUIController.SetText("You found a battery.");
            infoUIController.SetUIActive();
            Active = false;
        }
        if (TriggerEvent == 1)
        {
            inventory.AddItem(ItemType.WIRE);

            infoUIController.SetText("You found a wire.");
            infoUIController.SetUIActive();
            Active = false;
        }

        if (TriggerEvent == 2 && SceneFlag.Instance.ItemsCollected)
        {
            infoUIController.SetText("END OF LEVEL, Thank you for playing.");
            infoUIController.SetUIActive();
            Active = false;
        }

    }



}
