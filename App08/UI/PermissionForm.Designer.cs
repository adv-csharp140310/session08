namespace App08.UI;

partial class PermissionForm
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
        label1 = new Label();
        comboBoxRole = new ComboBox();
        label2 = new Label();
        listBoxForms = new ListBox();
        checkedListBoxControls = new CheckedListBox();
        buttonSave = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 30);
        label1.Name = "label1";
        label1.Size = new Size(30, 15);
        label1.TabIndex = 0;
        label1.Text = "Role";
        // 
        // comboBoxRole
        // 
        comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxRole.FormattingEnabled = true;
        comboBoxRole.Location = new Point(69, 27);
        comboBoxRole.Name = "comboBoxRole";
        comboBoxRole.Size = new Size(733, 23);
        comboBoxRole.TabIndex = 1;
        comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 78);
        label2.Name = "label2";
        label2.Size = new Size(35, 15);
        label2.TabIndex = 2;
        label2.Text = "Form";
        // 
        // listBoxForms
        // 
        listBoxForms.FormattingEnabled = true;
        listBoxForms.Location = new Point(69, 78);
        listBoxForms.Name = "listBoxForms";
        listBoxForms.Size = new Size(343, 484);
        listBoxForms.TabIndex = 3;
        listBoxForms.SelectedIndexChanged += listBoxForms_SelectedIndexChanged;
        // 
        // checkedListBoxControls
        // 
        checkedListBoxControls.FormattingEnabled = true;
        checkedListBoxControls.Location = new Point(418, 78);
        checkedListBoxControls.Name = "checkedListBoxControls";
        checkedListBoxControls.Size = new Size(384, 490);
        checkedListBoxControls.TabIndex = 4;
        checkedListBoxControls.ItemCheck += checkedListBoxControls_ItemCheck;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(727, 598);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(75, 23);
        buttonSave.TabIndex = 5;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // PermissionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(814, 633);
        Controls.Add(buttonSave);
        Controls.Add(checkedListBoxControls);
        Controls.Add(listBoxForms);
        Controls.Add(label2);
        Controls.Add(comboBoxRole);
        Controls.Add(label1);
        Name = "PermissionForm";
        Text = "PermissionForm";
        Load += PermissionForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private ComboBox comboBoxRole;
    private Label label2;
    private ListBox listBoxForms;
    private CheckedListBox checkedListBoxControls;
    private Button buttonSave;
}