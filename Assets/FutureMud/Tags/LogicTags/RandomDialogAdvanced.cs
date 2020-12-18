using System;
using Random = UnityEngine.Random;

[Serializable]
public class RandomDialogAdvanced
{
    public string[] dialogs;
    public float[] dialogWeights;

    private float weightsSum;

    public RandomDialogAdvanced(string[] dialogs, float[] dialogWeights)
    {
        this.dialogs = dialogs;
        this.dialogWeights = dialogWeights;
    }
    
    public string GetRandomDialog()
    {
        for (int i = 0; i < dialogWeights.Length; i++)
        {
            weightsSum += dialogWeights[i];
            dialogWeights[i] = weightsSum;
        }

        float random = Random.Range(0f, 1f) * weightsSum;

        for (int i = 0; i < dialogWeights.Length; i++)
        {
            if (dialogWeights[i] >= random)
            {
                return dialogs[i];
            }
        }

        return "";
    }
}