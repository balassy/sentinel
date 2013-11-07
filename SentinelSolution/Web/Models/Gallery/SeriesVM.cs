namespace Sentinel.Web.Models.Gallery
{
	using System.Collections.Generic;


	public class SeriesVM
	{
		public string Title { get; set; }

		public int Count { get; set; }

		public string FolderName { get; set; }

		public string ThumbnailUrl { get; set; }

		public List<string> ThumbnailUrls { get; set; }
	}
}