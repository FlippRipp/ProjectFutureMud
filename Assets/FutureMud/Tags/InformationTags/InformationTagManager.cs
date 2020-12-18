using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InformationTagManager
{
    public static string GetInformation(string tagName)
    {
        switch (tagName)
        {
            case "playerName":
                return "Filip";
            case "age":
                return "30";
            default:
                return "{Missing Information}";
            
        }
    }
}
