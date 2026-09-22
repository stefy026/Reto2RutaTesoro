namespace Reto2RutaTesoro
{
    partial class FrmRutaTesoro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblId = new Label();
            numId = new NumericUpDown();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPista = new Label();
            txtPista = new TextBox();
            lblPeligro = new Label();
            numPeligro = new NumericUpDown();
            btnInsertar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            dgvRuta = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPista = new DataGridViewTextBoxColumn();
            colPeligro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeligro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(81, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(222, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "La Ruta del Tesoro Perdido";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 76);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // numId
            // 
            numId.Location = new Point(89, 76);
            numId.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(180, 31);
            numId.TabIndex = 2;
            numId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 4;
            // 
            // lblPista
            // 
            lblPista.AutoSize = true;
            lblPista.Location = new Point(12, 172);
            lblPista.Name = "lblPista";
            lblPista.Size = new Size(53, 25);
            lblPista.TabIndex = 5;
            lblPista.Text = "Pista:";
            // 
            // txtPista
            // 
            txtPista.Location = new Point(136, 166);
            txtPista.Name = "txtPista";
            txtPista.Size = new Size(150, 31);
            txtPista.TabIndex = 6;
            // 
            // lblPeligro
            // 
            lblPeligro.AutoSize = true;
            lblPeligro.Location = new Point(12, 259);
            lblPeligro.Name = "lblPeligro";
            lblPeligro.Size = new Size(114, 25);
            lblPeligro.TabIndex = 7;
            lblPeligro.Text = "Nivel Peligro:";
            // 
            // numPeligro
            // 
            numPeligro.Location = new Point(152, 253);
            numPeligro.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numPeligro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPeligro.Name = "numPeligro";
            numPeligro.Size = new Size(180, 31);
            numPeligro.TabIndex = 8;
            numPeligro.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(14, 352);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 34);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(191, 352);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(402, 352);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(587, 352);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(779, 352);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(246, 576);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(268, 25);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Total de ubicaciones en la ruta: 0";
            // 
            // dgvRuta
            // 
            dgvRuta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRuta.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPista, colPeligro });
            dgvRuta.Location = new Point(89, 444);
            dgvRuta.Name = "dgvRuta";
            dgvRuta.ReadOnly = true;
            dgvRuta.RowHeadersWidth = 62;
            dgvRuta.Size = new Size(633, 129);
            dgvRuta.TabIndex = 14;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 150;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Ubicacion";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 150;
            // 
            // colPista
            // 
            colPista.HeaderText = "Pista";
            colPista.MinimumWidth = 8;
            colPista.Name = "colPista";
            colPista.ReadOnly = true;
            colPista.Width = 150;
            // 
            // colPeligro
            // 
            colPeligro.HeaderText = "Peligro";
            colPeligro.MinimumWidth = 8;
            colPeligro.Name = "colPeligro";
            colPeligro.ReadOnly = true;
            colPeligro.Width = 150;
            // 
            // FrmRutaTesoro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 639);
            Controls.Add(lblEstado);
            Controls.Add(dgvRuta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnInsertar);
            Controls.Add(numPeligro);
            Controls.Add(lblPeligro);
            Controls.Add(txtPista);
            Controls.Add(lblPista);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(numId);
            Controls.Add(lblId);
            Controls.Add(lblTitulo);
            Name = "FrmRutaTesoro";
            Text = "RutaTesoro";
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeligro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblId;
        private NumericUpDown numId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPista;
        private TextBox txtPista;
        private Label lblPeligro;
        private NumericUpDown numPeligro;
        private Button btnInsertar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label lblEstado;
        private DataGridView dgvRuta;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPista;
        private DataGridViewTextBoxColumn colPeligro;
    }
}
