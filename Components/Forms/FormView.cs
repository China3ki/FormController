using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormController.Components.Forms
{
    internal class FormView
    {
        public List<string> FormMenu { get; set; } = [];
        public List<FieldType> TypeOfField = [];
        public List<int[]> FieldsCoordinates { get; set; } = [];
        /// <summary>
        /// Renders menu.
        /// </summary>
        public void RenderFormMenu()
        {
            for(int i = 0; i < FormMenu.Count; i++)
            {
                int x = FieldsCoordinates[i][0];
                int y = FieldsCoordinates[i][1];
                if (i == 0) SetColors(i, true);
                else SetColors(i, false);
                Console.SetCursorPosition(x, y);
                Console.Write(FormMenu[i]);
                Console.ResetColor();
            }
        }
        /// <summary>
        /// Updates the visual representation of a field by changing its color and content based on the specified
        /// positions.
        /// </summary>
        /// <remarks>This method modifies the console output to visually indicate a change in focus or
        /// selection between fields. The field at <paramref name="previousPosition"/> is reset to its default
        /// appearance, while the field at  <paramref name="position"/> is updated to reflect the new focus.</remarks>
        /// <param name="previousPosition">The index of the field to revert to its original color and content.</param>
        /// <param name="position">The index of the field to highlight by changing its color and content.</param>
        public void ChangeColorOfTheField(int previousPosition, int position)
        {
            int previousX = FieldsCoordinates[previousPosition][0];
            int previousY = FieldsCoordinates[previousPosition][1];
            int x = FieldsCoordinates[position][0];
            int y = FieldsCoordinates[position][1];
            
            Console.SetCursorPosition(previousX, previousY);
            SetColors(previousPosition, false);
            Console.Write(FormMenu[previousPosition]);
            Console.ResetColor();

            Console.SetCursorPosition(x, y);
            SetColors(position, true);
            Console.Write(FormMenu[position]);
            Console.ResetColor();
        }
       /// <summary>
       /// Sets the foreground and background colors of a console field based on its type and selection state.
       /// </summary>
       /// <remarks>This method adjusts the console's foreground and background colors to visually
       /// represent the state of a field. The colors are determined by the field type and whether the field is
       /// selected, using the styling defined in <see cref="FormStyle"/>.</remarks>
       /// <param name="i">The index of the field whose colors are being set. Must correspond to a valid field in <see
       /// cref="TypeOfField"/>.</param>
       /// <param name="selectedField">A value indicating whether the field is currently selected.  <see langword="true"/> applies the selected
       /// field colors; otherwise, the default field colors are applied.</param>
        private void SetColors(int i, bool selectedField)
        {
            switch(TypeOfField[i])
            {
                case FieldType.Submit:
                    if(selectedField)
                    {
                        Console.ForegroundColor = FormStyle.SelectedSubmitFontColor;
                        Console.BackgroundColor = FormStyle.SelectedSubmitBackgroundColor;
                    }
                    else
                    {
                        Console.ForegroundColor = FormStyle.SubmitFontColor;
                        Console.BackgroundColor = FormStyle.SubmitBackgroundColor;
                    }
                    break;
                case FieldType.Cancel:
                    if(selectedField)
                    {
                        Console.ForegroundColor = FormStyle.SelectedCancelFontColor;
                        Console.BackgroundColor = FormStyle.SelectedCancelBackgroundColor;
                    }
                    else
                    {
                        Console.ForegroundColor = FormStyle.CancelFontColor;
                        Console.BackgroundColor = FormStyle.CancelBackgroundColor;
                    }
                    break;
                default:
                    if(selectedField)
                    {
                        Console.ForegroundColor = FormStyle.SelectedFieldFontColor;
                        Console.BackgroundColor = FormStyle.SelectedFieldBackgroundColor;
                    }
                    else
                    {
                        Console.ForegroundColor = FormStyle.FieldFontColor;
                        Console.BackgroundColor = FormStyle.FieldBackgroundColor;
                    }
                    break;
            }
        }
    }
}
