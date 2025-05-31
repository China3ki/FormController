using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormController.Components
{
    internal class FormView
    {
        public List<string> FormMenu { get; set; } = [];
        public List<FieldType> TypeOfField = [];
        public List<int[]> FieldsCoordinates { get; set; } = [];
        public int FormFieldPosition = 0;
        /// <summary>
        /// Renders menu.
        /// </summary>
        public void RenderFormMenu()
        {
            for(int i = 0; i < FormMenu.Count; i++)
            {
                int x = FieldsCoordinates[i][0];
                int y = FieldsCoordinates[i][1];
                Console.SetCursorPosition(x, y);
                SetColors(i);
                Console.Write(FormMenu[i]);
                Console.ResetColor();
            }
        }
        /// <summary>
        /// Sets colors of the field.
        /// </summary>
        /// <param name="i">Index of field.</param>
        private void SetColors(int i)
        {
            switch(TypeOfField[i])
            {
                case FieldType.Submit:
                    Console.ForegroundColor = FormStyle.SubmitFontColor;
                    Console.BackgroundColor = FormStyle.SubmitBackgroundColor;
                    break;
                case FieldType.Cancel:
                    Console.ForegroundColor = FormStyle.CancelFontColor;
                    Console.BackgroundColor = FormStyle.CancelBackgroundColor;
                    break;
                default:
                    Console.ForegroundColor = FormStyle.FieldFontColor;
                    Console.ForegroundColor = FormStyle.FieldBackgroundColor;
                    break;
            }
        }
    }
}
