using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaMethodExt
{
    public static class TexBoxExt
    {
        public static string TextExt(this TextBox s)
        {
            return "Вы ввели:" + s.Text.ToUpper();
        }
    }
}
