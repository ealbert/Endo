using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Endo.Web
{
  
  public static class EnumEditorHtmlHelper
  {
    /// <summary>
    /// Creates the DropDown List (HTML Select Element) from LINQ 
    /// Expression where the expression returns an Enum type.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <typeparam name="TProperty">The type of the property.</typeparam>
    /// <param name="instance">The HTML helper instance</param>
    /// <param name="expression">The expression.</param>
    /// <returns></returns>
    public static MvcHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> instance, Expression<Func<TModel, TProperty>> expression)
        where TModel : class
    {
      var value = instance.ViewData.Model == null
          ? default(TProperty)
          : expression.Compile()(instance.ViewData.Model);

      var selected = value == null ? String.Empty : value.ToString();
      return instance.DropDownListFor(expression, CreateSelectList(expression.ReturnType, selected));
    }

    /// <summary>
    /// Creates the select list.
    /// </summary>
    /// <param name="enumType">Type of the enum.</param>
    /// <param name="selectedItem">The selected item.</param>
    /// <returns></returns>
    private static IEnumerable<SelectListItem> CreateSelectList(Type enumType, string selectedItem)
    {
      return (from object item in Enum.GetValues(enumType)
              let fi = enumType.GetField(item.ToString())
              let attribute = fi.GetCustomAttributes(typeof(DescriptionAttribute), true).FirstOrDefault()
              let title = attribute == null ? item.ToString() : ((DescriptionAttribute)attribute).Description
              select new SelectListItem
              {
                Value = item.ToString(),
                Text = title,
                Selected = selectedItem == item.ToString()
              }).ToList();
    }
  }
}