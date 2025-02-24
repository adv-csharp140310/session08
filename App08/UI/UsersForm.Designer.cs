namespace App08.UI;

partial class UsersForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBoxUsers = new GroupBox();
        buttonSave = new Button();
        dataGridViewUsers = new DataGridView();
        buttonLast = new Button();
        buttonNext = new Button();
        buttonPrev = new Button();
        buttonFirst = new Button();
        labelPage = new Label();
        label1 = new Label();
        comboBoxIsActive = new ComboBox();
        button1 = new Button();
        label2 = new Label();
        textBoxName = new TextBox();
        groupBoxUsers.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
        SuspendLayout();
        // 
        // groupBoxUsers
        // 
        groupBoxUsers.Controls.Add(buttonSave);
        groupBoxUsers.Location = new Point(12, 12);
        groupBoxUsers.Name = "groupBoxUsers";
        groupBoxUsers.Size = new Size(965, 276);
        groupBoxUsers.TabIndex = 0;
        groupBoxUsers.TabStop = false;
        groupBoxUsers.Text = "groupBoxUsers";
        groupBoxUsers.Enter += groupBoxUsers_Enter;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(884, 247);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(75, 23);
        buttonSave.TabIndex = 0;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // dataGridViewUsers
        // 
        dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewUsers.Location = new Point(12, 352);
        dataGridViewUsers.Name = "dataGridViewUsers";
        dataGridViewUsers.Size = new Size(965, 256);
        dataGridViewUsers.TabIndex = 1;
        // 
        // buttonLast
        // 
        buttonLast.Location = new Point(12, 625);
        buttonLast.Name = "buttonLast";
        buttonLast.Size = new Size(90, 33);
        buttonLast.TabIndex = 2;
        buttonLast.Text = "<<";
        buttonLast.UseVisualStyleBackColor = true;
        buttonLast.Click += buttonLast_Click;
        // 
        // buttonNext
        // 
        buttonNext.Location = new Point(108, 625);
        buttonNext.Name = "buttonNext";
        buttonNext.Size = new Size(90, 33);
        buttonNext.TabIndex = 3;
        buttonNext.Text = "<";
        buttonNext.UseVisualStyleBackColor = true;
        buttonNext.Click += buttonNext_Click;
        // 
        // buttonPrev
        // 
        buttonPrev.Location = new Point(288, 625);
        buttonPrev.Name = "buttonPrev";
        buttonPrev.Size = new Size(90, 33);
        buttonPrev.TabIndex = 4;
        buttonPrev.Text = ">";
        buttonPrev.UseVisualStyleBackColor = true;
        buttonPrev.Click += buttonPrev_Click;
        // 
        // buttonFirst
        // 
        buttonFirst.Location = new Point(384, 625);
        buttonFirst.Name = "buttonFirst";
        buttonFirst.Size = new Size(90, 33);
        buttonFirst.TabIndex = 5;
        buttonFirst.Text = ">>";
        buttonFirst.UseVisualStyleBackColor = true;
        buttonFirst.Click += buttonFirst_Click;
        // 
        // labelPage
        // 
        labelPage.AutoSize = true;
        labelPage.Location = new Point(229, 634);
        labelPage.Name = "labelPage";
        labelPage.Size = new Size(30, 15);
        labelPage.TabIndex = 6;
        labelPage.Text = "1/10";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 312);
        label1.Name = "label1";
        label1.Size = new Size(48, 15);
        label1.TabIndex = 7;
        label1.Text = "IsActive";
        // 
        // comboBoxIsActive
        // 
        comboBoxIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxIsActive.FormattingEnabled = true;
        comboBoxIsActive.Items.AddRange(new object[] { "All", "Active", "Inactive" });
        comboBoxIsActive.Location = new Point(66, 309);
        comboBoxIsActive.Name = "comboBoxIsActive";
        comboBoxIsActive.Size = new Size(121, 23);
        comboBoxIsActive.TabIndex = 8;
        // 
        // button1
        // 
        button1.Location = new Point(896, 308);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 9;
        button1.Text = "Search";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(218, 312);
        label2.Name = "label2";
        label2.Size = new Size(39, 15);
        label2.TabIndex = 10;
        label2.Text = "Name";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(263, 308);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(134, 23);
        textBoxName.TabIndex = 11;
        // 
        // UsersForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(989, 670);
        Controls.Add(textBoxName);
        Controls.Add(label2);
        Controls.Add(button1);
        Controls.Add(comboBoxIsActive);
        Controls.Add(label1);
        Controls.Add(labelPage);
        Controls.Add(buttonFirst);
        Controls.Add(buttonPrev);
        Controls.Add(buttonNext);
        Controls.Add(buttonLast);
        Controls.Add(dataGridViewUsers);
        Controls.Add(groupBoxUsers);
        Name = "UsersForm";
        Text = "UsersForm";
        Load += UsersForm_Load;
        groupBoxUsers.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBoxUsers;
    private DataGridView dataGridViewUsers;
    private Button buttonSave;
    private Button buttonLast;
    private Button buttonNext;
    private Button buttonPrev;
    private Button buttonFirst;
    private Label labelPage;
    private Label label1;
    private ComboBox comboBoxIsActive;
    private Button button1;
    private Label label2;
    private TextBox textBoxName;
}