using FormController.Components.Fields;
using FormController.Components.Forms;
using System.Diagnostics;

namespace FormController
{
    public class Form
    {
        private FormView _formView = new();
        private FormNavigation _formNavigation = new();
        private List<Field> _fields = [];
        /// <summary>
        /// Adds a new field to the form with the specified description, type, and coordinates.
        /// </summary>
        /// <remarks>This method updates the form by adding the field description, type, and coordinates
        /// to their respective collections. Ensure that the coordinates provided are within the valid bounds of the
        /// form.</remarks>
        /// <param name="fieldDescription">The description of the field to be added. This value cannot be null or empty.</param>
        /// <param name="fieldType">The type of the field to be added, represented by the <see cref="FieldType"/> enumeration.</param>
        /// <param name="x">The x-coordinate of the field's position on the form. Must be a non-negative integer.</param>
        /// <param name="y">The y-coordinate of the field's position on the form. Must be a non-negative integer.</param>
        public void AddField(string fieldDescription, FieldType fieldType, int x, int y)
        {
            ValidateDescriptionOfField(fieldDescription);
            _formView.FormMenu.Add(fieldDescription);
            _formView.TypeOfField.Add(fieldType);
            _formView.FieldsCoordinates.Add([x, y]);
            CreateNewInstanceOfField(x, y, fieldDescription.Length, fieldType);
        }
        /// <summary>
        /// Adds a new field to the form with the specified description and type.
        /// </summary>
        /// <remarks>This method updates the form by adding the field description, type, and coordinates.
        /// The coordinates are automatically calculated based on the current layout of the form.</remarks>
        /// <param name="fieldDescription">The description of the field to be added. This value cannot be null or empty.</param>
        /// <param name="fieldType">The type of the field to be added. This determines the behavior and representation of the field.</param>
        public void AddField(string fieldDescription, FieldType fieldType)
        {
            ValidateDescriptionOfField(fieldDescription);
            int[] getNextCoordinates = GetNextCoordinates();
            _formView.FormMenu.Add(fieldDescription);
            _formView.TypeOfField.Add(fieldType);
            _formView.FieldsCoordinates.Add(getNextCoordinates);
            CreateNewInstanceOfField(getNextCoordinates[0], getNextCoordinates[1], fieldDescription.Length, fieldType);
        }
        /// <summary>
        /// Adds a new field to the form with the specified description.
        /// </summary>
        /// <remarks>This method adds a field to the form's menu, sets its type to text, and assigns it
        /// the next available coordinates.</remarks>
        /// <param name="fieldDescription">The description of the field to be added. This value cannot be null or empty.</param>
        public void AddField(string fieldDescription)
        {
            ValidateDescriptionOfField(fieldDescription);
            int[] getNextCoordinates = GetNextCoordinates();
            _formView.FormMenu.Add(fieldDescription);
            _formView.TypeOfField.Add(FieldType.Text);
            _formView.FieldsCoordinates.Add(getNextCoordinates);
            CreateNewInstanceOfField(getNextCoordinates[0], getNextCoordinates[1], fieldDescription.Length, FieldType.Text);
        }
        /// <summary>
        /// Adds a new field to the form view.
        /// </summary>
        /// <remarks>This method appends a new field to the form menu, assigns it a default field type, 
        /// and calculates its coordinates based on the next available position.</remarks>
        public void AddField()
        {
            string fieldDescription = $"Field {_formView.FormMenu.Count + 1}:";
            int[] getNextCoordinates = GetNextCoordinates();
            _formView.FormMenu.Add(fieldDescription);
            _formView.TypeOfField.Add(FieldType.Text);
            _formView.FieldsCoordinates.Add(getNextCoordinates);
            CreateNewInstanceOfField(getNextCoordinates[0], getNextCoordinates[1],fieldDescription.Length, FieldType.Text);
        }
        /// <summary>
        /// Initializes and prepares the form for user interaction.
        /// </summary>
        /// <remarks>This method sets up the form by rendering the menu, configuring maximum values,  and
        /// starting the form's main execution process. It should be called before  interacting with the form to ensure
        /// proper initialization.</remarks>
        public void InitForm()
        {
            _formView.RenderFormMenu();
            SetMaxValues();
            RunForm();
        }
        /// <summary>
        /// Handles user input to navigate and interact with a form until the Enter key is pressed.
        /// </summary>
        /// <remarks>This method reads key inputs from the console and updates the form's navigation and
        /// field appearance based on the user's actions. The navigation position is updated with each key press, and
        /// the visual representation of the form is adjusted accordingly.</remarks>
        private void RunForm()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                _formNavigation.ChangePosition(key);
                _formView.ChangeColorOfTheField(_formNavigation.PreviousPosition, _formNavigation.FieldPosition);
            } while (key != ConsoleKey.Enter);
            _fields[_formNavigation.FieldPosition].Write();
        }
        private void CreateNewInstanceOfField(int x, int y, int lengthOfDescription, FieldType fieldType)
        {
            switch(fieldType)
            {
                case FieldType.Text:
                    _fields.Add(new Field(x, y, lengthOfDescription, false));
                    break;
                case FieldType.Password:
                    _fields.Add(new Field(x, y, lengthOfDescription, true));
                    break;
            }
        }
        private void SetMaxValues()
        {
            _formNavigation.MaxFieldPosition = _formView.FormMenu.Count;
        }
        /// <summary>
        /// Validates the provided field description to ensure it meets required criteria.
        /// </summary>
        /// <param name="fieldDescription">The description of the field to validate. Must not be an empty string.</param>
        /// <exception cref="InvalidOperationException">Thrown if <paramref name="fieldDescription"/> is an empty string.</exception>
        private void ValidateDescriptionOfField(string fieldDescription)
        {
            if (fieldDescription.Length == 0) throw new InvalidOperationException("Field description cannot be empty.");
        }
        /// <summary>
        /// Calculates the next coordinates based on the current state of the form menu.
        /// </summary>
        /// <remarks>If the form menu contains existing entries, the next coordinates are determined by
        /// incrementing  the Y-coordinate of the last entry while keeping the X-coordinate unchanged. If the form menu
        /// is  empty, the method returns the default coordinates (0, 0).</remarks>
        /// <returns>An array of integers representing the next coordinates. The first element is the X-coordinate, and the
        /// second element is the Y-coordinate.</returns>
        private int[] GetNextCoordinates()
        {
            int previousPositionX;
            int previousPositionY;
            int formCoordinatesLength = _formView.FieldsCoordinates.Count;
            if (formCoordinatesLength != 0)
            {
                previousPositionX = _formView.FieldsCoordinates[formCoordinatesLength - 1][0];
                previousPositionY = _formView.FieldsCoordinates[formCoordinatesLength - 1][1] + 1;
            }
            else
            {
                previousPositionX = 0;
                previousPositionY = 0;
            }
            return [previousPositionX, previousPositionY];
        }
    }
}
