namespace WindowsFormsApp2
{
    partial class Proveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAgregadoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.abarrotesSanRafaelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abarrotesSanRafaelDataSet = new WindowsFormsApp2.abarrotesSanRafaelDataSet();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet1 = new WindowsFormsApp2.EmpresaDataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorTableAdapter = new WindowsFormsApp2.EmpresaDataSet1TableAdapters.proveedorTableAdapter();
            this.proveedorTableAdapter1 = new WindowsFormsApp2.abarrotesSanRafaelDataSetTableAdapters.ProveedorTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abarrotesSanRafaelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abarrotesSanRafaelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 326);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedorDataGridViewTextBoxColumn,
            this.rucDataGridViewTextBoxColumn,
            this.nombreEmpresaDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.telefonoProveedorDataGridViewTextBoxColumn,
            this.correoProveedorDataGridViewTextBoxColumn,
            this.direccionProveedorDataGridViewTextBoxColumn,
            this.fechaAgregadoProveedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(662, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rucDataGridViewTextBoxColumn
            // 
            this.rucDataGridViewTextBoxColumn.DataPropertyName = "ruc";
            this.rucDataGridViewTextBoxColumn.HeaderText = "ruc";
            this.rucDataGridViewTextBoxColumn.Name = "rucDataGridViewTextBoxColumn";
            this.rucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEmpresaDataGridViewTextBoxColumn
            // 
            this.nombreEmpresaDataGridViewTextBoxColumn.DataPropertyName = "nombreEmpresa";
            this.nombreEmpresaDataGridViewTextBoxColumn.HeaderText = "nombreEmpresa";
            this.nombreEmpresaDataGridViewTextBoxColumn.Name = "nombreEmpresaDataGridViewTextBoxColumn";
            this.nombreEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "nombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "nombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoProveedorDataGridViewTextBoxColumn
            // 
            this.telefonoProveedorDataGridViewTextBoxColumn.DataPropertyName = "telefonoProveedor";
            this.telefonoProveedorDataGridViewTextBoxColumn.HeaderText = "telefonoProveedor";
            this.telefonoProveedorDataGridViewTextBoxColumn.Name = "telefonoProveedorDataGridViewTextBoxColumn";
            this.telefonoProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoProveedorDataGridViewTextBoxColumn
            // 
            this.correoProveedorDataGridViewTextBoxColumn.DataPropertyName = "correoProveedor";
            this.correoProveedorDataGridViewTextBoxColumn.HeaderText = "correoProveedor";
            this.correoProveedorDataGridViewTextBoxColumn.Name = "correoProveedorDataGridViewTextBoxColumn";
            this.correoProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionProveedorDataGridViewTextBoxColumn
            // 
            this.direccionProveedorDataGridViewTextBoxColumn.DataPropertyName = "direccionProveedor";
            this.direccionProveedorDataGridViewTextBoxColumn.HeaderText = "direccionProveedor";
            this.direccionProveedorDataGridViewTextBoxColumn.Name = "direccionProveedorDataGridViewTextBoxColumn";
            this.direccionProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAgregadoProveedorDataGridViewTextBoxColumn
            // 
            this.fechaAgregadoProveedorDataGridViewTextBoxColumn.DataPropertyName = "fechaAgregadoProveedor";
            this.fechaAgregadoProveedorDataGridViewTextBoxColumn.HeaderText = "fechaAgregadoProveedor";
            this.fechaAgregadoProveedorDataGridViewTextBoxColumn.Name = "fechaAgregadoProveedorDataGridViewTextBoxColumn";
            this.fechaAgregadoProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource2
            // 
            this.proveedorBindingSource2.DataMember = "Proveedor";
            this.proveedorBindingSource2.DataSource = this.abarrotesSanRafaelDataSetBindingSource;
            // 
            // abarrotesSanRafaelDataSetBindingSource
            // 
            this.abarrotesSanRafaelDataSetBindingSource.DataSource = this.abarrotesSanRafaelDataSet;
            this.abarrotesSanRafaelDataSetBindingSource.Position = 0;
            // 
            // abarrotesSanRafaelDataSet
            // 
            this.abarrotesSanRafaelDataSet.DataSetName = "abarrotesSanRafaelDataSet";
            this.abarrotesSanRafaelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.abarrotesSanRafaelDataSetBindingSource;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.empresaDataSet1BindingSource;
            // 
            // empresaDataSet1BindingSource
            // 
            this.empresaDataSet1BindingSource.DataSource = this.empresaDataSet1;
            this.empresaDataSet1BindingSource.Position = 0;
            // 
            // empresaDataSet1
            // 
            this.empresaDataSet1.DataSetName = "EmpresaDataSet1";
            this.empresaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(19, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 10;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Buscar";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de proveedores";
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter1
            // 
            this.proveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.icons8_synchronize_filled_50;
            this.pictureBox3.Location = new System.Drawing.Point(330, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApp2.Properties.Resources.icons8_subtract_16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(520, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 51);
            this.button3.TabIndex = 14;
            this.button3.Text = "Quitar\r\nproveedor\r\n";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApp2.Properties.Resources.icons8_compose_40;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(381, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 51);
            this.button2.TabIndex = 13;
            this.button2.Text = "Editar\r\nproveedor\r\n";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_plus_math_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(249, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nuevo\r\nproveedor\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_supplier_64;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.Image = global::WindowsFormsApp2.Properties.Resources.icons8_detective_64;
            this.button4.Location = new System.Drawing.Point(165, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 53);
            this.button4.TabIndex = 16;
            this.button4.Text = "Buscar por \r\nid";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abarrotesSanRafaelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abarrotesSanRafaelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource empresaDataSet1BindingSource;
        private EmpresaDataSet1 empresaDataSet1;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private EmpresaDataSet1TableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource abarrotesSanRafaelDataSetBindingSource;
        private abarrotesSanRafaelDataSet abarrotesSanRafaelDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private abarrotesSanRafaelDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAgregadoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proveedorBindingSource2;
    }
}