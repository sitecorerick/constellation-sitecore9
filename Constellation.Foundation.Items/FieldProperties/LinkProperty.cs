﻿namespace Constellation.Foundation.Items.FieldProperties
{
	using Sitecore.Data;
	using Sitecore.Data.Fields;
	using Sitecore.Data.Items;
	using Sitecore.Links;

	/// <inheritdoc />
	/// <summary>
	/// Wraps a Sitecore LinkField
	/// </summary>
	public class LinkProperty : XmlProperty
	{
		/// <summary>
		/// The Link field to wrap.
		/// </summary>
		private readonly LinkField _linkField;

		#region Constructors
		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="LinkProperty"/> class.
		/// </summary>
		/// <param name="field">The field to wrap.</param>
		public LinkProperty(Field field)
			: base(field)
		{
			_linkField = field;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Anchor.
		/// </summary>
		public string Anchor
		{
			get => _linkField.Anchor;
			set => _linkField.Anchor = value;
		}

		/// <summary>
		/// Gets or sets the HTML Class attribute value.
		/// </summary>
		public string Class
		{
			get => _linkField.Class;
			set => _linkField.Class = value;
		}

		/// <summary>
		/// Gets the path to the Sitecore Item.
		/// </summary>
		public string InternalPath => _linkField.InternalPath;

		/// <summary>
		/// Gets a value indicating whether the link is internal.
		/// </summary>
		/// <value>
		/// <c>true</c> if this link is internal; otherwise, <c>false</c>.
		/// </value>
		public bool IsInternal => _linkField.IsInternal;

		/// <summary>
		/// Gets a value indicating whether this instance is media link.
		/// </summary>
		/// <value>
		/// <c>true</c> if this instance is media link; otherwise, <c>false</c>.
		/// </value>
		public bool IsMediaLink => _linkField.IsMediaLink;

		/// <summary>
		/// Gets or sets the link type.
		/// </summary>
		/// <value>
		/// The type of the link.
		/// </value>
		public string LinkType
		{
			get => _linkField.LinkType;
			set => _linkField.LinkType = value;
		}

		/// <summary>
		/// Gets the path to the Media Item.
		/// </summary>
		/// <value>
		/// The internal path.
		/// </value>
		public string MediaPath => _linkField.MediaPath;

		/// <summary>
		/// Gets or sets the query string in internal links.
		/// </summary>
		/// <value>
		/// The query string.
		/// </value>
		public string QueryString
		{
			get => _linkField.QueryString;
			set => _linkField.QueryString = value;
		}

		/// <summary>
		/// Gets or sets the HTML target attribute value.
		/// </summary>
		/// <value>
		/// The value of the target HTML attribute.
		/// </value>
		public string Target
		{
			get => _linkField.Target;
			set => _linkField.Target = value;
		}

		/// <summary>
		/// Gets or sets the target ID.
		/// </summary>
		/// <value>
		/// The target ID.
		/// </value>
		public ID TargetID
		{
			get => _linkField.TargetID;
			set => _linkField.TargetID = value;
		}

		/// <summary>
		/// Gets the target item.
		/// </summary>
		/// <value>
		/// The target item.
		/// </value>
		public Item TargetItem => _linkField.TargetItem;

		/// <summary>
		/// Gets or sets the inner text of the tag.
		/// </summary>
		/// <value>
		/// The inner text.
		/// </value>
		public string Text
		{
			get => _linkField.Text;
			set => _linkField.Text = value;
		}

		/// <summary>
		/// Gets or sets the title attribute value.
		/// </summary>
		/// <value>
		/// The title attribute value.
		/// </value>
		public new string Title
		{
			get => _linkField.Title;
			set => _linkField.Title = value;
		}

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>
		/// The URL.
		/// </value>
		public string Url
		{
			get => _linkField.Url;
			set => _linkField.Url = value;
		}
		#endregion

		#region Operators
		/// <summary>
		/// Allows interoperability with Sitecore LinkField.
		/// </summary>
		/// <param name="field">The field to wrap.</param>
		/// <returns>A new instance of LinkProperty using the supplied field.</returns>
		public static implicit operator LinkProperty(LinkField field)
		{
			return new LinkProperty(field.InnerField);
		}

		/// <summary>
		/// Allows interoperability with Sitecore LinkField.
		/// </summary>
		/// <param name="property">The property to convert.</param>
		/// <returns>The property.InnerField.</returns>
		public static implicit operator LinkField(LinkProperty property)
		{
			return property.InnerField;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Relinks the specified item link.
		/// </summary>
		/// <param name="itemLink">The item link.</param><param name="newLink">The new link.</param>
		public override void Relink(ItemLink itemLink, Item newLink)
		{
			_linkField.Relink(itemLink, newLink);
		}

		/// <summary>
		/// Removes the link.
		/// </summary>
		/// <param name="itemLink">The item link.</param>
		public override void RemoveLink(ItemLink itemLink)
		{
			_linkField.RemoveLink(itemLink);
		}

		/// <summary>
		/// Updates the link.
		/// </summary>
		/// <param name="itemLink">The link.</param>
		public override void UpdateLink(ItemLink itemLink)
		{
			_linkField.UpdateLink(itemLink);
		}

		/// <summary>
		/// Validates the links.
		/// </summary>
		/// <param name="result">The result.</param>
		public override void ValidateLinks(LinksValidationResult result)
		{
			_linkField.ValidateLinks(result);
		}
		#endregion
	}
}
