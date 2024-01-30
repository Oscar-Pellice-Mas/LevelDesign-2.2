using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionList : MonoBehaviour
{
    private static MissionList instance;

    [SerializeField]
    private List<Mission> missions = new List<Mission>();
    [SerializeField]
    private int currentMission;

    public static MissionList Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject missionListObject = new GameObject("MissionList");
                instance = missionListObject.AddComponent<MissionList>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    private void Awake()
    {
        Mission m0 = new Mission("Escape from here", "Escape through that strange organic gate.", 0);
        Mission m1 = new Mission("Escape from here (1)", "Find clues to open the door.", 1);
        Mission m2 = new Mission("Escape from here (2)", "Find: ", 2);
        Mission m3 = new Mission("Escape from here (3)", "Exit through the door.", 3);

        missions.Add(m0);
        missions.Add(m1);
        missions.Add(m2);
        missions.Add(m3);

        currentMission = 0;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void SetCurrentMissionID(int id)
    {
        if (id >= 0 && id < missions.Count)
        {
            currentMission = id;
        }
        else
        {
            Debug.LogError("Invalid mission ID: " + id);
        }
    }

    public string GetCurrentTitle()
    {

        //return missions.Capacity.ToString();
        return missions[currentMission].Title;
    }
    
    public string GetCurrentDescription()
    {
        return missions[currentMission].Description;
    }

    public int GetCurrentID()
    {
        return missions[currentMission].ID;
    }

}