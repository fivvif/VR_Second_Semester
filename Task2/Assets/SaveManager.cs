using UnityEngine;
using System.IO;

[System.Serializable]
public class ModelData
{
    public float posX;
    public float posY;
    public float posZ;

    public ModelData(Vector3 position)
    {
        posX = position.x;
        posY = position.y;
        posZ = position.z;
    }

    public Vector3 ToVector3()
    {
        return new Vector3(posX, posY, posZ);
    }
}


public class SaveManager : MonoBehaviour
{
    private string filePath;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "modelData.json");
    }

    public void SaveModel(GameObject model)
    {
        ModelData modelData = new ModelData(model.transform.position);
        string json = JsonUtility.ToJson(modelData);
        File.WriteAllText(filePath, json);
        Debug.Log("Model saved to " + filePath);
    }

    public void LoadModel(GameObject model)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            ModelData modelData = JsonUtility.FromJson<ModelData>(json);
            model.transform.position = modelData.ToVector3();
            Debug.Log("Model loaded from " + filePath);
        }
        else
        {
            Debug.LogWarning("Save file not found at " + filePath);
        }
    }
}
