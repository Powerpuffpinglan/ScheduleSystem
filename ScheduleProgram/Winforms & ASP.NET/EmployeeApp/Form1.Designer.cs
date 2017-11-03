namespace EmployeeApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label personellNumberLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label scheduleCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.personalInfoTableAdapter1 = new EmployeeApp.PowiDataSetTableAdapters.PersonalInfoTableAdapter();
            this.powiDataSet = new EmployeeApp.PowiDataSet();
            this.personalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new EmployeeApp.PowiDataSetTableAdapters.TableAdapterManager();
            this.personalInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personalInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personellNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.scheduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddScheduleBtn = new System.Windows.Forms.Button();
            personellNumberLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            scheduleCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.powiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingNavigator)).BeginInit();
            this.personalInfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // personellNumberLabel
            // 
            personellNumberLabel.AutoSize = true;
            personellNumberLabel.Location = new System.Drawing.Point(123, 100);
            personellNumberLabel.Name = "personellNumberLabel";
            personellNumberLabel.Size = new System.Drawing.Size(93, 13);
            personellNumberLabel.TabIndex = 13;
            personellNumberLabel.Text = "Personell Number:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(123, 126);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(123, 152);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 17;
            lastNameLabel.Text = "Last Name:";
            // 
            // scheduleCodeLabel
            // 
            scheduleCodeLabel.AutoSize = true;
            scheduleCodeLabel.Location = new System.Drawing.Point(123, 178);
            scheduleCodeLabel.Name = "scheduleCodeLabel";
            scheduleCodeLabel.Size = new System.Drawing.Size(83, 13);
            scheduleCodeLabel.TabIndex = 19;
            scheduleCodeLabel.Text = "Schedule Code:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(236, 224);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // personalInfoTableAdapter1
            // 
            this.personalInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // powiDataSet
            // 
            this.powiDataSet.DataSetName = "PowiDataSet";
            this.powiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalInfoBindingSource
            // 
            this.personalInfoBindingSource.DataMember = "PersonalInfo";
            this.personalInfoBindingSource.DataSource = this.powiDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonalInfoTableAdapter = this.personalInfoTableAdapter1;
            this.tableAdapterManager.ScheduleTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmployeeApp.PowiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personalInfoBindingNavigator
            // 
            this.personalInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personalInfoBindingNavigator.BindingSource = this.personalInfoBindingSource;
            this.personalInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personalInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personalInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personalInfoBindingNavigatorSaveItem});
            this.personalInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personalInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personalInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personalInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personalInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personalInfoBindingNavigator.Name = "personalInfoBindingNavigator";
            this.personalInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personalInfoBindingNavigator.Size = new System.Drawing.Size(538, 25);
            this.personalInfoBindingNavigator.TabIndex = 11;
            this.personalInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personalInfoBindingNavigatorSaveItem
            // 
            this.personalInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personalInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personalInfoBindingNavigatorSaveItem.Image")));
            this.personalInfoBindingNavigatorSaveItem.Name = "personalInfoBindingNavigatorSaveItem";
            this.personalInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personalInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.personalInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.personalInfoBindingNavigatorSaveItem_Click_1);
            // 
            // personellNumberTextBox
            // 
            this.personellNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalInfoBindingSource, "PersonellNumber", true));
            this.personellNumberTextBox.Location = new System.Drawing.Point(222, 97);
            this.personellNumberTextBox.Name = "personellNumberTextBox";
            this.personellNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.personellNumberTextBox.TabIndex = 14;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalInfoBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(222, 123);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalInfoBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(222, 149);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // scheduleCodeTextBox
            // 
            this.scheduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalInfoBindingSource, "ScheduleCode", true));
            this.scheduleCodeTextBox.Location = new System.Drawing.Point(222, 175);
            this.scheduleCodeTextBox.Name = "scheduleCodeTextBox";
            this.scheduleCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.scheduleCodeTextBox.TabIndex = 20;
            // 
            // AddScheduleBtn
            // 
            this.AddScheduleBtn.Location = new System.Drawing.Point(412, 28);
            this.AddScheduleBtn.Name = "AddScheduleBtn";
            this.AddScheduleBtn.Size = new System.Drawing.Size(101, 20);
            this.AddScheduleBtn.TabIndex = 21;
            this.AddScheduleBtn.Text = "Add schedule";
            this.AddScheduleBtn.UseVisualStyleBackColor = true;
            this.AddScheduleBtn.Click += new System.EventHandler(this.AddScheduleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 396);
            this.Controls.Add(this.AddScheduleBtn);
            this.Controls.Add(personellNumberLabel);
            this.Controls.Add(this.personellNumberTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(scheduleCodeLabel);
            this.Controls.Add(this.scheduleCodeTextBox);
            this.Controls.Add(this.personalInfoBindingNavigator);
            this.Controls.Add(this.SaveBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.powiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingNavigator)).EndInit();
            this.personalInfoBindingNavigator.ResumeLayout(false);
            this.personalInfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn;
        private PowiDataSetTableAdapters.PersonalInfoTableAdapter personalInfoTableAdapter1;
        private PowiDataSet powiDataSet;
        private System.Windows.Forms.BindingSource personalInfoBindingSource;
        private PowiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personalInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personalInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox personellNumberTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox scheduleCodeTextBox;
        private System.Windows.Forms.Button AddScheduleBtn;
    }
}

