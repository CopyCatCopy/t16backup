using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicStay : MonoBehaviour
{
    public List<string> sceneNames;

    public string instanceName;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        CheckForDuplicateInstances();

        CheckIfSceneInList();
    }

    void CheckForDuplicateInstances()
    {
        MusicStay[] collection = FindObjectsOfType<MusicStay>();

        foreach (MusicStay obj in collection)
        {
            if (obj != this) 
            {
                if (obj.instanceName == instanceName)
                {
                    //nothin ahaaaa
                }
            }
        }
    }

    void CheckIfSceneInList()
    {
        
        string currentScene = SceneManager.GetActiveScene().name;

        if (sceneNames.Contains(currentScene))
        {
            //nothin ahaaaa
        }
        else
        {
            
            SceneManager.sceneLoaded -= OnSceneLoaded;
            DestroyImmediate(this.gameObject);
        }
    }
}