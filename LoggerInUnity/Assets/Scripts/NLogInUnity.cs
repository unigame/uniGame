 using UnityEngine;
using System.Collections;

public class NLogInUnity : MonoBehaviour 
{
	/// <summary>
	/// NLog In Unity.
	/// </summary>
	private static NLog.Logger logger; 

	// Use this for initialization
	void Start () 
	{
		NLogConfigManager.Instance.InitNLog();
		logger = NLog.LogManager.GetCurrentClassLogger();
		
		logger.Info(UnityEngine.Application.dataPath);
		logger.Info(UnityEngine.Application.persistentDataPath);
		logger.Info(System.IO.Directory.GetCurrentDirectory());
	}
	
	// Update is called once per frame
	void Update () 
	{
		logger.Debug("NLog In Unity : " + Time.time.ToString());
	}
}
