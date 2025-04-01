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
	/// <summary>Feature Card Settings</summary>
	[PublishedModel("featureCardSettings")]
	public partial class FeatureCardSettings : PublishedElementModel, IAlignItemsProperties, IContainerStylingProperties, IMarginProperties, IPaddingProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		public new const string ModelTypeAlias = "featureCardSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedContentTypeCache contentTypeCache)
			=> PublishedModelUtility.GetModelContentType(contentTypeCache, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedContentTypeCache contentTypeCache, Expression<Func<FeatureCardSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(contentTypeCache), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public FeatureCardSettings(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Align Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("alignItems")]
		public virtual string AlignItems => global::Umbraco.Cms.Web.Common.PublishedModels.AlignItemsProperties.GetAlignItems(this, _publishedValueFallback);

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
		/// Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("marginBottom")]
		public virtual int MarginBottom => global::Umbraco.Cms.Web.Common.PublishedModels.MarginProperties.GetMarginBottom(this, _publishedValueFallback);

		///<summary>
		/// Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("marginLeft")]
		public virtual int MarginLeft => global::Umbraco.Cms.Web.Common.PublishedModels.MarginProperties.GetMarginLeft(this, _publishedValueFallback);

		///<summary>
		/// Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("marginRight")]
		public virtual int MarginRight => global::Umbraco.Cms.Web.Common.PublishedModels.MarginProperties.GetMarginRight(this, _publishedValueFallback);

		///<summary>
		/// Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("marginTop")]
		public virtual int MarginTop => global::Umbraco.Cms.Web.Common.PublishedModels.MarginProperties.GetMarginTop(this, _publishedValueFallback);

		///<summary>
		/// Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("paddingBottom")]
		public virtual int PaddingBottom => global::Umbraco.Cms.Web.Common.PublishedModels.PaddingProperties.GetPaddingBottom(this, _publishedValueFallback);

		///<summary>
		/// Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("paddingLeft")]
		public virtual int PaddingLeft => global::Umbraco.Cms.Web.Common.PublishedModels.PaddingProperties.GetPaddingLeft(this, _publishedValueFallback);

		///<summary>
		/// Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("paddingRight")]
		public virtual int PaddingRight => global::Umbraco.Cms.Web.Common.PublishedModels.PaddingProperties.GetPaddingRight(this, _publishedValueFallback);

		///<summary>
		/// Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("paddingTop")]
		public virtual int PaddingTop => global::Umbraco.Cms.Web.Common.PublishedModels.PaddingProperties.GetPaddingTop(this, _publishedValueFallback);
	}
}
