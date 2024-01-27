using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission
{
    public string Title;
    public string Description;
    public int ID;

    public Mission(string title, string description, int id) {
        Title = title;
        Description = description;
        ID = id;
    }
}
