using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class LoadSettingsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		//ChangeSettings.SetQuality(PlayerPrefs.GetInt(ChangeSettings.qualityKey));
		//ChangeSettings.SetVolume(PlayerPrefs.GetFloat("volume"));
		//SetFullScreen(System.Convert.ToBoolean(PlayerPrefs.GetInt("fullscreen")));
		Permission.RequestUserPermission(Permission.ExternalStorageRead);
		Permission.RequestUserPermission(Permission.ExternalStorageWrite);
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

}
