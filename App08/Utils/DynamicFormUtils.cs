using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace App08.Utils;
public static class DynamicFormUtils
{
        public static void DesignForm(this Control target, Type type)
    {
        int yOffset = 20;
        foreach (var propertyInfo in type.GetProperties())
        {
            // Skip properties with the NoUIAttribute
            if (propertyInfo.GetCustomAttribute(typeof(NoUIAttribute)) != null)
                continue;

            var label = new Label
            {
                Text = propertyInfo.Name + ": ",
                Location = new Point(20, yOffset),
                AutoSize = true,
            };
            var display = propertyInfo.GetCustomAttribute(typeof(DisplayAttribute));
            if (display is DisplayAttribute dis)
            {
                label.Text = dis.Name + ": ";
            }

            Control control = null;

            // Check if the property has a UIControlAttribute
            var uiControlAttribute = propertyInfo.GetCustomAttribute(typeof(UIControlAttribute)) as UIControlAttribute;
            if (uiControlAttribute != null)
            {
                control = CreateCustomControl(uiControlAttribute);
            }
            else
            {
                control = CreateControl(propertyInfo.PropertyType);
            }

            control.Location = new Point(200, yOffset);
            control.Width = 200;
            control.Tag = propertyInfo; // Cache

            target.Controls.Add(label);
            target.Controls.Add(control);

            yOffset += 30;
        }
    }

    private static Control CreateCustomControl(UIControlAttribute uiControlAttribute)
    {
        var control = Activator.CreateInstance(uiControlAttribute.ControlType, uiControlAttribute.ControlParameters) as Control;
        if (control == null)
        {
            throw new InvalidOperationException("The specified control type is not a valid Control.");
        }

        // If the control is a ComboBox and a DataProviderType is provided, use it to populate the items
        if (control is ComboBox comboBox && uiControlAttribute.DataProviderType != null)
        {
            if (Activator.CreateInstance(uiControlAttribute.DataProviderType) is IDataProvider dataProvider)
            {
                var data = dataProvider.GetData();
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.Items.AddRange(data.ToArray());
                comboBox.DisplayMember = "Display";
                comboBox.ValueMember = "Value";
            }
            else
            {
                throw new InvalidOperationException("The specified DataProviderType does not implement IDataProvider.");
            }
        }

        return control;
    }


    private static Control CreateControl(Type Prop)
    {
        if (Prop == typeof(int))
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Maximum = int.MaxValue;
            return numericUpDown;
        };
        if (Prop == typeof(string)) return new TextBox();
        if (Prop == typeof(Boolean)) return new CheckBox();
        if (Prop == typeof(DateTime)) return new DateTimePicker();
        return new Control();
    }

    public static void SetFormData(this Control target, object model)
    {
        foreach (Control control in target.Controls)
        {
           if(control.Tag is PropertyInfo property)
            {
                if(control is TextBox textBox)
                {
                    textBox.Text = Convert.ToString(property.GetValue(model));
                }
                if (control is NumericUpDown numeric)
                {                    
                    numeric.Value = Convert.ToInt32(property.GetValue(model));
                }
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = Convert.ToBoolean(property.GetValue(model));
                }
            }
        }
    }

    public static T GetFormData<T>(this Control target, T model)
    {      
        foreach (Control control in target.Controls)
        {
            if (control.Tag is PropertyInfo property)
            {
                object value = null;
                if (control is TextBox textBox)
                {
                    value = textBox.Text;
                }
                if (control is NumericUpDown numeric)
                {
                    value =Convert.ToInt32(numeric.Value);
                }
                if (control is CheckBox checkBox)
                {
                    value = checkBox.Checked;
                }
                property.SetValue(model, value);
            }
        }

        return model;
    }


    
}

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class UIControlAttribute : Attribute
{
    public Type ControlType { get; private set; }
    public object[] ControlParameters { get; private set; }
    public Type DataProviderType { get; private set; }

    public UIControlAttribute(Type controlType, params object[] controlParameters)
    {
        ControlType = controlType;
        ControlParameters = controlParameters;
    }

    public UIControlAttribute(Type controlType, Type dataProviderType, params object[] controlParameters)
    {
        ControlType = controlType;
        DataProviderType = dataProviderType;
        ControlParameters = controlParameters;
    }
}


[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class NoUIAttribute : Attribute
{
}

public interface IDataProvider
{
    IEnumerable<object> GetData();
}



public class ComboBoxItem
{
    public object Value { get; set; }
    public string Display { get; set; }

    public override string ToString()
    {
        return Display; // This ensures the ComboBox displays the Display property
    }
}