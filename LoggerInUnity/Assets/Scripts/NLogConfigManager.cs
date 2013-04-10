//
//	This is a singleton class
//

using System;


public sealed class NLogConfigManager
{
	
	#region Singleton 
	private NLogConfigManager ()
	{
	}
	
	public static NLogConfigManager Instance
	{
		get
		{
			return Nested.instance;
		}
	}
	
	private class Nested
	{
		internal readonly static NLogConfigManager instance = new NLogConfigManager();
	}
	#endregion // Singleton
	
	public void InitNLog()
	{ 
		// Step 1. Create configuration object 
		NLog.Config.LoggingConfiguration gConfig = new NLog.Config.LoggingConfiguration();
		
        // Step 2. Create targets and add them to the configuration 
        NLog.Targets.ColoredConsoleTarget consoleTarget = new NLog.Targets.ColoredConsoleTarget();
        gConfig.AddTarget("console", consoleTarget); 
         
        NLog.Targets.FileTarget fileTarget = new NLog.Targets.FileTarget();
        gConfig.AddTarget("file", fileTarget); 
         
        // Step 3. Set target properties   
        consoleTarget.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}"; 
        fileTarget.FileName = UnityEngine.Application.dataPath + "/../../file.log"; 
        fileTarget.Layout = "${date:format=HH\\:MM\\:ss} ${logger} ${message}"; 
		
		UnityEngine.Debug.Log(fileTarget.FileName);
         
        // Step 4. Define rules 
        NLog.Config.LoggingRule rule1 = new NLog.Config.LoggingRule("*", NLog.LogLevel.Debug, consoleTarget); 
        gConfig.LoggingRules.Add(rule1); 
 
        NLog.Config.LoggingRule rule2 = new NLog.Config.LoggingRule("*", NLog.LogLevel.Debug, fileTarget); 
        gConfig.LoggingRules.Add(rule2); 
         
        // Step 5. Activate the configuration 
        NLog.LogManager.Configuration = gConfig;
	}
}

