using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextParser : MonoBehaviour
{

    [SerializeField]
    private TextAsset textFile;
    private void Start()
    {
        ParseText(textFile.text);
    }

    public string ParseText(string text)
    {
        string newText = text;
        List<string> logicCommands = new List<string>();
        for(int i = 0; i < text.Length; i++)
        {
            if (text[i] == '{')
            {
                string command = "";
                int j = i + 1;
                char character = text[i];
                while (character != '}')
                {
                    command += character;
                    character = text[j];
                    j++;
                }

                string information = command.Substring(1, command.Length - 1);
                
                command += character;
                newText = newText.Replace(command, InformationTagManager.
                    GetInformation(information));

                i = j;
            }
            else if (text[i] == '[')
            {
                int scope = -1;
                string command = "";
                int j = i + 1;
                char character = text[i];
                while (character != ']' || scope != 0)
                {
                    if (character == '[') scope++;
                    else if (character == ']') scope--;
                    
                    command += character;
                    character = text[j];
                    j++;
                }
                command += character;
                string logic = LogicTagManager.ExecuteLogic(command.Substring(1, command.Length - 2));
                newText = newText.Replace(command, logic);
                i = j;
            }
        }
        
        Debug.Log(newText);
        return null;
    }
    
    
}