using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MoviePoster
{
    public static class ValidationHelper
    {
        public static bool IsValid(params TextBox[] textfields)
        {
            foreach (var field in textfields)
            {
                if (string.IsNullOrWhiteSpace(field.Text))
                {
                    MessageBox.Show($"Поле {field.Name} не должно быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public static bool CheckTextFields(Form form, params TextBox[] textBoxes)
        {
            return IsValid(textBoxes);
        }

        public static bool AreObjectsValid(Form form, params string[] controlNames)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox && !controlNames.Contains(control.Name))
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show($"Пожалуйста, заполните поле {control.Name}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool AreComboBoxesValid(Form form, params string[] comboBoxNames)
        {
            foreach (string comboBoxName in comboBoxNames)
            {
                ComboBox comboBox = form.Controls[comboBoxName] as ComboBox;

                if (comboBox != null && comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show($"Пожалуйста, выберите значение в {comboBoxName}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}
