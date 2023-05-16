namespace Combining_Application_Relational_SQLDB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvDB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtExit = new System.Windows.Forms.Button();
            this.BtChangeBColor = new System.Windows.Forms.Button();
            this.BtStaffs = new System.Windows.Forms.Button();
            this.BtProducts = new System.Windows.Forms.Button();
            this.BtCustomers = new System.Windows.Forms.Button();
            this.BtActions = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DgvDB);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DgvDB
            // 
            this.DgvDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDB.Location = new System.Drawing.Point(7, 75);
            this.DgvDB.Name = "DgvDB";
            this.DgvDB.ReadOnly = true;
            this.DgvDB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvDB.Size = new System.Drawing.Size(777, 344);
            this.DgvDB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtExit);
            this.groupBox1.Controls.Add(this.BtChangeBColor);
            this.groupBox1.Controls.Add(this.BtStaffs);
            this.groupBox1.Controls.Add(this.BtProducts);
            this.groupBox1.Controls.Add(this.BtCustomers);
            this.groupBox1.Controls.Add(this.BtActions);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtExit
            // 
            this.BtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtExit.Location = new System.Drawing.Point(698, 9);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(80, 56);
            this.BtExit.TabIndex = 5;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = true;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // BtChangeBColor
            // 
            this.BtChangeBColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtChangeBColor.Location = new System.Drawing.Point(560, 9);
            this.BtChangeBColor.Name = "BtChangeBColor";
            this.BtChangeBColor.Size = new System.Drawing.Size(80, 56);
            this.BtChangeBColor.TabIndex = 0;
            this.BtChangeBColor.Text = "Change Back Color";
            this.BtChangeBColor.UseVisualStyleBackColor = true;
            this.BtChangeBColor.Click += new System.EventHandler(this.BtChangeBColor_Click);
            // 
            // BtStaffs
            // 
            this.BtStaffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtStaffs.Location = new System.Drawing.Point(422, 9);
            this.BtStaffs.Name = "BtStaffs";
            this.BtStaffs.Size = new System.Drawing.Size(80, 56);
            this.BtStaffs.TabIndex = 4;
            this.BtStaffs.Text = "Staffs";
            this.BtStaffs.UseVisualStyleBackColor = true;
            this.BtStaffs.Click += new System.EventHandler(this.BtStaffs_Click);
            // 
            // BtProducts
            // 
            this.BtProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtProducts.Location = new System.Drawing.Point(284, 9);
            this.BtProducts.Name = "BtProducts";
            this.BtProducts.Size = new System.Drawing.Size(80, 56);
            this.BtProducts.TabIndex = 3;
            this.BtProducts.Text = "Products";
            this.BtProducts.UseVisualStyleBackColor = true;
            this.BtProducts.Click += new System.EventHandler(this.BtProducts_Click);
            // 
            // BtCustomers
            // 
            this.BtCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtCustomers.Location = new System.Drawing.Point(146, 9);
            this.BtCustomers.Name = "BtCustomers";
            this.BtCustomers.Size = new System.Drawing.Size(80, 56);
            this.BtCustomers.TabIndex = 2;
            this.BtCustomers.Text = "Customers";
            this.BtCustomers.UseVisualStyleBackColor = true;
            this.BtCustomers.Click += new System.EventHandler(this.BtCustomers_Click);
            // 
            // BtActions
            // 
            this.BtActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtActions.Location = new System.Drawing.Point(8, 9);
            this.BtActions.Name = "BtActions";
            this.BtActions.Size = new System.Drawing.Size(80, 56);
            this.BtActions.TabIndex = 1;
            this.BtActions.Text = "Actions";
            this.BtActions.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.Button BtStaffs;
        private System.Windows.Forms.Button BtProducts;
        private System.Windows.Forms.Button BtCustomers;
        private System.Windows.Forms.Button BtActions;
        private System.Windows.Forms.Button BtChangeBColor;
        private System.Windows.Forms.DataGridView DgvDB;
    }
}

