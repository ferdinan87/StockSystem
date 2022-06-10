using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary
{
    public class MasterStaticController
    {
        public enum Mode
        {
            Normal = 0,
            Test = 1,
            Dev=2
        }

        public static Mode RunMode { get; set; } = Mode.Normal;
    }
}
