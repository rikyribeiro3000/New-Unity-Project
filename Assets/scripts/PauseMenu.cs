using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public static bool GameIsPaused = false;
    Resolution[] resolutions;
    public GameObject vidas;
    public GameObject perguntas;
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public Dropdown resolutionDropdown;
    public GameObject pauseMenuUI;
    public GameObject death;

    // Update is called once per frame
    void Update () {
        volumeSlider.value = AudioListener.volume;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                vidas.SetActive(true);
                perguntas.SetActive(true);
                Resume();
            } else
            {
                vidas.SetActive(false);
                perguntas.SetActive(false);
                Pause();
            }
        }
		
	}
    private void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void Sethitboxoff(bool isoff)
    {
        if (isoff == true)
        {
            death.SetActive(true);
        }
        else
        {
            death.SetActive(false);
        }
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume( float volume)
    {
        AudioListener.volume = volumeSlider.value;
    }
    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

