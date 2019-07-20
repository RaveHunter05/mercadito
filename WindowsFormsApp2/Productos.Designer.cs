namespace WindowsFormsApp2
{
    partial class Productos
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
            this.empresaDataSet = new WindowsFormsApp2.EmpresaDataSet();
            this.tumadreenbikiniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tumadreenbikiniTableAdapter = new WindowsFormsApp2.EmpresaDataSetTableAdapters.tumadreenbikiniTableAdapter();
            this.tumadreenbikiniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new WindowsFormsApp2.EmpresaDataSetTableAdapters.loginTableAdapter();
            this.tugfaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tugfaTableAdapter = new WindowsFormsApp2.EmpresaDataSetTableAdapters.tugfaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechatAgregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.abarrotesSanRafaelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abarrotesSanRafaelDataSet = new WindowsFormsApp2.abarrotesSanRafaelDataSet();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaDataSet1 = new WindowsFormsApp2.EmpresaDataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productoTableAdapter = new WindowsFormsApp2.EmpresaDataSet1TableAdapters.productoTableAdapter();
            this.productoTableAdapter1 = new WindowsFormsApp2.abarrotesSanRafaelDataSetTableAdapters.ProductoTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumadreenbikiniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumadreenbikiniBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugfaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abarrotesSanRafaelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abarrotesSanRafaelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "EmpresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tumadreenbikiniBindingSource
            // 
            this.tumadreenbikiniBindingSource.DataMember = "tumadreenbikini";
            this.tumadreenbikiniBindingSource.DataSource = this.empresaDataSet;
            // 
            // tumadreenbikiniTableAdapter
            // 
            this.tumadreenbikiniTableAdapter.ClearBeforeFill = true;
            // 
            // tumadreenbikiniBindingSource1
            // 
            this.tumadreenbikiniBindingSource1.DataMember = "tumadreenbikini";
            this.tumadreenbikiniBindingSource1.DataSource = this.empresaDataSet;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.empresaDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tugfaBindingSource
            // 
            this.tugfaBindingSource.DataMember = "tugfa";
            this.tugfaBindingSource.DataSource = this.empresaDataSet;
            // 
            // tugfaTableAdapter
            // 
            this.tugfaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de productos";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Buscar";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 330);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.descripcionProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn,
            this.fechatAgregadoDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(678, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Width = 83;
            // 
            // descripcionProductoDataGridViewTextBoxColumn
            // 
            this.descripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "descripcionProducto";
            this.descripcionProductoDataGridViewTextBoxColumn.HeaderText = "descripcionProducto";
            this.descripcionProductoDataGridViewTextBoxColumn.Name = "descripcionProductoDataGridViewTextBoxColumn";
            this.descripcionProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionProductoDataGridViewTextBoxColumn.Width = 129;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProductoDataGridViewTextBoxColumn.Width = 110;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveedorDataGridViewTextBoxColumn.Width = 89;
            // 
            // fechatAgregadoDataGridViewTextBoxColumn
            // 
            this.fechatAgregadoDataGridViewTextBoxColumn.DataPropertyName = "fechatAgregado";
            this.fechatAgregadoDataGridViewTextBoxColumn.HeaderText = "fechatAgregado";
            this.fechatAgregadoDataGridViewTextBoxColumn.Name = "fechatAgregadoDataGridViewTextBoxColumn";
            this.fechatAgregadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechatAgregadoDataGridViewTextBoxColumn.Width = 108;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "fechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            this.fechaVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVencimientoDataGridViewTextBoxColumn.Width = 117;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.estatusDataGridViewTextBoxColumn.Width = 66;
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "existencia";
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            this.existenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.existenciaDataGridViewTextBoxColumn.Width = 79;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 61;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategoriaDataGridViewTextBoxColumn.Width = 85;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.abarrotesSanRafaelDataSetBindingSource;
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
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.empresaDataSet1BindingSource;
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApp2.Properties.Resources.icons8_compose_40;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(390, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 51);
            this.button2.TabIndex = 16;
            this.button2.Text = "Editar\r\nproducto";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApp2.Properties.Resources.icons8_subtract_16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(549, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 51);
            this.button3.TabIndex = 15;
            this.button3.Text = "Quitar\r\nproducto";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.icons8_detective_64;
            this.pictureBox2.Location = new System.Drawing.Point(164, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_plus_math_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(249, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar \r\nproducto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_box_64;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.icons8_synchronize_filled_50;
            this.pictureBox3.Location = new System.Drawing.Point(327, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumadreenbikiniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumadreenbikiniBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugfaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abarrotesSanRafaelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abarrotesSanRafaelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EmpresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource tumadreenbikiniBindingSource;
        private EmpresaDataSetTableAdapters.tumadreenbikiniTableAdapter tumadreenbikiniTableAdapter;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private EmpresaDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.BindingSource tumadreenbikiniBindingSource1;
        private System.Windows.Forms.BindingSource tugfaBindingSource;
        private EmpresaDataSetTableAdapters.tugfaTableAdapter tugfaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource empresaDataSet1BindingSource;
        private EmpresaDataSet1 empresaDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private EmpresaDataSet1TableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource abarrotesSanRafaelDataSetBindingSource;
        private abarrotesSanRafaelDataSet abarrotesSanRafaelDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private abarrotesSanRafaelDataSetTableAdapters.ProductoTableAdapter productoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechatAgregadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}