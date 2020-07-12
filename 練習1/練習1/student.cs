using System;
using System.Collections.Generic;
using System.Text;

namespace 練習1
{
    class student
    {
        public string Name;
        public int Grade;

        public string Talk(int sgrade, string sname)
        {
            return Grade + "年級的" + Name + "呼叫" + sgrade + "年級的" +sname;
        }
    }
}
