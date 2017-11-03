namespace EmployeeApp
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            System.Windows.Forms.Label personellNumberLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label scheduleCodeLabel;
            this.powiDataSet = new EmployeeApp.PowiDataSet();
            this.personalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalInfoTableAdapter = new EmployeeApp.PowiDataSetTableAdapters.PersonalInfoTableAdapter();
            this.tableAdapterManager = new EmployeeApp.PowiDataSetTableAdapters.TableAdapterManager();
            this.personalInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.personalInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personellNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.scheduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.personalInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddemployeeLabel = new System.Windows.Forms.Label();
            this.AddScheduleBtn = new System.Windows.Forms.Button();
            personellNumberLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            scheduleCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.powiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingNavigator)).BeginInit();
            this.personalInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // personalInfoTableAdapter
            // 
            this.personalInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonalInfoTableAdapter = this.personalInfoTableAdapter;
            this.tableAdapterManager.ScheduleFileTableAdapter = null;
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
            this.personalInfoBindingNavigator.Size = new System.Drawing.Size(781, 25);
            this.personalInfoBindingNavigator.TabIndex = 0;
            this.personalInfoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // personalInfoBindingNavigatorSaveItem
            // 
            this.personalInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personalInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personalInfoBindingNavigatorSaveItem.Image")));
            this.personalInfoBindingNavigatorSaveItem.Name = "personalInfoBindingNavigatorSaveItem";
            this.personalInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personalInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.personalInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.personalInfoBindingNavigatorSaveItem_Click);
            // 
            // personellNumberLabel
            // 
            personellNumberLabel.AutoSize = true;
            personellNumberLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personellNumberLabel.Location = new System.Drawing.Point(190, 166);
            personellNumberLabel.Name = "personellNumberLabel";
            personellNumberLabel.Size = new System.Drawing.Size(127, 16);
            personellNumberLabel.TabIndex = 3;
            personellNumberLabel.Text = "Personell Number:";
            // 
            // personellNumberTextBox
            // 
            this.personellNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalInfoBindingSource, "PersonellNumber", true));
            this.personellNumberTextBox.Location = new System.Drawing.Point(323, 164);
            this.personellNumberTextBox.Name = "personellNumberTextBox";
            this.personellNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.personellNumberTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(232, 192);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(85, 16);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalInfoBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(323, 190);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(237, 216);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 16);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalInfoBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(323, 216);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // scheduleCodeLabel
            // 
            scheduleCodeLabel.AutoSize = true;
            scheduleCodeLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scheduleCodeLabel.Location = new System.Drawing.Point(216, 244);
            scheduleCodeLabel.Name = "scheduleCodeLabel";
            scheduleCodeLabel.Size = new System.Drawing.Size(101, 16);
            scheduleCodeLabel.TabIndex = 9;
            scheduleCodeLabel.Text = "Schedule Code:";
            // 
            // scheduleCodeTextBox
            // 
            this.scheduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalInfoBindingSource, "ScheduleCode", true));
            this.scheduleCodeTextBox.Location = new System.Drawing.Point(323, 242);
            this.scheduleCodeTextBox.Name = "scheduleCodeTextBox";
            this.scheduleCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.scheduleCodeTextBox.TabIndex = 10;
            // 
            // personalInfoDataGridView
            // 
            this.personalInfoDataGridView.AutoGenerateColumns = false;
            this.personalInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personalInfoDataGridView.DataSource = this.personalInfoBindingSource;
            this.personalInfoDataGridView.Location = new System.Drawing.Point(123, 342);
            this.personalInfoDataGridView.Name = "personalInfoDataGridView";
            this.personalInfoDataGridView.Size = new System.Drawing.Size(547, 167);
            this.personalInfoDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonellNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "PersonellNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ScheduleCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "ScheduleCode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // AddemployeeLabel
            // 
            this.AddemployeeLabel.AutoSize = true;
            this.AddemployeeLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddemployeeLabel.Location = new System.Drawing.Point(291, 100);
            this.AddemployeeLabel.Name = "AddemployeeLabel";
            this.AddemployeeLabel.Size = new System.Drawing.Size(153, 24);
            this.AddemployeeLabel.TabIndex = 11;
            this.AddemployeeLabel.Text = "Add employee";
            // 
            // AddScheduleBtn
            // 
            this.AddScheduleBtn.BackColor = System.Drawing.SystemColors.Window;
            this.AddScheduleBtn.Location = new System.Drawing.Point(684, 0);
            this.AddScheduleBtn.Name = "AddScheduleBtn";
            this.AddScheduleBtn.Size = new System.Drawing.Size(97, 25);
            this.AddScheduleBtn.TabIndex = 12;
            this.AddScheduleBtn.Text = "Add schedule";
            this.AddScheduleBtn.UseVisualStyleBackColor = false;
            this.AddScheduleBtn.Click += new System.EventHandler(this.AddScheduleBtn_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 594);
            this.Controls.Add(this.AddScheduleBtn);
            this.Controls.Add(this.AddemployeeLabel);
            this.Controls.Add(this.personalInfoDataGridView);
            this.Controls.Add(personellNumberLabel);
            this.Controls.Add(this.personellNumberTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(scheduleCodeLabel);
            this.Controls.Add(this.scheduleCodeTextBox);
            this.Controls.Add(this.personalInfoBindingNavigator);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.powiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoBindingNavigator)).EndInit();
            this.personalInfoBindingNavigator.ResumeLayout(false);
            this.personalInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PowiDataSet powiDataSet;
        private System.Windows.Forms.BindingSource personalInfoBindingSource;
        private PowiDataSetTableAdapters.PersonalInfoTableAdapter personalInfoTableAdapter;
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
        private System.Windows.Forms.DataGridView personalInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label AddemployeeLabel;
        private System.Windows.Forms.Button AddScheduleBtn;
    }
}