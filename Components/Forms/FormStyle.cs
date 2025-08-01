﻿namespace FormController.Components.Forms
{
    public static class FormStyle
    {
        /// <summary>
        /// Represents the font color used for the selected field in the console.
        /// </summary>
        /// <remarks>The default value is <see cref="ConsoleColor.Black"/>. This field can be modified to
        /// change the appearance of the selected field in console-based applications.</remarks>
        static public ConsoleColor SelectedFieldFontColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the background color used to highlight a selected field in the console.
        /// </summary>
        /// <remarks>This static field can be modified to customize the appearance of selected fields. The
        /// default value is <see cref="ConsoleColor.White"/>.</remarks>
        static public ConsoleColor SelectedFieldBackgroundColor = ConsoleColor.White;
        /// <summary>
        /// Specifies the font color used for displaying field text in the console.
        /// </summary>
        /// <remarks>The default value is <see cref="ConsoleColor.White"/>. This field can be modified to
        /// change the font color of field text output in the console.</remarks>
        static public ConsoleColor FieldFontColor = ConsoleColor.White;
        /// <summary>
        /// Represents the background color used for rendering fields in the console.
        /// </summary>
        /// <remarks>The default value is <see cref="ConsoleColor.Black"/>. This field can be modified to
        /// change the  background color of fields displayed in the console.</remarks>
        static public ConsoleColor FieldBackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the font color used for displaying data in the console.
        /// </summary>
        static public ConsoleColor DataFontColor = ConsoleColor.White;
        /// <summary>
        /// Represents the background color used for displaying data in the console.
        /// </summary>
        /// <remarks>The default value is <see cref="ConsoleColor.Black"/>. This field can be modified to
        /// change the  background color for data output in the console.</remarks>
        static public ConsoleColor DataBackgroundcColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the font color used when submitting data.
        /// </summary>
        static public ConsoleColor SubmitFontColor = ConsoleColor.DarkGreen;
        /// <summary>
        /// Represents the background color used when submitting data.
        /// </summary>
        /// <remarks>The default value is <see cref="ConsoleColor.Black"/>. This field can be modified to
        /// change the background color displayed during submission operations.</remarks>
        static public ConsoleColor SubmitBackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the font color used for the submit button when selected.
        /// </summary>
        /// <remarks>The default value is <see cref="ConsoleColor.Green"/>. This can be used to customize
        /// the appearance of the submit button in console applications.</remarks>
        static public ConsoleColor SelectedSubmitFontColor = ConsoleColor.Green;
        /// <summary>
        /// Represents the background color used for the submit button when it is selected.
        /// </summary>
        static public ConsoleColor SelectedSubmitBackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the font color used to display cancel-related messages in the console.
        /// </summary>
        static public ConsoleColor CancelFontColor = ConsoleColor.Red;
        /// <summary>
        /// Represents the background color used to indicate a canceled operation.
        /// </summary>
        /// <remarks>This static field can be used to customize the appearance of canceled operations in
        /// console-based applications. The default value is <see cref="ConsoleColor.Black"/>.</remarks>
        static public ConsoleColor CancelBackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the font color used to display the cancel option in the console.
        /// </summary>
        /// <remarks>The default value is <see cref="ConsoleColor.Red"/>. This color is intended to
        /// visually distinguish  the cancel option from other text in the console.</remarks>
        static public ConsoleColor SelectedCancelFontColor = ConsoleColor.Green;
        /// <summary>
        /// Represents the background color used for the cancel option when selected.
        /// </summary>
        static public ConsoleColor SelectedCancelBackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the font color used when displaying password show button.
        /// </summary>
        static public ConsoleColor ShowPasswordFontColor = ConsoleColor.Yellow;
        /// <summary>
        /// Represents the background color used when displaying password show button.
        /// </summary>
        static public ConsoleColor ShowPasswordBackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the font color used when displaying seletected password show button.
        /// </summary>
        static public ConsoleColor SelectedShowPasswordFontColor = ConsoleColor.Green;
        /// <summary>
        /// Represents the background color used when displaying seletected password show button.
        /// </summary>
        static public ConsoleColor SelectedShowPasswordBackgroundColor = ConsoleColor.Black;
    }
}
