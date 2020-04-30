namespace VisProg9
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label publ_nameLabel;
            System.Windows.Forms.Label publ_cityLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.booksDataSet = new VisProg9.booksDataSet();
            this.publishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishTableAdapter = new VisProg9.booksDataSetTableAdapters.publishTableAdapter();
            this.tableAdapterManager = new VisProg9.booksDataSetTableAdapters.TableAdapterManager();
            this.publishBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.publishBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.publ_nameTextBox = new System.Windows.Forms.TextBox();
            this.publ_cityTextBox = new System.Windows.Forms.TextBox();
            publ_nameLabel = new System.Windows.Forms.Label();
            publ_cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishBindingNavigator)).BeginInit();
            this.publishBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица Издательства";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "booksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishBindingSource
            // 
            this.publishBindingSource.DataMember = "publish";
            this.publishBindingSource.DataSource = this.booksDataSet;
            // 
            // publishTableAdapter
            // 
            this.publishTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookTableAdapter = null;
            this.tableAdapterManager.buyerTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = this.publishTableAdapter;
            this.tableAdapterManager.purch_bookTableAdapter = null;
            this.tableAdapterManager.purchaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VisProg9.booksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publishBindingNavigator
            // 
            this.publishBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publishBindingNavigator.BindingSource = this.publishBindingSource;
            this.publishBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publishBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.publishBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.publishBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.publishBindingNavigatorSaveItem});
            this.publishBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publishBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publishBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publishBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publishBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publishBindingNavigator.Name = "publishBindingNavigator";
            this.publishBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publishBindingNavigator.Size = new System.Drawing.Size(372, 27);
            this.publishBindingNavigator.TabIndex = 4;
            this.publishBindingNavigator.Text = "bindingNavigator1";
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
            // publishBindingNavigatorSaveItem
            // 
            this.publishBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publishBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publishBindingNavigatorSaveItem.Image")));
            this.publishBindingNavigatorSaveItem.Name = "publishBindingNavigatorSaveItem";
            this.publishBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.publishBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.publishBindingNavigatorSaveItem.Click += new System.EventHandler(this.publishBindingNavigatorSaveItem_Click);
            // 
            // publ_nameLabel
            // 
            publ_nameLabel.AutoSize = true;
            publ_nameLabel.Location = new System.Drawing.Point(43, 166);
            publ_nameLabel.Name = "publ_nameLabel";
            publ_nameLabel.Size = new System.Drawing.Size(78, 17);
            publ_nameLabel.TabIndex = 4;
            publ_nameLabel.Text = "publ name:";
            // 
            // publ_nameTextBox
            // 
            this.publ_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishBindingSource, "publ_name", true));
            this.publ_nameTextBox.Location = new System.Drawing.Point(127, 163);
            this.publ_nameTextBox.Name = "publ_nameTextBox";
            this.publ_nameTextBox.Size = new System.Drawing.Size(160, 22);
            this.publ_nameTextBox.TabIndex = 5;
            // 
            // publ_cityLabel
            // 
            publ_cityLabel.AutoSize = true;
            publ_cityLabel.Location = new System.Drawing.Point(57, 204);
            publ_cityLabel.Name = "publ_cityLabel";
            publ_cityLabel.Size = new System.Drawing.Size(64, 17);
            publ_cityLabel.TabIndex = 5;
            publ_cityLabel.Text = "publ city:";
            // 
            // publ_cityTextBox
            // 
            this.publ_cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishBindingSource, "publ_city", true));
            this.publ_cityTextBox.Location = new System.Drawing.Point(127, 201);
            this.publ_cityTextBox.Name = "publ_cityTextBox";
            this.publ_cityTextBox.Size = new System.Drawing.Size(160, 22);
            this.publ_cityTextBox.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 274);
            this.Controls.Add(publ_cityLabel);
            this.Controls.Add(this.publ_cityTextBox);
            this.Controls.Add(publ_nameLabel);
            this.Controls.Add(this.publ_nameTextBox);
            this.Controls.Add(this.publishBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Издательства";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishBindingNavigator)).EndInit();
            this.publishBindingNavigator.ResumeLayout(false);
            this.publishBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private booksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource publishBindingSource;
        private booksDataSetTableAdapters.publishTableAdapter publishTableAdapter;
        private booksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publishBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton publishBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox publ_nameTextBox;
        private System.Windows.Forms.TextBox publ_cityTextBox;
    }
}