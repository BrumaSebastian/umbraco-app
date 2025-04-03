//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v15.3.0+131c9cd
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Media Wall Layout Settings</summary>
	[PublishedModel("mediaWallLayoutSettings")]
	public partial class MediaWallLayoutSettings : PublishedElementModel, IContainerStylingProperties, IGridGapProperties, IGridLayoutItemProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		public new const string ModelTypeAlias = "mediaWallLayoutSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedContentTypeCache contentTypeCache)
			=> PublishedModelUtility.GetModelContentType(contentTypeCache, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedContentTypeCache contentTypeCache, Expression<Func<MediaWallLayoutSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(contentTypeCache), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public MediaWallLayoutSettings(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Container Align Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("containerAlignItems")]
		public virtual string ContainerAlignItems => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerAlignItems(this, _publishedValueFallback);

		///<summary>
		/// Container Justify Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("containerJustifyContent")]
		public virtual string ContainerJustifyContent => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerJustifyContent(this, _publishedValueFallback);

		///<summary>
		/// Container Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("containerMarginBottom")]
		public virtual int ContainerMarginBottom => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerMarginBottom(this, _publishedValueFallback);

		///<summary>
		/// Container Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("containerMarginLeft")]
		public virtual int ContainerMarginLeft => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerMarginLeft(this, _publishedValueFallback);

		///<summary>
		/// Container Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("containerMarginRight")]
		public virtual int ContainerMarginRight => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerMarginRight(this, _publishedValueFallback);

		///<summary>
		/// Container Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("containerMarginTop")]
		public virtual int ContainerMarginTop => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerMarginTop(this, _publishedValueFallback);

		///<summary>
		/// Container Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("containerPaddingBottom")]
		public virtual int ContainerPaddingBottom => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerPaddingBottom(this, _publishedValueFallback);

		///<summary>
		/// Container Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("containerPaddingLeft")]
		public virtual int ContainerPaddingLeft => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerPaddingLeft(this, _publishedValueFallback);

		///<summary>
		/// Container Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("containerPaddingRight")]
		public virtual int ContainerPaddingRight => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerPaddingRight(this, _publishedValueFallback);

		///<summary>
		/// Container PaddingTop
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("containerPaddingTop")]
		public virtual int ContainerPaddingTop => global::Umbraco.Cms.Web.Common.PublishedModels.ContainerStylingProperties.GetContainerPaddingTop(this, _publishedValueFallback);

		///<summary>
		/// Gap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gap")]
		public virtual int Gap => global::Umbraco.Cms.Web.Common.PublishedModels.GridGapProperties.GetGap(this, _publishedValueFallback);

		///<summary>
		/// Align Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gridItemAlignItems")]
		public virtual string GridItemAlignItems => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemAlignItems(this, _publishedValueFallback);

		///<summary>
		/// Grid Item Background Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gridItemBackgroundImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops GridItemBackgroundImage => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemBackgroundImage(this, _publishedValueFallback);

		///<summary>
		/// Justify Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gridItemJustifyContent")]
		public virtual string GridItemJustifyContent => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemJustifyContent(this, _publishedValueFallback);

		///<summary>
		/// Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gridItemMarginBottom")]
		public virtual int GridItemMarginBottom => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemMarginBottom(this, _publishedValueFallback);

		///<summary>
		/// Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gridItemMarginLeft")]
		public virtual int GridItemMarginLeft => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemMarginLeft(this, _publishedValueFallback);

		///<summary>
		/// Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gridItemMarginRight")]
		public virtual int GridItemMarginRight => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemMarginRight(this, _publishedValueFallback);

		///<summary>
		/// Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gridItemMarginTop")]
		public virtual int GridItemMarginTop => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemMarginTop(this, _publishedValueFallback);

		///<summary>
		/// Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gridItemPaddingBottom")]
		public virtual int GridItemPaddingBottom => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemPaddingBottom(this, _publishedValueFallback);

		///<summary>
		/// Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gridItemPaddingLeft")]
		public virtual int GridItemPaddingLeft => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemPaddingLeft(this, _publishedValueFallback);

		///<summary>
		/// Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gridItemPaddingRight")]
		public virtual int GridItemPaddingRight => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemPaddingRight(this, _publishedValueFallback);

		///<summary>
		/// Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("gridItemPaddingTop")]
		public virtual int GridItemPaddingTop => global::Umbraco.Cms.Web.Common.PublishedModels.GridLayoutItemProperties.GetGridItemPaddingTop(this, _publishedValueFallback);
	}
}
