namespace FormController.Components
{
    static class FormStyle
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
        static public ConsoleColor SubmitFontColor = ConsoleColor.Green;
        /// <summary>
        /// Represents the background color used when submitting data.
        /// </summary>
        /// <remarks>The default value is <see cref="ConsoleColor.Black"/>. This field can be modified to
        /// change the background color displayed during submission operations.</remarks>
        static public ConsoleColor SubmitBackgroundColor = ConsoleColor.Black;
        /// <summary>
        /// Represents the font color used to display cancel-related messages in the console.
        /// </summary>
        static public ConsoleColor CancelFontColor = ConsoleColor.White;
        /// <summary>
        /// Represents the background color used to indicate a canceled operation.
        /// </summary>
        /// <remarks>This static field can be used to customize the appearance of canceled operations in
        /// console-based applications. The default value is <see cref="ConsoleColor.Black"/>.</remarks>
        static public ConsoleColor CancelBackgroundColor = ConsoleColor.Black;
    }
}
