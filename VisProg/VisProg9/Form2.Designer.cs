namespace VisProg9
{
    partial class Form2
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
            System.Windows.Forms.Label aut_surnameLabel;
            System.Windows.Forms.Label aut_nameLabel;
            System.Windows.Forms.Label aut_lastnameLabel;
            System.Windows.Forms.Label aut_bdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.booksDataSet = new VisProg9.booksDataSet();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new VisProg9.booksDataSetTableAdapters.authorTableAdapter();
            this.tableAdapterManager = new VisProg9.booksDataSetTableAdapters.TableAdapterManager();
            this.authorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.authorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aut_surnameTextBox = new System.Windows.Forms.TextBox();
            this.aut_nameTextBox = new System.Windows.Forms.TextBox();
            this.aut_lastnameTextBox = new System.Windows.Forms.TextBox();
            this.aut_bdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            aut_surnameLabel = new System.Windows.Forms.Label();
            aut_nameLabel = new System.Windows.Forms.Label();
            aut_lastnameLabel = new System.Windows.Forms.Label();
            aut_bdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).BeginInit();
            this.authorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // aut_surnameLabel
            // 
            aut_surnameLabel.AutoSize = true;
            aut_surnameLabel.Location = new System.Drawing.Point(47, 90);
            aut_surnameLabel.Name = "aut_surnameLabel";
            aut_surnameLabel.Size = new System.Drawing.Size(91, 17);
            aut_surnameLabel.TabIndex = 2;
            aut_surnameLabel.Text = "aut surname:";
            // 
            // aut_nameLabel
            // 
            aut_nameLabel.AutoSize = true;
            aut_nameLabel.Location = new System.Drawing.Point(67, 124);
            aut_nameLabel.Name = "aut_nameLabel";
            aut_nameLabel.Size = new System.Drawing.Size(71, 17);
            aut_nameLabel.TabIndex = 4;
            aut_nameLabel.Text = "aut name:";
            // 
            // aut_lastnameLabel
            // 
            aut_lastnameLabel.AutoSize = true;
            aut_lastnameLabel.Location = new System.Drawing.Point(45, 161);
            aut_lastnameLabel.Name = "aut_lastnameLabel";
            aut_lastnameLabel.Size = new System.Drawing.Size(93, 17);
            aut_lastnameLabel.TabIndex = 6;
            aut_lastnameLabel.Text = "aut lastname:";
            // 
            // aut_bdLabel
            // 
            aut_bdLabel.AutoSize = true;
            aut_bdLabel.Location = new System.Drawing.Point(86, 201);
            aut_bdLabel.Name = "aut_bdLabel";
            aut_bdLabel.Size = new System.Drawing.Size(52, 17);
            aut_bdLabel.TabIndex = 8;
            aut_bdLabel.Text = "aut bd:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица Авторы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "booksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "author";
            this.authorBindingSource.DataSource = this.booksDataSet;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorTableAdapter = this.authorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookTableAdapter = null;
            this.tableAdapterManager.buyerTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = null;
            this.tableAdapterManager.purch_bookTableAdapter = null;
            this.tableAdapterManager.purchaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VisProg9.booksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authorBindingNavigator
            // 
            this.authorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.authorBindingNavigator.BindingSource = this.authorBindingSource;
            this.authorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.authorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.authorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.authorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.authorBindingNavigatorSaveItem});
            this.authorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.authorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.authorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.authorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.authorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.authorBindingNavigator.Name = "authorBindingNavigator";
            this.authorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.authorBindingNavigator.Size = new System.Drawing.Size(413, 31);
            this.authorBindingNavigator.TabIndex = 2;
            this.authorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // authorBindingNavigatorSaveItem
            // 
            this.authorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.authorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("authorBindingNavigatorSaveItem.Image")));
            this.authorBindingNavigatorSaveItem.Name = "authorBindingNavigatorSaveItem";
            this.authorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.authorBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.authorBindingNavigatorSaveItem.Click += new System.EventHandler(this.authorBindingNavigatorSaveItem_Click);
            // 
            // aut_surnameTextBox
            // 
            this.aut_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "aut_surname", true));
            this.aut_surnameTextBox.Location = new System.Drawing.Point(144, 87);
            this.aut_surnameTextBox.Name = "aut_surnameTextBox";
            this.aut_surnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.aut_surnameTextBox.TabIndex = 3;
            // 
            // aut_nameTextBox
            // 
            this.aut_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "aut_name", true));
            this.aut_nameTextBox.Location = new System.Drawing.Point(144, 121);
            this.aut_nameTextBox.Name = "aut_nameTextBox";
            this.aut_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.aut_nameTextBox.TabIndex = 5;
            // 
            // aut_lastnameTextBox
            // 
            this.aut_lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "aut_lastname", true));
            this.aut_lastnameTextBox.Location = new System.Drawing.Point(144, 158);
            this.aut_lastnameTextBox.Name = "aut_lastnameTextBox";
            this.aut_lastnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.aut_lastnameTextBox.TabIndex = 7;
            // 
            // aut_bdDateTimePicker
            // 
            this.aut_bdDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.authorBindingSource, "aut_bd", true));
            this.aut_bdDateTimePicker.Location = new System.Drawing.Point(144, 197);
            this.aut_bdDateTimePicker.Name = "aut_bdDateTimePicker";
            this.aut_bdDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.aut_bdDateTimePicker.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(aut_bdLabel);
            this.Controls.Add(this.aut_bdDateTimePicker);
            this.Controls.Add(aut_lastnameLabel);
            this.Controls.Add(this.aut_lastnameTextBox);
            this.Controls.Add(aut_nameLabel);
            this.Controls.Add(this.aut_nameTextBox);
            this.Controls.Add(aut_surnameLabel);
            this.Controls.Add(this.aut_surnameTextBox);
            this.Controls.Add(this.authorBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Авторы";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).EndInit();
            this.authorBindingNavigator.ResumeLayout(false);
            this.authorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private booksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private booksDataSetTableAdapters.authorTableAdapter authorTableAdapter;
        private booksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator authorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton authorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox aut_surnameTextBox;
        private System.Windows.Forms.TextBox aut_nameTextBox;
        private System.Windows.Forms.TextBox aut_lastnameTextBox;
        private System.Windows.Forms.DateTimePicker aut_bdDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}