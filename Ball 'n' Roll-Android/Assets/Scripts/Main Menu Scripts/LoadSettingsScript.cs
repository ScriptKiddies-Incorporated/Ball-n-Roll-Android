using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class LoadSettingsScript : MonoBehaviour
{
	// Start is called before the first frame update
	public static int resHeight;
	public static int resWidth;

	private void Awake()
	{
		if (!Permission.HasUserAuthorizedPermission("android.permission.WRITE_EXTERNAL_STORAGE"))
		{
			Permission.RequestUserPermission("android.permission.WRITE_EXTERNAL_STORAGE");
			if (!Permission.HasUserAuthorizedPermission("android.permission.WRITE_EXTERNAL_STORAGE"))
			{
				Application.Quit();
			}
		}
		
	}
	void Start()
    {
		//ChangeSettings.SetQuality(PlayerPrefs.GetInt(ChangeSettings.qualityKey));
		//ChangeSettings.SetVolume(PlayerPrefs.GetFloat("volume"));
		//ChangeSettings.SetFullScreen(System.Convert.ToBoolean(PlayerPrefs.GetInt("fullscreen")));
		resHeight = Display.main.systemHeight;
	    resWidth = Display.main.systemWidth;
		Screen.SetResolution(1920, 1080, true, 60);
		Screen.fullScreen = true;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
	/*void SetFullScreen(bool isFullScreen)
	{
		if (isFullScreen)
		{
			//Screen.SetResolution(1920, 1080, true, 60);
			Screen.fullScreen = true;
		}
		else
		{
			Screen.fullScreen = false;
		}*/

		//PlayerPrefs.SetInt("fullscreen", System.Convert.ToInt32(fullscreen.GetComponent<Toggle>().isOn));
	}


