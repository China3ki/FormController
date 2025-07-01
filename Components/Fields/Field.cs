using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormController.Components.Fields
{
    internal class Field(int x, int y, int lengthOfDescription, bool hidePassword, FieldType fieldType)
    {
        public FieldType FieldType = fieldType;
        private int _positionX = x;
        private int _positionY = y;
        private int _lengthOfDescription = lengthOfDescription;
        private bool _hidePassword = hidePassword;
        private string _data = "";
        /// <summary>
        /// Reads user input from the console, processes it character by character, and updates the internal data.
        /// </summary>
        /// <remarks>This method captures user input in real-time, allowing for character validation and
        /// optional password masking. Valid characters are restricted to alphanumeric characters, spaces, and common
        /// symbols. The method supports backspace functionality to delete the last entered character. Input is
        /// finalized when the Enter key is pressed.</remarks>
        public void Write()
        {
            StringBuilder stringBuilder = new(_data);
            string pattern = @"[A-Za-z0-9 !""#$%&'()*+,\-./:;<=>?@[\\\]^_`{|}~]";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if(Regex.IsMatch(key.KeyChar.ToString(), pattern))
                {
                    Console.SetCursorPosition(_positionX + _lengthOfDescription + stringBuilder.Length, _positionY);
                    if(_hidePassword) Console.Write('*');
                    else Console.Write(key.KeyChar);
                    stringBuilder.Append(key.KeyChar.ToString());
                } else if(key.KeyChar.ToString() == "\b")
                {
                    if (stringBuilder.Length != 0)
                    {
                        stringBuilder.Length -= 1;
                        Console.SetCursorPosition(_positionX + _lengthOfDescription + stringBuilder.Length, _positionY);
                        Console.Write(' ');
                        Console.SetCursorPosition(_positionX + _lengthOfDescription + stringBuilder.Length, _positionY);
                    }
                }
            } while(key.Key != ConsoleKey.Enter);
            _data = stringBuilder.ToString();
        }
        /// <summary>
        /// Toggles the visibility of the password in the console output.
        /// </summary>
        /// <remarks>When the password is hidden, it is displayed as a series of asterisks ('*'). When the
        /// password is visible, the actual password string is displayed. This method updates the console output based
        /// on the current visibility state.</remarks>
        public void ToogleVisibilityOfPassword()
        {
            StringBuilder stringBuilder = new StringBuilder(_data);
            Console.SetCursorPosition(_positionX + _lengthOfDescription, _positionY);
            _hidePassword = _hidePassword == true ? false : true;
            if(_hidePassword)
            {
                stringBuilder.Clear();
                for(int i = 0; i < _data.Length; i++)
                {
                    stringBuilder.Append('*');
                }
            }
            Console.Write(stringBuilder);
        }
        /// <summary>
        /// Retrieves the value of the field represented by this instance.
        /// </summary>
        /// <returns>A <see cref="string"/> containing the value of the field. Returns an empty string if the field has not been
        /// set.</returns>
        public string ReturnFieldValue()
        {
            return _data;
        }
    }
}
