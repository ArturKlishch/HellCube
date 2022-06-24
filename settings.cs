using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setting : MonoBehaviour
{
    public GameObject level;
    public GameObject settings;
    public void Settings()
    {
        settings.SetActive(true);
    }
    public void ExitSet()
    {
        settings.SetActive(false);
    }
    public void Level()
    {
        level.SetActive(true);
    }
    public void ExitLevel()
    {
        level.SetActive(false);
    }
}
