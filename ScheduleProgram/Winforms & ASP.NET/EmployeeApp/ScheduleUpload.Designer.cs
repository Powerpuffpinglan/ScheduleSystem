namespace EmployeeApp
{
    partial class ScheduleUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleUpload));
            this.scheduleTableTableAdapter1 = new EmployeeApp.PowiDataSetTableAdapters.ScheduleTableTableAdapter();
            this.powiDataSet = new EmployeeApp.PowiDataSet();
            this.scheduleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.SaveSbtn = new System.Windows.Forms.Button();
            this.ChoseFile = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileUploader = new System.Windows.Forms.Button();
            scheduleCodeLabel = new System.Windows.Forms.Label();
            validFromLabel = new System.Windows.Forms.Label();
            validToLabel = new System.Windows.Forms.Label();
            uploaderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.powiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingNavigator)).BeginInit();
            this.scheduleTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleCodeLabel
            // 
            scheduleCodeLabel.AutoSize = true;
            scheduleCodeLabel.Location = new System.Drawing.Point(156, 96);
            scheduleCodeLabel.Name = "scheduleCodeLabel";
            scheduleCodeLabel.Size = new System.Drawing.Size(83, 13);
            scheduleCodeLabel.TabIndex = 1;
            scheduleCodeLabel.Text = "Schedule Code:";
            // 
            // validFromLabel
            // 
            validFromLabel.AutoSize = true;
            validFromLabel.Location = new System.Drawing.Point(156, 123);
            validFromLabel.Name = "validFromLabel";
            validFromLabel.Size = new System.Drawing.Size(59, 13);
            validFromLabel.TabIndex = 3;
            validFromLabel.Text = "Valid From:";
            // 
            // validToLabel
            // 
            validToLabel.AutoSize = true;
            validToLabel.Location = new System.Drawing.Point(156, 149);
            validToLabel.Name = "validToLabel";
            validToLabel.Size = new System.Drawing.Size(49, 13);
            validToLabel.TabIndex = 5;
            validToLabel.Text = "Valid To:";
            // 
            // uploaderLabel
            // 
            uploaderLabel.AutoSize = true;
            uploaderLabel.Location = new System.Drawing.Point(156, 174);
            uploaderLabel.Name = "uploaderLabel";
            uploaderLabel.Size = new System.Drawing.Size(53, 13);
            uploaderLabel.TabIndex = 7;
            uploaderLabel.Text = "Uploader:";
            // 
            // scheduleTableTableAdapter1
            // 
            this.scheduleTableTableAdapter1.ClearBeforeFill = true;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonalInfoTableAdapter = null;
            this.tableAdapterManager.ScheduleTableTableAdapter = this.scheduleTableTableAdapter1;
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
            this.scheduleTableBindingNavigator.Size = new System.Drawing.Size(606, 25);
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
            this.scheduleCodeTextBox.Location = new System.Drawing.Point(245, 93);
            this.scheduleCodeTextBox.Name = "scheduleCodeTextBox";
            this.scheduleCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.scheduleCodeTextBox.TabIndex = 2;
            // 
            // validFromDateTimePicker
            // 
            this.validFromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduleTableBindingSource, "ValidFrom", true));
            this.validFromDateTimePicker.Location = new System.Drawing.Point(245, 119);
            this.validFromDateTimePicker.Name = "validFromDateTimePicker";
            this.validFromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.validFromDateTimePicker.TabIndex = 4;
            // 
            // validToDateTimePicker
            // 
            this.validToDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.scheduleTableBindingSource, "ValidTo", true));
            this.validToDateTimePicker.Location = new System.Drawing.Point(245, 145);
            this.validToDateTimePicker.Name = "validToDateTimePicker";
            this.validToDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.validToDateTimePicker.TabIndex = 6;
            // 
            // uploaderTextBox
            // 
            this.uploaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleTableBindingSource, "Uploader", true));
            this.uploaderTextBox.Location = new System.Drawing.Point(245, 171);
            this.uploaderTextBox.Name = "uploaderTextBox";
            this.uploaderTextBox.Size = new System.Drawing.Size(200, 20);
            this.uploaderTextBox.TabIndex = 8;
            // 
            // SaveSbtn
            // 
            this.SaveSbtn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.SaveSbtn.Location = new System.Drawing.Point(309, 251);
            this.SaveSbtn.Name = "SaveSbtn";
            this.SaveSbtn.Size = new System.Drawing.Size(50, 21);
            this.SaveSbtn.TabIndex = 9;
            this.SaveSbtn.Text = "Save";
            this.SaveSbtn.UseVisualStyleBackColor = true;
            this.SaveSbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChoseFile
            // 
            this.ChoseFile.AutoSize = true;
            this.ChoseFile.Location = new System.Drawing.Point(156, 213);
            this.ChoseFile.Name = "ChoseFile";
            this.ChoseFile.Size = new System.Drawing.Size(56, 13);
            this.ChoseFile.TabIndex = 10;
            this.ChoseFile.Text = "Chose file:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileUploader
            // 
            this.fileUploader.Location = new System.Drawing.Point(245, 213);
            this.fileUploader.Name = "fileUploader";
            this.fileUploader.Size = new System.Drawing.Size(56, 20);
            this.fileUploader.TabIndex = 11;
            this.fileUploader.Text = "upload";
            this.fileUploader.UseVisualStyleBackColor = true;
            this.fileUploader.Click += new System.EventHandler(this.fileUploader_Click);
            // 
            // ScheduleUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 342);
            this.Controls.Add(this.fileUploader);
            this.Controls.Add(this.ChoseFile);
            this.Controls.Add(this.SaveSbtn);
            this.Controls.Add(scheduleCodeLabel);
            this.Controls.Add(this.scheduleCodeTextBox);
            this.Controls.Add(validFromLabel);
            this.Controls.Add(this.validFromDateTimePicker);
            this.Controls.Add(validToLabel);
            this.Controls.Add(this.validToDateTimePicker);
            this.Controls.Add(uploaderLabel);
            this.Controls.Add(this.uploaderTextBox);
            this.Controls.Add(this.scheduleTableBindingNavigator);
            this.Name = "ScheduleUpload";
            this.Text = "ScheduleUpload";
            this.Load += new System.EventHandler(this.ScheduleUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.powiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleTableBindingNavigator)).EndInit();
            this.scheduleTableBindingNavigator.ResumeLayout(false);
            this.scheduleTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PowiDataSetTableAdapters.ScheduleTableTableAdapter scheduleTableTableAdapter1;
        private PowiDataSet powiDataSet;
        private System.Windows.Forms.BindingSource scheduleTableBindingSource;
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
        private System.Windows.Forms.Button SaveSbtn;
        private System.Windows.Forms.Label ChoseFile;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button fileUploader;
    }
}