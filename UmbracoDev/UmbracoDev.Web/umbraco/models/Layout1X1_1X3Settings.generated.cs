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
	/// <summary>Layout 1x1 1x3 Settings</summary>
	[PublishedModel("layout1X1_1X3Settings")]
	public partial class Layout1X1_1X3Settings : PublishedElementModel, ITwLayoutGapProperties, ITwLayoutProperties, ITwThemeProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		public new const string ModelTypeAlias = "layout1X1_1X3Settings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedContentTypeCache contentTypeCache)
			=> PublishedModelUtility.GetModelContentType(contentTypeCache, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedContentTypeCache contentTypeCache, Expression<Func<Layout1X1_1X3Settings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(contentTypeCache), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Layout1X1_1X3Settings(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

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

		///<summary>
		/// Dark Mode Accent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("darkModeAccent")]
		public virtual bool DarkModeAccent => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetDarkModeAccent(this, _publishedValueFallback);

		///<summary>
		/// Dark Mode Background
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("darkModeBackground")]
		public virtual bool DarkModeBackground => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetDarkModeBackground(this, _publishedValueFallback);

		///<summary>
		/// Dark Mode Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("darkModeText")]
		public virtual bool DarkModeText => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetDarkModeText(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Accent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("lightModeAccent")]
		public virtual bool LightModeAccent => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetLightModeAccent(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Background
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("lightModeBackground")]
		public virtual bool LightModeBackground => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetLightModeBackground(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[ImplementPropertyType("lightModeText")]
		public virtual bool LightModeText => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetLightModeText(this, _publishedValueFallback);

		///<summary>
		/// Dark Mode Custom Accent Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twDarkModeCustomAccentColor")]
		public virtual string TwDarkModeCustomAccentColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwDarkModeCustomAccentColor(this, _publishedValueFallback);

		///<summary>
		/// Dark Mode Custom Background Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twDarkModeCustomBackgroundColor")]
		public virtual string TwDarkModeCustomBackgroundColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwDarkModeCustomBackgroundColor(this, _publishedValueFallback);

		///<summary>
		/// Dark Mode Custom Text Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twDarkModeCustomTextColor")]
		public virtual string TwDarkModeCustomTextColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwDarkModeCustomTextColor(this, _publishedValueFallback);

		///<summary>
		/// Dark Mode Preset Accent Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twDarkModePresetAccentColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor TwDarkModePresetAccentColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwDarkModePresetAccentColor(this, _publishedValueFallback);

		///<summary>
		/// Dark Mode Preset Background Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twDarkModePresetBackgroundColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor TwDarkModePresetBackgroundColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwDarkModePresetBackgroundColor(this, _publishedValueFallback);

		///<summary>
		/// Dark Mode Preset Text Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twDarkModePresetTextColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor TwDarkModePresetTextColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwDarkModePresetTextColor(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Custom Accent Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twLightModeCustomAccentColor")]
		public virtual string TwLightModeCustomAccentColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwLightModeCustomAccentColor(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Custom Background Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twLightModeCustomBackgroundColor")]
		public virtual string TwLightModeCustomBackgroundColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwLightModeCustomBackgroundColor(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Custom Text Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twLightModeCustomTextColor")]
		public virtual string TwLightModeCustomTextColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwLightModeCustomTextColor(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Preset Accent Color: Select the accent color from predefined colors
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twLightModePresetAccentColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor TwLightModePresetAccentColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwLightModePresetAccentColor(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Preset Background Color: Select the background color from predefined colors
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twLightModePresetBackgroundColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor TwLightModePresetBackgroundColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwLightModePresetBackgroundColor(this, _publishedValueFallback);

		///<summary>
		/// Light Mode Preset Text Color: Select the text color from predefined colors
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.3.0+131c9cd")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twLightModePresetTextColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor TwLightModePresetTextColor => global::Umbraco.Cms.Web.Common.PublishedModels.TwThemeProperties.GetTwLightModePresetTextColor(this, _publishedValueFallback);
	}
}
