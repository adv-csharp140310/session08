using App08.Service;
using System.Data;
using System.Reflection;

namespace App08.UI;
public partial class PermissionForm : Form
{
    List<string> checkedButtons = new List<string>();
    RoleService roleService = new RoleService();
    
    public PermissionForm()
    {
        InitializeComponent();
    }

    private void PermissionForm_Load(object sender, EventArgs e)
    {
        comboBoxRole.DisplayMember = "Name";
        comboBoxRole.ValueMember = "Id";
        comboBoxRole.DataSource = roleService.GetAll().ToList();

        var assembly = Assembly.GetExecutingAssembly();
        var forms = assembly.GetTypes().Where(x => x.BaseType == typeof(Form));
        foreach (var form in forms)
        {
            listBoxForms.Items.Add(form.FullName);
        }

    }

    private void listBoxForms_SelectedIndexChanged(object sender, EventArgs e)
    {
        var formName = listBoxForms.SelectedItem as string;
        var formType = Type.GetType(formName);
        var frm = Activator.CreateInstance(formType) as Form;
        checkedListBoxControls.Items.Clear();
        foreach (Control control in frm.Controls)
        {
            if (control is Button btn)
            {
                var key = $"{formName}|{btn.Name}|{btn.Text}";
                checkedListBoxControls.Items.Add(key, checkedButtons.Contains(key));
            }
        }

    }

    private void checkedListBoxControls_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        var buttonName = checkedListBoxControls.SelectedItem as string;
        if (string.IsNullOrEmpty(buttonName))
            return;
        if (e.NewValue == CheckState.Checked)
        {
            checkedButtons.Add(buttonName);
        }
        else
        {
            checkedButtons.Remove(buttonName);
        }
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        PermissionService permissionService = new PermissionService();
        var roleId = (int)comboBoxRole.SelectedValue;
        permissionService.AddPermission(roleId, checkedButtons);
    }

    private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
    {
        PermissionService permissionService = new PermissionService();
        checkedButtons.Clear();
        var roleId = (int)comboBoxRole.SelectedValue;
        checkedButtons = permissionService.GetRolePermissions(roleId);
    }
}
