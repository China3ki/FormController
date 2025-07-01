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
            form.AddField("Nickname", FieldType.Text, 5, 10);
            form.AddField("Hasło", FieldType.Password, 0, 20);
            form.AddField("Hasło", FieldType.Password, 0, 21);
            form.AddField("Pokaż Hasło", FieldType.ShowPassword, 50, 0);
            form.AddField("zatwierdz", FieldType.Submit, 10, 22);
            form.AddField("Anuluj", FieldType.Cancel, 10, 23);
            form.InitForm();
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(form.GetDataFromField(3));
        }
    }
}
