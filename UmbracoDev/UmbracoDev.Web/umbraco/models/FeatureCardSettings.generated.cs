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
	public partial class FeatureCardSettings : PublishedElementModel, ITwAlignItemsProperties, ITwLayoutGapProperties, ITwLayoutProperties
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
		[ImplementPropertyType("twAlignItems")]
		public virtual string TwAlignItems => global::Umbraco.Cms.Web.Common.PublishedModels.TwAlignItemsProperties.GetTwAlignItems(this, _publishedValueFallback);

		///<summary>
		/// Gap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twLayoutGap")]
		public virtual int TwLayoutGap => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutGapProperties.GetTwLayoutGap(this, _publishedValueFallback);

		///<summary>
		/// Margin Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twMarginBottom")]
		public virtual int TwMarginBottom => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutProperties.GetTwMarginBottom(this, _publishedValueFallback);

		///<summary>
		/// Margin Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twMarginLeft")]
		public virtual int TwMarginLeft => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutProperties.GetTwMarginLeft(this, _publishedValueFallback);

		///<summary>
		/// Margin Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twMarginRight")]
		public virtual int TwMarginRight => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutProperties.GetTwMarginRight(this, _publishedValueFallback);

		///<summary>
		/// Margin Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twMarginTop")]
		public virtual int TwMarginTop => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutProperties.GetTwMarginTop(this, _publishedValueFallback);

		///<summary>
		/// Padding Bottom
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twPaddingBottom")]
		public virtual int TwPaddingBottom => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutProperties.GetTwPaddingBottom(this, _publishedValueFallback);

		///<summary>
		/// Padding Left
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twPaddingLeft")]
		public virtual int TwPaddingLeft => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutProperties.GetTwPaddingLeft(this, _publishedValueFallback);

		///<summary>
		/// Padding Right
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twPaddingRight")]
		public virtual int TwPaddingRight => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutProperties.GetTwPaddingRight(this, _publishedValueFallback);

		///<summary>
		/// Padding Top
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("twPaddingTop")]
		public virtual int TwPaddingTop => global::Umbraco.Cms.Web.Common.PublishedModels.TwLayoutProperties.GetTwPaddingTop(this, _publishedValueFallback);
	}
}
