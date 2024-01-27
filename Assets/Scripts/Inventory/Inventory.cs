using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private static Inventory instance;
    public List<ItemType> Inventoy = new List<ItemType>();

    public static Inventory Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject inventoryObject = new GameObject("InventorySingleton");
                instance = inventoryObject.AddComponent<Inventory>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void AddItem(ItemType item) {
        Inventoy.Add(item);
    }

    public int GetCountByItem(ItemType item)
    {
        List<ItemType> matchingItems = Inventoy.FindAll(i => i == item);

        return matchingItems.Count;
    }
}
