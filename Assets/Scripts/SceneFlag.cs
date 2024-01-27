using UnityEngine;

public class SceneFlag : MonoBehaviour
{
    private static SceneFlag instance;

    private bool doorChecked;
    private bool noteChecked;
    private bool itemsCollected;

    public static SceneFlag Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject sceneFlagObject = new GameObject("SceneFlag");
                instance = sceneFlagObject.AddComponent<SceneFlag>();
            }
            return instance;
        }
    }

    public bool DoorChecked
    {
        get { return doorChecked; }
        set { doorChecked = value; }
    }

    public bool NoteChecked
    {
        get { return noteChecked; }
        set { noteChecked = value; }
    }

    public bool ItemsCollected
    {
        get { return itemsCollected; }
        set { itemsCollected = value; }
    }



}