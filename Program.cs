using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            form.AddField("Nickname", FieldType.Text);
            form.AddField("Hasło", FieldType.Password);
            form.InitForm();
            //Debug.WriteLine(Console.ReadKey(true).KeyChar);
        }
    }
}
