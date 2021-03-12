namespace AzureVirtualDesktop
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
            XPTable.Models.DataSourceColumnBinder dataSourceColumnBinder2 = new XPTable.Models.DataSourceColumnBinder();
            XPTable.Renderers.DragDropRenderer dragDropRenderer2 = new XPTable.Renderers.DragDropRenderer();
            this.table1 = new XPTable.Models.Table();
            this.columnModel1 = new XPTable.Models.ColumnModel();
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.input_subscriptionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_resourceGroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_applicationGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            this.SuspendLayout();
            // 
            // table1
            // 
            this.table1.BorderColor = System.Drawing.Color.Black;
            this.table1.ColumnModel = this.columnModel1;
            this.table1.DataMember = null;
            this.table1.DataSourceColumnBinder = dataSourceColumnBinder2;
            dragDropRenderer2.ForeColor = System.Drawing.Color.Red;
            this.table1.DragDropRenderer = dragDropRenderer2;
            this.table1.GridLinesContrainedToData = false;
            this.table1.HeaderAlignWithColumn = true;
            this.table1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.table1.Location = new System.Drawing.Point(35, 38);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(133, 301);
            this.table1.TabIndex = 0;
            this.table1.TableModel = this.tableModel1;
            this.table1.Text = "table1";
            this.table1.UnfocusedBorderColor = System.Drawing.Color.Black;
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Create.Location = new System.Drawing.Point(228, 249);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(99, 46);
            this.btn_Create.TabIndex = 1;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // btn_Read
            // 
            this.btn_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Read.Location = new System.Drawing.Point(447, 249);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(99, 46);
            this.btn_Read.TabIndex = 2;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // input_subscriptionId
            // 
            this.input_subscriptionId.Location = new System.Drawing.Point(340, 67);
            this.input_subscriptionId.Name = "input_subscriptionId";
            this.input_subscriptionId.Size = new System.Drawing.Size(274, 20);
            this.input_subscriptionId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(235, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "subscriptionId:";
            // 
            // input_resourceGroupName
            // 
            this.input_resourceGroupName.Location = new System.Drawing.Point(340, 110);
            this.input_resourceGroupName.Name = "input_resourceGroupName";
            this.input_resourceGroupName.Size = new System.Drawing.Size(274, 20);
            this.input_resourceGroupName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(189, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "resourceGroupName:";
            // 
            // input_applicationGroupName
            // 
            this.input_applicationGroupName.Location = new System.Drawing.Point(340, 153);
            this.input_applicationGroupName.Name = "input_applicationGroupName";
            this.input_applicationGroupName.Size = new System.Drawing.Size(274, 20);
            this.input_applicationGroupName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(177, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "applicationGroupName:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_applicationGroupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_resourceGroupName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_subscriptionId);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.table1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XPTable.Models.Table table1;
        private XPTable.Models.ColumnModel columnModel1;
        private XPTable.Models.TableModel tableModel1;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.TextBox input_subscriptionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_resourceGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_applicationGroupName;
        private System.Windows.Forms.Label label3;
    }
}

