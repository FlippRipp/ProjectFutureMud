using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace FutureMud.persistence
{
    public static class SaveToBinary
    {
        private static readonly string FilePath = Application.dataPath;
        
        public static void SaveToSaveFile(string fileLocation, GameState saveData)
        {
            FileStream dataStream = new FileStream(FilePath + fileLocation, FileMode.Create);
            
            BinaryFormatter converter = new BinaryFormatter();
            converter.Serialize(dataStream, saveData);

            dataStream.Close();

        }

        public static GameState LoadFromSaveFile(string fileLocation)
        {
            if(File.Exists(FilePath + fileLocation))
            {
                FileStream dataStream = new FileStream(FilePath + fileLocation, FileMode.Open);

                BinaryFormatter converter = new BinaryFormatter();
                GameState saveData = converter.Deserialize(dataStream) as GameState;

                dataStream.Close();
                return saveData;
            }
            else
            {
                Debug.LogError("No save File Found at: " + FilePath + fileLocation);
                return null;
            }
        }
    }
}