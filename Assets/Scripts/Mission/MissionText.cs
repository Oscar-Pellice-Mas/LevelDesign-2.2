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

        int WiresNum = inventory.GetCountByItem(ItemType.WIRE);
        int BatteryNum = inventory.GetCountByItem(ItemType.BATTERY);

        if (BatteryNum != 1)
        {
            Description.text += "\n- Battery x 1 (" + BatteryNum + ")";
        }
        else {
            Description.text += "\n- Battery x 1 (Complete)";
        }

        if (WiresNum != 3)
        {
            Description.text += "\n- Wires x 3 (" + WiresNum + ")";
        }
        else
        {
            Description.text += "\n- Wires x 3 (Complete)";
        }

        if(WiresNum == 3 && BatteryNum == 1)
        {
            SceneFlag.Instance.ItemsCollected = true;
            MissionList.Instance.SetCurrentMissionID(3);

        }

    }
}
