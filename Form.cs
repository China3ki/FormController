using FormController.Components;

namespace FormController
{
    public class Form
    {
        private FormView FormView = new();
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
            FormView.FormMenu.Add(fieldDescription);
            FormView.TypeOfField.Add(fieldType);
            FormView.FieldsCoordinates.Add([x, y]);
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
            FormView.FormMenu.Add(fieldDescription);
            FormView.TypeOfField.Add(fieldType);
            FormView.FieldsCoordinates.Add(GetNextCordinates());
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
            FormView.FormMenu.Add(fieldDescription);
            FormView.TypeOfField.Add(FieldType.Text);
            FormView.FieldsCoordinates.Add(GetNextCordinates());
        }
        /// <summary>
        /// Adds a new field to the form view.
        /// </summary>
        /// <remarks>This method appends a new field to the form menu, assigns it a default field type, 
        /// and calculates its coordinates based on the next available position.</remarks>
        public void AddField()
        {
            FormView.FormMenu.Add($"Field {FormView.FormMenu.Count + 1}");
            FormView.TypeOfField.Add(FieldType.Text);
            FormView.FieldsCoordinates.Add(GetNextCordinates());
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
        private int[] GetNextCordinates()
        {
            int previousPositionX;
            int previousPositionY;
            int formMenuLength = FormView.FormMenu.Count;
            if (FormView.FormMenu.Count != 0)
            {
                previousPositionX = FormView.FieldsCoordinates[formMenuLength - 1][0];
                previousPositionY = FormView.FieldsCoordinates[formMenuLength - 1][1] + 1;
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
