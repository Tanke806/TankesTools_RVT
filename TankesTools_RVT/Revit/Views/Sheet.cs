using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Revit.Elements.Views;

namespace Revit.Views.Sheets
{
    /// <summary>
    /// Wraper class for sheets
    /// </summary>
    public class Sheet
    {
        private Sheet() { }
        /// <summary>
        /// Count all placed views on the input sheet
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        public static int GetAllPlacedViews(global::Revit.Elements.Views.Sheet sheet)
        {
            //This cast the Dynamo Revit sheet to a Revit.DB Viewsheet
            ViewSheet viewSheet = sheet.InternalElement as ViewSheet;

            var placeViews = viewSheet.GetAllPlacedViews();

            return placeViews.Count;
        }
    }
}
