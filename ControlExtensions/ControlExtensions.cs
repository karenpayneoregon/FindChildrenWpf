using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlExtensions
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Get a collection of a specific type of control from a control or form.
        /// </summary>
        /// <typeparam name="T">Type of control</typeparam>
        /// <param name="control">Control to traverse</param>
        /// <returns>IEnumerable of T</returns>
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T thisControl = child as T;
                if (thisControl != null)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
        public static List<TextBox> TextBoxList(this Control container) => 
            container.Descendants<TextBox>().ToList();

        public static List<Label> LabelList(this Control container) => 
            container.Descendants<Label>().ToList();

        public static List<DataGridView> DataGridViewList(this Control container) => 
            container.Descendants<DataGridView>().ToList();

        public static List<ListView> ListViewViewList(this Control container) => 
            container.Descendants<ListView>().ToList();

        public static List<CheckBox> CheckBoxList(this Control container) => 
            container.Descendants<CheckBox>().ToList();

        public static List<ComboBox> ComboBoxList(this Control container) => 
            container.Descendants<ComboBox>().ToList();

        public static List<ListBox> ListBoxList(this Control container) => 
            container.Descendants<ListBox>().ToList();

        public static List<DateTimePicker> DateTimePickerList(this Control container) => 
            container.Descendants<DateTimePicker>().ToList();

        public static List<PictureBox> PictureBoxList(this Control container) => 
            container.Descendants<PictureBox>().ToList();

        public static List<Panel> PanelList(this Control container) => 
            container.Descendants<Panel>().ToList();

        public static List<GroupBox> GroupBoxList(this Control container) => 
            container.Descendants<GroupBox>().ToList();

        public static List<Button> ButtonList(this Control container) => 
            container.Descendants<Button>().ToList();

        public static List<RadioButton> RadioButtonList(this Control container) => 
            container.Descendants<RadioButton>().ToList();

        public static List<NumericUpDown> NumericUpDownList(this Control container) => 
            container.Descendants<NumericUpDown>().ToList();

        public static RadioButton RadioButtonChecked(this Control container, bool pChecked = true) =>
            container.Descendants<RadioButton>().ToList()
                .FirstOrDefault((radioButton) => radioButton.Checked == pChecked);

        public static string[] ControlNames(this IEnumerable<Control> container) => 
            container.Select((control) => 
            control.Name).ToArray();
    }
}