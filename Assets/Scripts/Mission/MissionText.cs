using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionText : MonoBehaviour
{
    [SerializeField]
    Text Title;
    [SerializeField]
    Text Description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MissionList list = MissionList.Instance;

        Title.text = list.GetCurrentTitle();
        Description.text = list.GetCurrentDescription();

        if(list.GetCurrentID() == 2)
        {
            Mission2();
        }
    }

    void Mission2() {
        Inventory inventory = Inventory.Instance;

        int BatteryNum = inventory.GetCountByItem(ItemType.BATTERY);

        if (BatteryNum != 2)
        {
            Description.text += "\n- Battery x 2 (" + BatteryNum + ")";
        }
        else {
            Description.text += "\n- Battery x 2 (Complete)";
        }

        if(BatteryNum == 2)
        {
            SceneFlag.Instance.ItemsCollected = true;
            MissionList.Instance.SetCurrentMissionID(3);
        }

    }
}
