using System.Collections.Generic;
using UnityEngine;

public class ActorTags : MonoBehaviour
{

    public static ActorTags instance;
    
    public List<string> playerTags = new List<string>();

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void LoadTags()
    {
        
    }

    public void SaveTags()
    {
        
    }

    public void AddTag(string tagName)
    {
        if (!playerTags.Contains(tagName))
        {
            playerTags.Add(tagName);
        }
    }

    public void RemoveTag(string tagName)
    {
        if (playerTags.Contains(tagName))
        {
            playerTags.Remove(tagName);
        }
    }

    public bool CheckForTag(string tagName)
    {
        return playerTags.Contains(tagName);
    }
}
