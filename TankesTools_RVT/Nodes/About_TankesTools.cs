using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankesTools_RVT
{
    /// <summary>
    ///  Here you put the xml documentation for the node
    /// </summary>
    public class TankesTools
    {
        // private hides the class in the search browser of dynamo
       private TankesTools() { }

        /// <summary>
        /// ☣ Here is where the instructions of the nodes should be ☣
        /// </summary>
        /// <returns></returns>
       public static string About()
        {
            // return is the fuction that control the output but is not the visual name
            return "This is The firs test node of Tankes Tools package";
        }
    }
}
