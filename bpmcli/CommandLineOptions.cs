﻿using CommandLine;

namespace bpmcli
{
	internal class BaseOptions
	{
		[Option('u', "uri", Required = false)]
		public string Uri { get; set; }

		[Option('p', "Password", Required = false)]
		public string Password { get; set; }

		[Option('l', "Login", Required = false)]
		public string Login { get; set; }

		[Option('e', "Environment", Required = false)]
		public string Environment { get; set; }
	}

	[Verb("exec", HelpText = "Execute assembly.")]
	internal class ExecuteOptions : BaseOptions
	{
		[Option('f', "FilePath", Required = true)]
		public string FilePath { get; set; }

		[Option('t', "ExecutorType", Required = true)]
		public string ExecutorType { get; set; }
	}

	[Verb("restart", HelpText = "Restart application.")]
	internal class RestartOptions : BaseOptions
	{
	}

	[Verb("download", HelpText = "Download assembly.")]
	internal class DownloadOptions : BaseOptions
	{
		[Option('p', "PackageName", Required = true)]
		public string PackageName { get; set; }
	}

	[Verb("upload", HelpText = "Upload assembly.")]
	internal class UploadOptions : BaseOptions
	{
		[Option('p', "PackageName", Required = true)]
		public string PackageName { get; set; }
	}

	[Verb("cfg", HelpText = "Configure environment settings.")]
	internal class ConfigureOptions : BaseOptions
	{
		[Option('a', "ActiveEnvironment", Required = true)]
		public string ActiveEnvironment { get; set; }
	}
}