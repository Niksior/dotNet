using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    class MainActions
    {
        public bool checkName(string name, List<string> names)
        {
            bool exist = false;
            foreach(string nam in names)
            {
                if (nam == name) exist = true;
            }
            return exist;
        }
    }
}
