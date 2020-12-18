using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LogicTagManager
{
    public static string ExecuteLogic(string tagName)
    {
        string[] command = tagName.Split('\'');
        
        Debug.Log(command[2]);
        

        switch (command[1])
        {
            case "RandomDialogAdvanced":
                RandomDialogAdvanced random = JsonUtility.FromJson(command[2],
                    typeof(RandomDialogAdvanced)) as RandomDialogAdvanced;
                return random?.GetRandomDialog();
                return "Filip";
            case "age":
                return "30";
            default:
                return "{Missing Information}";
        }
    }
}
