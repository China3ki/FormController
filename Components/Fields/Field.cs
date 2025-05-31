using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormController.Components.Fields
{
    internal class Field(int x, int y, int lengthOfDescription, bool hidePassword)
    {
        private int _positionX = x;
        private int _positionY = y;
        private int _lengthOfDescription = lengthOfDescription + 1;
        private bool _hidePassword = hidePassword;
        private string _data = "";
        public void Write()
        {
            StringBuilder stringBuilder = new();
            string pattern = @"[A-Za-z0-9 !""#$%&'()*+,\-./:;<=>?@[\\\]^_`{|}~]";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if(Regex.IsMatch(key.KeyChar.ToString(), pattern))
                {
                    Console.SetCursorPosition(_positionX + lengthOfDescription + stringBuilder.Length, _positionY);
                    if(_hidePassword) Console.Write('*');
                    else Console.Write(key.KeyChar);
                    stringBuilder.Append(key.KeyChar.ToString());
                } else if(key.KeyChar.ToString() == "\b")
                {
                    if (stringBuilder.Length != 0)
                    {
                        stringBuilder.Length -= 1;
                        Console.SetCursorPosition(_positionX + lengthOfDescription + stringBuilder.Length, _positionY);
                        Console.Write(' ');
                        Console.SetCursorPosition(_positionX + lengthOfDescription + stringBuilder.Length, _positionY);
                    }
                }
            } while(key.Key != ConsoleKey.Enter);
        }
        //public string ReturnFieldValue()
        //{

        //}
        //public StringBuilder ReturnTheStateOfField()
        //{

        //}
        public void SaveStateOfField()
        {

        }
    }
}
