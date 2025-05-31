namespace FormController.Components.Forms
{
    internal class FormNavigation
    {
        public int FieldPosition { get; set; } = 0;
        public int PreviousPosition { get; set; } = 0;
        public int MaxFieldPosition { get; set; } = 0;
        public void ChangePosition(ConsoleKey key)
        {
            switch(key)
            {
                case ConsoleKey.DownArrow:
                    FieldPosition = FieldPosition == MaxFieldPosition - 1 ? FieldPosition : FieldPosition += 1;
                    PreviousPosition = FieldPosition - 1;
                    break;
                case ConsoleKey.UpArrow:
                    FieldPosition = FieldPosition == 0 ? FieldPosition : FieldPosition -= 1;
                    PreviousPosition = FieldPosition + 1;
                    break;
            }
        }
    }
}
