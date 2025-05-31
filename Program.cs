using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormController
{
    static class Program
    {
        static void Main()
        {
            Form form = new();
            form.AddField("Hasło", FieldType.Text, 10, 2);
            form.AddField("Nickname", FieldType.Number, 0,10);
            form.InitForm();
        }
    }
}
