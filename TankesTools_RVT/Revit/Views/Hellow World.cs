using Dynamo.Graph.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Views.Sheets
{
    /// <summary>
    ///  Here you put the xml documentation for the node
    /// </summary>
    public class HelloWorld
    {
        // private hides the class in the search browser of dynamo
        private HelloWorld() { }

        /// <summary>
        /// ☣ Here is where the instructions of the nodes should be ☣
        /// </summary>
        /// <param name="extraMessage">Optional extra message</param>
        /// <returns name = "Output">Tool tip of the output</returns>
        [NodeCategory("Create")]
        public static string About(string extraMessage = "")
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            // return is the fuction that control the output but is not the visual name
            return $"Hello, {userName} this is the first node of Tanke's Tools package. {extraMessage}";
        }
    }
}