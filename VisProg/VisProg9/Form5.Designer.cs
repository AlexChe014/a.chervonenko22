namespace VisProg9
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label buyer_idLabel;
            System.Windows.Forms.Label purch_dateLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.booksDataSet = new VisProg9.booksDataSet();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTableAdapter = new VisProg9.booksDataSetTableAdapters.purchaseTableAdapter();
            this.tableAdapterManager = new VisProg9.booksDataSetTableAdapters.TableAdapterManager();
            this.purchaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purchaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buyer_idTextBox = new System.Windows.Forms.TextBox();
            this.purch_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            buyer_idLabel = new System.Windows.Forms.Label();
            purch_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingNavigator)).BeginInit();
            this.purchaseBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(78, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица Заказы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "booksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "purchase";
            this.purchaseBindingSource.DataSource = this.booksDataSet;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookTableAdapter = null;
            this.tableAdapterManager.buyerTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = null;
            this.tableAdapterManager.purch_bookTableAdapter = null;
            this.tableAdapterManager.purchaseTableAdapter = this.purchaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = VisProg9.booksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchaseBindingNavigator
            // 
            this.purchaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseBindingNavigator.BindingSource = this.purchaseBindingSource;
            this.purchaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.purchaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchaseBindingNavigatorSaveItem});
            this.purchaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseBindingNavigator.Name = "purchaseBindingNavigator";
            this.purchaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseBindingNavigator.Size = new System.Drawing.Size(381, 27);
            this.purchaseBindingNavigator.TabIndex = 4;
            this.purchaseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // purchaseBindingNavigatorSaveItem
            // 
            this.purchaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseBindingNavigatorSaveItem.Image")));
            this.purchaseBindingNavigatorSaveItem.Name = "purchaseBindingNavigatorSaveItem";
            this.purchaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.purchaseBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.purchaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseBindingNavigatorSaveItem_Click);
            // 
            // buyer_idLabel
            // 
            buyer_idLabel.AutoSize = true;
            buyer_idLabel.Location = new System.Drawing.Point(69, 114);
            buyer_idLabel.Name = "buyer_idLabel";
            buyer_idLabel.Size = new System.Drawing.Size(63, 17);
            buyer_idLabel.TabIndex = 4;
            buyer_idLabel.Text = "buyer id:";
            // 
            // buyer_idTextBox
            // 
            this.buyer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseBindingSource, "buyer_id", true));
            this.buyer_idTextBox.Location = new System.Drawing.Point(138, 111);
            this.buyer_idTextBox.Name = "buyer_idTextBox";
            this.buyer_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.buyer_idTextBox.TabIndex = 5;
            // 
            // purch_dateLabel
            // 
            purch_dateLabel.AutoSize = true;
            purch_dateLabel.Location = new System.Drawing.Point(52, 153);
            purch_dateLabel.Name = "purch_dateLabel";
            purch_dateLabel.Size = new System.Drawing.Size(80, 17);
            purch_dateLabel.TabIndex = 5;
            purch_dateLabel.Text = "purch date:";
            // 
            // purch_dateDateTimePicker
            // 
            this.purch_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseBindingSource, "purch_date", true));
            this.purch_dateDateTimePicker.Location = new System.Drawing.Point(138, 149);
            this.purch_dateDateTimePicker.Name = "purch_dateDateTimePicker";
            this.purch_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.purch_dateDateTimePicker.TabIndex = 6;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 221);
            this.Controls.Add(purch_dateLabel);
            this.Controls.Add(this.purch_dateDateTimePicker);
            this.Controls.Add(buyer_idLabel);
            this.Controls.Add(this.buyer_idTextBox);
            this.Controls.Add(this.purchaseBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingNavigator)).EndInit();
            this.purchaseBindingNavigator.ResumeLayout(false);
            this.purchaseBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private booksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private booksDataSetTableAdapters.purchaseTableAdapter purchaseTableAdapter;
        private booksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchaseBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox buyer_idTextBox;
        private System.Windows.Forms.DateTimePicker purch_dateDateTimePicker;
    }
}