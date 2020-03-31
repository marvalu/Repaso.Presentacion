namespace Presentacion
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.ApellidoText = new System.Windows.Forms.TextBox();
            this.CedText = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.ced = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BorrarInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repasoDataSet = new Presentacion.repasoDataSet();
            this.personaTableAdapter = new Presentacion.repasoDataSetTableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repasoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(636, 47);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(736, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(613, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "ActualizarBD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(613, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(165, 30);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(100, 22);
            this.NombreText.TabIndex = 5;
            // 
            // ApellidoText
            // 
            this.ApellidoText.Location = new System.Drawing.Point(165, 82);
            this.ApellidoText.Name = "ApellidoText";
            this.ApellidoText.Size = new System.Drawing.Size(100, 22);
            this.ApellidoText.TabIndex = 6;
            // 
            // CedText
            // 
            this.CedText.Location = new System.Drawing.Point(165, 138);
            this.CedText.Name = "CedText";
            this.CedText.Size = new System.Drawing.Size(100, 22);
            this.CedText.TabIndex = 7;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(165, 189);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 22);
            this.IDText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(39, 82);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(58, 17);
            this.Apellido.TabIndex = 10;
            this.Apellido.Text = "Apellido";
            // 
            // ced
            // 
            this.ced.AutoSize = true;
            this.ced.Location = new System.Drawing.Point(39, 144);
            this.ced.Name = "ced";
            this.ced.Size = new System.Drawing.Size(33, 17);
            this.ced.TabIndex = 11;
            this.ced.Text = "Ced";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // BorrarInfo
            // 
            this.BorrarInfo.Location = new System.Drawing.Point(418, 47);
            this.BorrarInfo.Name = "BorrarInfo";
            this.BorrarInfo.Size = new System.Drawing.Size(75, 23);
            this.BorrarInfo.TabIndex = 13;
            this.BorrarInfo.Text = "Borrar";
            this.BorrarInfo.UseVisualStyleBackColor = true;
            this.BorrarInfo.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "cedula";
            this.cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.repasoDataSet;
            // 
            // repasoDataSet
            // 
            this.repasoDataSet.DataSetName = "repasoDataSet";
            this.repasoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BorrarInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ced);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.CedText);
            this.Controls.Add(this.ApellidoText);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repasoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.TextBox ApellidoText;
        private System.Windows.Forms.TextBox CedText;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label ced;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BorrarInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private repasoDataSet repasoDataSet;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private repasoDataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
    }
}

