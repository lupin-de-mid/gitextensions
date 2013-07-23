namespace GitCommands.Git
{
	public static class GitMediaCommandHelpers
	{
		private const string MediaPrefix = "media";

		public static string SyncCmd()
		{
			return MediaPrefix + " sync";
		}

		public static string ClearCmd()
		{
			return MediaPrefix + " clear";
		}

		public static string StatusCmd()
		{
			return MediaPrefix + " status";
		}

		public static string DownloadCmd()
		{
			return MediaPrefix + " download";
		}
	}
}