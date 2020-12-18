using System;
using System.Collections.Generic;

namespace FutureMud.Actor
{
    [Serializable]
    public class ActorTags
    {

        public static ActorTags instance;
    
        public List<string> playerTags = new List<string>();
    
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
}
