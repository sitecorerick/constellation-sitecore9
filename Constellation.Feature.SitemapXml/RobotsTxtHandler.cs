﻿using System.Text;
using System.Web;

namespace Constellation.Feature.SitemapXml
{
	/// <inheritdoc />
	/// <summary>
	/// Handles requests for robots.txt and response with a reference to the hostname-specific
	/// sitemap.xml file.
	/// </summary>
	public class RobotsTxtHandler : IHttpHandler
	{
		#region IHttpHandler Members
		/// <inheritdoc />
		/// <summary>
		/// Gets a value indicating whether this instance of the handler is reusable.
		/// Required by IHttpHandler, not used by developers in this case.
		/// </summary>
		public bool IsReusable
		{
			get { return false; }
		}

		/// <inheritdoc />
		/// <summary>
		/// Required by IHttpHandler, this is called by ASP.NET when an appropriate URL match is found.
		/// </summary>
		/// <param name="context">The current request context.</param>
		public void ProcessRequest(HttpContext context)
		{
			var builder = new StringBuilder();

			builder.AppendLine("User-agent: *");

			if (!RobotsTxtHandlerConfiguration.Current.Allowed)
			{
				builder.AppendLine("Disallow: /");
			}
			else
			{
				builder.AppendLine();
				builder.AppendLine("Sitemap: " + context.Request.Url.GetLeftPart(System.UriPartial.Authority) + "/sitemap.xml");
			}

			context.Response.Clear();
			context.Response.ContentType = "text";
			context.Response.Write(builder.ToString());
			context.Response.End();
		}
		#endregion
	}
}
