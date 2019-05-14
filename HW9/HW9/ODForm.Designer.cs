namespace HW9
{
    partial class ODForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gIdTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oIdLabel = new System.Windows.Forms.Label();
            this.oIdTextBox = new System.Windows.Forms.TextBox();
            this.cLabel = new System.Windows.Forms.Label();
            this.cIdTextBox = new System.Windows.Forms.TextBox();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.addODBtn = new System.Windows.Forms.Button();
            this.gNameTextBox = new System.Windows.Forms.TextBox();
            this.gPriceTextBox = new System.Windows.Forms.TextBox();
            this.addOBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.orderDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(418, 271);
            this.dataGridView1.TabIndex = 2;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Details";
            this.orderBindingSource.DataSource = typeof(void);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Goods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // gIdTextBox
            // 
            this.gIdTextBox.Location = new System.Drawing.Point(186, 338);
            this.gIdTextBox.Name = "gIdTextBox";
            this.gIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.gIdTextBox.TabIndex = 5;
            this.gIdTextBox.Enter += new System.EventHandler(this.gIdTextBox_Enter);
            this.gIdTextBox.Leave += new System.EventHandler(this.gIdTextBox_Leave);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(186, 370);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 6;
            this.quantityTextBox.Enter += new System.EventHandler(this.quantityTextBox_Enter);
            this.quantityTextBox.Leave += new System.EventHandler(this.quantityTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // oIdLabel
            // 
            this.oIdLabel.AutoSize = true;
            this.oIdLabel.Location = new System.Drawing.Point(57, 19);
            this.oIdLabel.Name = "oIdLabel";
            this.oIdLabel.Size = new System.Drawing.Size(45, 13);
            this.oIdLabel.TabIndex = 9;
            this.oIdLabel.Text = "Order Id";
            // 
            // oIdTextBox
            // 
            this.oIdTextBox.Location = new System.Drawing.Point(133, 16);
            this.oIdTextBox.Name = "oIdTextBox";
            this.oIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.oIdTextBox.TabIndex = 10;
            this.oIdTextBox.Enter += new System.EventHandler(this.oIdTextBox_Enter);
            this.oIdTextBox.Leave += new System.EventHandler(this.oIdTextBox_Leave);
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(251, 19);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(51, 13);
            this.cLabel.TabIndex = 11;
            this.cLabel.Text = "Customer";
            // 
            // cIdTextBox
            // 
            this.cIdTextBox.Location = new System.Drawing.Point(308, 16);
            this.cIdTextBox.Name = "cIdTextBox";
            this.cIdTextBox.Size = new System.Drawing.Size(31, 20);
            this.cIdTextBox.TabIndex = 12;
            this.cIdTextBox.Enter += new System.EventHandler(this.cIdTextBox_Enter);
            this.cIdTextBox.Leave += new System.EventHandler(this.cIdTextBox_Leave);
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.Location = new System.Drawing.Point(345, 16);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(88, 20);
            this.cNameTextBox.TabIndex = 13;
            this.cNameTextBox.Enter += new System.EventHandler(this.cNameTextBox_Enter);
            this.cNameTextBox.Leave += new System.EventHandler(this.cNameTextBox_Leave);
            // 
            // addODBtn
            // 
            this.addODBtn.Location = new System.Drawing.Point(388, 368);
            this.addODBtn.Name = "addODBtn";
            this.addODBtn.Size = new System.Drawing.Size(123, 23);
            this.addODBtn.TabIndex = 14;
            this.addODBtn.Text = "addOrderDetail";
            this.addODBtn.UseVisualStyleBackColor = true;
            this.addODBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gNameTextBox
            // 
            this.gNameTextBox.Location = new System.Drawing.Point(292, 338);
            this.gNameTextBox.Name = "gNameTextBox";
            this.gNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.gNameTextBox.TabIndex = 15;
            this.gNameTextBox.Enter += new System.EventHandler(this.gNameTextBox_Enter);
            this.gNameTextBox.Leave += new System.EventHandler(this.gNameTextBox_Leave);
            // 
            // gPriceTextBox
            // 
            this.gPriceTextBox.Location = new System.Drawing.Point(398, 338);
            this.gPriceTextBox.Name = "gPriceTextBox";
            this.gPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.gPriceTextBox.TabIndex = 16;
            this.gPriceTextBox.Enter += new System.EventHandler(this.gPriceTextBox_Enter);
            this.gPriceTextBox.Leave += new System.EventHandler(this.gPriceTextBox_Leave);
            // 
            // addOBtn
            // 
            this.addOBtn.Location = new System.Drawing.Point(467, 16);
            this.addOBtn.Name = "addOBtn";
            this.addOBtn.Size = new System.Drawing.Size(75, 23);
            this.addOBtn.TabIndex = 17;
            this.addOBtn.Text = "addOrder";
            this.addOBtn.UseVisualStyleBackColor = true;
            this.addOBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ODForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 445);
            this.Controls.Add(this.addOBtn);
            this.Controls.Add(this.gPriceTextBox);
            this.Controls.Add(this.gNameTextBox);
            this.Controls.Add(this.addODBtn);
            this.Controls.Add(this.cNameTextBox);
            this.Controls.Add(this.cIdTextBox);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.oIdTextBox);
            this.Controls.Add(this.oIdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.gIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ODForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gIdTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label oIdLabel;
        private System.Windows.Forms.TextBox oIdTextBox;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox cIdTextBox;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.Button addODBtn;
        private System.Windows.Forms.TextBox gNameTextBox;
        private System.Windows.Forms.TextBox gPriceTextBox;
        private System.Windows.Forms.Button addOBtn;
    }
}

