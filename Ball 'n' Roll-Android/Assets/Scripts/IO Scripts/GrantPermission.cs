using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
public class GrantPermission : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		if (Permission.HasUserAuthorizedPermission("android.permission.WRITE_EXTERNAL_STORAGE"))
		{
			SceneManager.LoadScene("AudioScene");
		}
	}
	// Update is called once per frame
	void Update()
	{

	}
	public void OnClick()
	{
			Permission.RequestUserPermission("android.permission.WRITE_EXTERNAL_STORAGE");
		if (!Permission.HasUserAuthorizedPermission("android.permission.WRITE_EXTERNAL_STORAGE"))
		{
			Application.Quit();
		}
		else
		{
			SceneManager.LoadScene("AudioScene");
		}
	}
}
