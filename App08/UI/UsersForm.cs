

using App08.Model;
using App08.Service;
using App08.Utils;

namespace App08.UI;
public partial class UsersForm : Form
{
    int currentPage = 1;
    int totalPages = 1;
    int pageSize = 3;

    public UsersForm()
    {
        InitializeComponent();
    }

    private void UsersForm_Load(object sender, EventArgs e)
    {
        groupBoxUsers.DesignForm(typeof(User));
        comboBoxIsActive.SelectedIndex = 0;
        loadData();
    }

    private void groupBoxUsers_Enter(object sender, EventArgs e)
    {

    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        var model = groupBoxUsers.GetFormData(new User());
        UserService service = new UserService();        
        service.Add(model);
        loadData();
        groupBoxUsers.SetFormData(new User());
    }

    private void loadData()
    {
        bool? isActive = null;
        if (comboBoxIsActive.SelectedItem != "All")
        {
            isActive = comboBoxIsActive.SelectedItem == "Active";
        }

        UserService service = new UserService();
        var (users, total) = service.LoadData(isActive, textBoxName.Text, currentPage - 1, pageSize);

        dataGridViewUsers.DataSource = users;
        totalPages = Convert.ToInt32(Math.Ceiling(total / Convert.ToDecimal(pageSize)));
        labelPage.Text = $"{currentPage}/{totalPages}";

        //Linq - IEnumerable
    }

    private void buttonFirst_Click(object sender, EventArgs e)
    {
        currentPage = 1;
        loadData();
    }

    private void buttonPrev_Click(object sender, EventArgs e)
    {
        if (currentPage > 1)
        {
            currentPage -= 1;
            loadData();
        }
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
        if (currentPage < totalPages)
        {
            currentPage += 1;
            loadData();
        }
    }

    private void buttonLast_Click(object sender, EventArgs e)
    {
        currentPage = totalPages;
        loadData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        loadData();
    }
}
