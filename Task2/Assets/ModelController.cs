using UnityEngine;

public class ModelController : MonoBehaviour
{
    public GameObject model;
    private SaveManager saveManager;

    void Start()
    {
        Debug.Log("For save/load object use R(save) and T(load)");
        saveManager = gameObject.AddComponent<SaveManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            saveManager.SaveModel(model);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            saveManager.LoadModel(model);
        }
    }
}
