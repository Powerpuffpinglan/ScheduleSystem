namespace EmployeeApp
{
    partial class AddSchedule
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
            System.Windows.Forms.Label scheduleCodeLabel;
            System.Windows.Forms.Label validFromLabel;
            System.Windows.Forms.Label validToLabel;
            System.Windows.Forms.Label uploaderLabel;
            System.Windows.Forms.Label scheduleFileNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSchedule));
            this.powiDataSet = new EmployeeApp.PowiDataSet();
            this.scheduleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableTableAdapter = new EmployeeApp.PowiDataSetTableAdapters.ScheduleTableTableAdapter();
            this.tableAdapterManager = new EmployeeApp.PowiDataSetTableAdapters.TableAdapterManager();
            this.scheduleTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.scheduleTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.scheduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.validFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.validToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uploaderTextBox = new System.Windows.Forms.TextBox();
            this.scheduleFileNameTextBox = new System.Windows.Forms.TextBox();
            this.addScheduleLable = new System.Windows.Forms.Label();
            this.fileUploaderLabel = new System.Windows.Forms.Label();
            this.choseFilBnt = new System.Windows.Forms.Button();
            this.addEmployeeBnt = new System.Windows.Forms.Button();
            this.scheduleFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleFileTableAdapter = new EmployeeApp.PowiDataSetTableAdapters.ScheduleFileTableAdapter();
            this.scheduleTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            scheduleCodeLabel = new System.Windows.Forms.Label();
            validFromLabel = new System.Windows.Forms.Label();
            validToLabel = new System.Windows.Forms.Label();
            uploaderLabel = new System.Windows.Forms.Label();
            scheduleFileNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.powiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingNavigator)).BeginInit();
            this.scheduleTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleCodeLabel
            // 
            scheduleCodeLabel.AutoSize = true;
            scheduleCodeLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scheduleCodeLabel.Location = new System.Drawing.Point(163, 138);
            scheduleCodeLabel.Name = "scheduleCodeLabel";
            scheduleCodeLabel.Size = new System.Drawing.Size(101, 16);
            scheduleCodeLabel.TabIndex = 1;
            scheduleCodeLabel.Text = "Schedule Code:";
            // 
            // validFromLabel
            // 
            validFromLabel.AutoSize = true;
            validFromLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            validFromLabel.Location = new System.Drawing.Point(163, 166);
            validFromLabel.Name = "validFromLabel";
            validFromLabel.Size = new System.Drawing.Size(86, 16);
            validFromLabel.TabIndex = 3;
            validFromLabel.Text = "Valid From:";
            // 
            // validToLabel
            // 
            validToLabel.AutoSize = true;
            validToLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            validToLabel.Location = new System.Drawing.Point(163, 193);
            validToLabel.Name = "validToLabel";
            validToLabel.Size = new System.Drawing.Size(67, 16);
            validToLabel.TabIndex = 5;
            validToLabel.Text = "Valid To:";
            // 
            // uploaderLabel
            // 
            uploaderLabel.AutoSize = true;
            uploaderLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uploaderLabel.Location = new System.Drawing.Point(163, 216);
            uploaderLabel.Name = "uploaderLabel";
            uploaderLabel.Size = new System.Drawing.Size(72, 16);
            uploaderLabel.TabIndex = 7;
            uploaderLabel.Text = "Uploader:";
            // 
            // scheduleFileNameLabel
            // 
            scheduleFileNameLabel.AutoSize = true;
            scheduleFileNameLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scheduleFileNameLabel.Location = new System.Drawing.Point(125, 242);
            scheduleFileNameLabel.Name = "scheduleFileNameLabel";
            scheduleFileNameLabel.Size = new System.Drawing.Size(139, 16);
            scheduleFileNameLabel.TabIndex = 9;
            scheduleFileNameLabel.Text = "Schedule File Name:";
            // 
            // powiDataSet
            // 
            this.powiDataSet.DataSetName = "PowiDataSet";
            this.powiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleTableBindingSource
            // 
            this.scheduleTableBindingSource.DataMember = "ScheduleTable";
            this.scheduleTableBindingSource.DataSource = this.powiDataSet;
            // 
            // scheduleTableTableAdapter
            // 
            this.scheduleTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonalInfoTableAdapter = null;
            this.tableAdapterManager.ScheduleFileTableAdapter = null;
            this.tableAdapterManager.ScheduleTableTableAdapter = this.scheduleTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmployeeApp.PowiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // scheduleTableBindingNavigator
            // 
            this.scheduleTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scheduleTableBindingNavigator.BindingSource = this.scheduleTableBindingSource;
            this.scheduleTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scheduleTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.scheduleTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.scheduleTableBindingNavigatorSaveItem});
            this.scheduleTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.scheduleTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.scheduleTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.scheduleTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.scheduleTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.scheduleTableBindingNavigator.Name = "scheduleTableBindingNavigator";
            this.scheduleTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.scheduleTableBindingNavigator.Size = new System.Drawing.Size(738, 25);
            this.scheduleTableBindingNavigator.TabIndex = 0;
            this.scheduleTableBindingNavigator.Text = "bindingNavigator1";
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
            // scheduleTableBindingNavigatorSaveItem
            // 
            this.scheduleTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scheduleTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleTableBindingNavigatorSaveItem.Image")));
            this.scheduleTableBindingNavigatorSaveItem.Name = "scheduleTableBindingNavigatorSaveItem";
            this.scheduleTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.scheduleTableBindingNavigatorSaveItem.Text = "Save Data";
            this.scheduleTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.scheduleTableBindingNavigatorSaveItem_Click);
            // 
            // scheduleCodeTextBox
            // 
            this.scheduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleTableBindingSource, "ScheduleCode", true));
            this.scheduleCodeTextBox.Location = new System.Drawing.Point(270, 136);
            this.scheduleCodeTextBox.Name = "scheduleCodeTextBox";
            this.scheduleCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.scheduleCodeTextBox.TabIndex = 2;
            // 
            // validFromDateTimePicker
            // 
            this.validFromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduleTableBindingSource, "ValidFrom", true));
            this.validFromDateTimePicker.Location = new System.Drawing.Point(270, 162);
            this.validFromDateTimePicker.Name = "validFromDateTimePicker";
            this.validFromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.validFromDateTimePicker.TabIndex = 4;
            // 
            // validToDateTimePicker
            // 
            this.validToDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduleTableBindingSource, "ValidTo", true));
            this.validToDateTimePicker.Location = new System.Drawing.Point(270, 188);
            this.validToDateTimePicker.Name = "validToDateTimePicker";
            this.validToDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.validToDateTimePicker.TabIndex = 6;
            // 
            // uploaderTextBox
            // 
            this.uploaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleTableBindingSource, "Uploader", true));
            this.uploaderTextBox.Location = new System.Drawing.Point(270, 214);
            this.uploaderTextBox.Name = "uploaderTextBox";
            this.uploaderTextBox.Size = new System.Drawing.Size(200, 20);
            this.uploaderTextBox.TabIndex = 8;
            // 
            // scheduleFileNameTextBox
            // 
            this.scheduleFileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleTableBindingSource, "ScheduleFileName", true));
            this.scheduleFileNameTextBox.Location = new System.Drawing.Point(270, 240);
            this.scheduleFileNameTextBox.Name = "scheduleFileNameTextBox";
            this.scheduleFileNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.scheduleFileNameTextBox.TabIndex = 10;
            // 
            // addScheduleLable
            // 
            this.addScheduleLable.AutoSize = true;
            this.addScheduleLable.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScheduleLable.Location = new System.Drawing.Point(293, 58);
            this.addScheduleLable.Name = "addScheduleLable";
            this.addScheduleLable.Size = new System.Drawing.Size(145, 24);
            this.addScheduleLable.TabIndex = 11;
            this.addScheduleLable.Text = "Add schedule";
            // 
            // fileUploaderLabel
            // 
            this.fileUploaderLabel.AutoSize = true;
            this.fileUploaderLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileUploaderLabel.Location = new System.Drawing.Point(502, 41);
            this.fileUploaderLabel.Name = "fileUploaderLabel";
            this.fileUploaderLabel.Size = new System.Drawing.Size(143, 16);
            this.fileUploaderLabel.TabIndex = 12;
            this.fileUploaderLabel.Text = "Here you chose a file";
            this.fileUploaderLabel.Click += new System.EventHandler(this.fileUploaderLabel_Click);
            // 
            // choseFilBnt
            // 
            this.choseFilBnt.BackColor = System.Drawing.SystemColors.Window;
            this.choseFilBnt.Location = new System.Drawing.Point(651, 37);
            this.choseFilBnt.Name = "choseFilBnt";
            this.choseFilBnt.Size = new System.Drawing.Size(75, 23);
            this.choseFilBnt.TabIndex = 13;
            this.choseFilBnt.Text = "Chose file";
            this.choseFilBnt.UseVisualStyleBackColor = false;
            this.choseFilBnt.Click += new System.EventHandler(this.choseFilBnt_Click);
            // 
            // addEmployeeBnt
            // 
            this.addEmployeeBnt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addEmployeeBnt.BackColor = System.Drawing.SystemColors.Window;
            this.addEmployeeBnt.Location = new System.Drawing.Point(641, 0);
            this.addEmployeeBnt.Name = "addEmployeeBnt";
            this.addEmployeeBnt.Size = new System.Drawing.Size(97, 25);
            this.addEmployeeBnt.TabIndex = 14;
            this.addEmployeeBnt.Text = "Add employee";
            this.addEmployeeBnt.UseVisualStyleBackColor = false;
            this.addEmployeeBnt.Click += new System.EventHandler(this.addEmployeeBnt_Click);
            // 
            // scheduleFileBindingSource
            // 
            this.scheduleFileBindingSource.DataMember = "ScheduleFile";
            this.scheduleFileBindingSource.DataSource = this.powiDataSet;
            // 
            // scheduleFileTableAdapter
            // 
            this.scheduleFileTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleTableDataGridView
            // 
            this.scheduleTableDataGridView.AutoGenerateColumns = false;
            this.scheduleTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.scheduleTableDataGridView.DataSource = this.scheduleTableBindingSource;
            this.scheduleTableDataGridView.Location = new System.Drawing.Point(99, 331);
            this.scheduleTableDataGridView.Name = "scheduleTableDataGridView";
            this.scheduleTableDataGridView.Size = new System.Drawing.Size(546, 242);
            this.scheduleTableDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ScheduleCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "ScheduleCode";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ValidFrom";
            this.dataGridViewTextBoxColumn7.HeaderText = "ValidFrom";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ValidTo";
            this.dataGridViewTextBoxColumn8.HeaderText = "ValidTo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Uploader";
            this.dataGridViewTextBoxColumn9.HeaderText = "Uploader";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ScheduleFileName";
            this.dataGridViewTextBoxColumn10.HeaderText = "ScheduleFileName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // AddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 733);
            this.Controls.Add(this.scheduleTableDataGridView);
            this.Controls.Add(this.addEmployeeBnt);
            this.Controls.Add(this.choseFilBnt);
            this.Controls.Add(this.fileUploaderLabel);
            this.Controls.Add(this.addScheduleLable);
            this.Controls.Add(scheduleCodeLabel);
            this.Controls.Add(this.scheduleCodeTextBox);
            this.Controls.Add(validFromLabel);
            this.Controls.Add(this.validFromDateTimePicker);
            this.Controls.Add(validToLabel);
            this.Controls.Add(this.validToDateTimePicker);
            this.Controls.Add(uploaderLabel);
            this.Controls.Add(this.uploaderTextBox);
            this.Controls.Add(scheduleFileNameLabel);
            this.Controls.Add(this.scheduleFileNameTextBox);
            this.Controls.Add(this.scheduleTableBindingNavigator);
            this.Name = "AddSchedule";
            this.Text = "AddSchedule";
            this.Load += new System.EventHandler(this.AddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.powiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingNavigator)).EndInit();
            this.scheduleTableBindingNavigator.ResumeLayout(false);
            this.scheduleTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PowiDataSet powiDataSet;
        private System.Windows.Forms.BindingSource scheduleTableBindingSource;
        private PowiDataSetTableAdapters.ScheduleTableTableAdapter scheduleTableTableAdapter;
        private PowiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator scheduleTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton scheduleTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox scheduleCodeTextBox;
        private System.Windows.Forms.DateTimePicker validFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker validToDateTimePicker;
        private System.Windows.Forms.TextBox uploaderTextBox;
        private System.Windows.Forms.TextBox scheduleFileNameTextBox;
        private System.Windows.Forms.Label addScheduleLable;
        private System.Windows.Forms.Label fileUploaderLabel;
        private System.Windows.Forms.Button choseFilBnt;
        private System.Windows.Forms.Button addEmployeeBnt;
        private System.Windows.Forms.BindingSource scheduleFileBindingSource;
        private PowiDataSetTableAdapters.ScheduleFileTableAdapter scheduleFileTableAdapter;
        private System.Windows.Forms.DataGridView scheduleTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}