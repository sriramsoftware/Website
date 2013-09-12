﻿using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace Daniel15.Data.Entities.Projects
{
	/// <summary>
	/// Represents a project I've worked on in the past
	/// </summary>
	[Alias("projects")]
	public class ProjectModel
	{
		/// <summary>
		/// Database ID for this project
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Name of this project
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// URL alias ("slug") for this project
		/// </summary>
		public string Slug { get; set; }

		/// <summary>
		/// Live URL to this project, or <c>null</c> if it's no longer online
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// Thumbnail image name for this project
		/// </summary>
		public string Thumbnail { get; set; }

		/// <summary>
		/// Height of the thumbnail, or <c>null</c> for the default
		/// </summary>
		[Alias("thumbnail_height")]
		public int? ThumbnailHeight { get; set; }

		/// <summary>
		/// Width of the thumbnail, or <c>null</c> for the default
		/// </summary>
		[Alias("thumbnail_width")]
		public int? ThumbnailWidth { get; set; }

		/// <summary>
		/// Project type
		/// </summary>
		[Alias("type")]
		public ProjectType ProjectType { get; set; }

		/// <summary>
		/// Description of this project
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Date this project was created or last modified. Free-form text, can be anything (eg. 
		/// "September 2013" or "Always updated")
		/// </summary>
		public string Date { get; set; }

		/// <summary>
		/// URL to a Markdown readme file for this project
		/// </summary>
		[Alias("readme_url")]
		public string ReadmeUrl { get; set; }

		/// <summary>
		/// Cached text of the readme file
		/// </summary>
		public string Readme { get; set; }

		/// <summary>
		/// Whether this project is still being worked on
		/// </summary>
		[Alias("current")]
		public bool IsCurrent { get; set; }

		/// <summary>
		/// A list of technologies used during development of this project
		/// </summary>
		public IList<string> Technologies { get; set; }

		public int Order { get; set; }
	}

	/// <summary>
	/// Represents a project type
	/// </summary>
	public enum ProjectType
	{
		/// <summary>
		/// This project is a regular web site
		/// </summary>
		Website,

		/// <summary>
		/// This project is a web application
		/// </summary>
		WebApp,

		/// <summary>
		/// This project is a reusable library
		/// </summary>
		Library
	}
}