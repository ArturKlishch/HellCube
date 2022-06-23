using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class menu : MonoBehaviour
{
 public void play(int numberScenes)
    {
            SceneManager.LoadScene(numberScenes); 
    }
    public GameObject settingsExit;
    public GameObject Menui;
    public GameObject settings;
    public GameObject Menu;
    public GameObject level;
    public GameObject LevelExit;



    public void Level()
    {
        Menu.SetActive(false);
        level.SetActive(true);
    }
    public void Levelexit()
    {   
        Menu.SetActive(true);
        level.SetActive(false);
    }
    public void Settings()
    {
        Menu.SetActive(false);
        settings.SetActive(true);
    }
    public void SettingsExit()
    {
        Menu.SetActive(true);
        settings.SetActive(false);
    }


    internal static void SetActive(bool v)
    {
        throw new NotImplementedException();
    }

    public void exit()
    {
        Application.Quit();
    }
    public Dropdown resolutionDropdown;
    public Dropdown qualityDropdown;

    Resolution[] resolutions;

    void Start()
    {
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " " + resolutions[i].refreshRate + "Hz";
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
                currentResolutionIndex = i;
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.RefreshShownValue();
        LoadSettings(currentResolutionIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void ExitSettings()
    {
        SceneManager.LoadScene("Respawn");
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QualitySettingPreference", qualityDropdown.value);
        PlayerPrefs.SetInt("ResolutionPreference", resolutionDropdown.value);
        PlayerPrefs.SetInt("FullscreenPreference", System.Convert.ToInt32(Screen.fullScreen));
    }

    public void LoadSettings(int currentResolutionIndex)
    {
        if (PlayerPrefs.HasKey("QualitySettingPreference"))
            qualityDropdown.value = PlayerPrefs.GetInt("QualitySettingPreference");
        else
            qualityDropdown.value = 3;

        if (PlayerPrefs.HasKey("ResolutionPreference"))
            resolutionDropdown.value = PlayerPrefs.GetInt("ResolutionPreference");
        else
            resolutionDropdown.value = currentResolutionIndex;

        if (PlayerPrefs.HasKey("FullscreenPreference"))
            Screen.fullScreen = System.Convert.ToBoolean(PlayerPrefs.GetInt("FullscreenPreference"));
        else
            Screen.fullScreen = true;
    }

    public Dropdown Dropdown;

    public void Change()
    {
        if (Dropdown.value == 0)
        {
            Screen.SetResolution(2560, 1440, true);
        }
        else if (Dropdown.value == 1)
        {

            Screen.SetResolution(1920, 1080, true);
        }
        else if (Dropdown.value == 2)
        {
            Screen.SetResolution(1366, 768, true);
        }
        else if (Dropdown.value == 3)
        {
            Screen.SetResolution(1024, 768, true);
        }
    }
}
