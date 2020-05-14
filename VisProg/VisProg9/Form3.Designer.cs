namespace VisProg9
{
    partial class Form3
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
            System.Windows.Forms.Label book_nameLabel;
            System.Windows.Forms.Label book_yearLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label aut_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.booksDataSet = new VisProg9.booksDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new VisProg9.booksDataSetTableAdapters.bookTableAdapter();
            this.tableAdapterManager = new VisProg9.booksDataSetTableAdapters.TableAdapterManager();
            this.bookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.book_nameTextBox = new System.Windows.Forms.TextBox();
            this.book_yearTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.aut_idTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            book_nameLabel = new System.Windows.Forms.Label();
            book_yearLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            aut_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).BeginInit();
            this.bookBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // book_nameLabel
            // 
            book_nameLabel.AutoSize = true;
            book_nameLabel.Location = new System.Drawing.Point(44, 136);
            book_nameLabel.Name = "book_nameLabel";
            book_nameLabel.Size = new System.Drawing.Size(82, 17);
            book_nameLabel.TabIndex = 3;
            book_nameLabel.Text = "book name:";
            // 
            // book_yearLabel
            // 
            book_yearLabel.AutoSize = true;
            book_yearLabel.Location = new System.Drawing.Point(51, 177);
            book_yearLabel.Name = "book_yearLabel";
            book_yearLabel.Size = new System.Drawing.Size(75, 17);
            book_yearLabel.TabIndex = 4;
            book_yearLabel.Text = "book year:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(77, 214);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(49, 17);
            genreLabel.TabIndex = 6;
            genreLabel.Text = "genre:";
            // 
            // aut_idLabel
            // 
            aut_idLabel.AutoSize = true;
            aut_idLabel.Location = new System.Drawing.Point(79, 102);
            aut_idLabel.Name = "aut_idLabel";
            aut_idLabel.Size = new System.Drawing.Size(47, 17);
            aut_idLabel.TabIndex = 8;
            aut_idLabel.Text = "aut id:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица Книги";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "booksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.booksDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.buyerTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = null;
            this.tableAdapterManager.purch_bookTableAdapter = null;
            this.tableAdapterManager.purchaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VisProg9.booksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookBindingNavigator
            // 
            this.bookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookBindingNavigator.BindingSource = this.bookBindingSource;
            this.bookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookBindingNavigatorSaveItem});
            this.bookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookBindingNavigator.Name = "bookBindingNavigator";
            this.bookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookBindingNavigator.Size = new System.Drawing.Size(356, 27);
            this.bookBindingNavigator.TabIndex = 3;
            this.bookBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bookBindingNavigatorSaveItem
            // 
            this.bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookBindingNavigatorSaveItem.Image")));
            this.bookBindingNavigatorSaveItem.Name = "bookBindingNavigatorSaveItem";
            this.bookBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bookBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.bookBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookBindingNavigatorSaveItem_Click);
            // 
            // book_nameTextBox
            // 
            this.book_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "book_name", true));
            this.book_nameTextBox.Location = new System.Drawing.Point(132, 136);
            this.book_nameTextBox.Name = "book_nameTextBox";
            this.book_nameTextBox.Size = new System.Drawing.Size(160, 22);
            this.book_nameTextBox.TabIndex = 4;
            // 
            // book_yearTextBox
            // 
            this.book_yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "book_year", true));
            this.book_yearTextBox.Location = new System.Drawing.Point(132, 174);
            this.book_yearTextBox.Name = "book_yearTextBox";
            this.book_yearTextBox.Size = new System.Drawing.Size(160, 22);
            this.book_yearTextBox.TabIndex = 5;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(132, 211);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(160, 22);
            this.genreTextBox.TabIndex = 7;
            // 
            // aut_idTextBox
            // 
            this.aut_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "aut_id", true));
            this.aut_idTextBox.Location = new System.Drawing.Point(132, 99);
            this.aut_idTextBox.Name = "aut_idTextBox";
            this.aut_idTextBox.Size = new System.Drawing.Size(160, 22);
            this.aut_idTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Таблица";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(aut_idLabel);
            this.Controls.Add(this.aut_idTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(book_yearLabel);
            this.Controls.Add(this.book_yearTextBox);
            this.Controls.Add(book_nameLabel);
            this.Controls.Add(this.book_nameTextBox);
            this.Controls.Add(this.bookBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).EndInit();
            this.bookBindingNavigator.ResumeLayout(false);
            this.bookBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private booksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private booksDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private booksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox book_nameTextBox;
        private System.Windows.Forms.TextBox book_yearTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox aut_idTextBox;
        private System.Windows.Forms.Button button1;
    }
}