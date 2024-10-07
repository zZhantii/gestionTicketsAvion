namespace Vuelos
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pictureBox1 = new PictureBox();
            dgvVuelos = new DataGridView();
            Vuelo_ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Asiento = new DataGridViewTextBoxColumn();
            Fila = new DataGridViewTextBoxColumn();
            Fecha_Ida = new DataGridViewTextBoxColumn();
            Fecha_Vuelta = new DataGridViewTextBoxColumn();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            LbeNombre = new Label();
            lbeApellido = new Label();
            lbeOrigen = new Label();
            txtOrigen = new TextBox();
            lbeDestino = new Label();
            txtDestino = new TextBox();
            btnAñadir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            dtpFecha_Ida = new DateTimePicker();
            dtpFecha_Vuelta = new DateTimePicker();
            label1 = new Label();
            txtVuelo_ID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVuelos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(784, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvVuelos
            // 
            dgvVuelos.AllowUserToAddRows = false;
            dgvVuelos.AllowUserToDeleteRows = false;
            dgvVuelos.BackgroundColor = Color.White;
            dgvVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVuelos.Columns.AddRange(new DataGridViewColumn[] { Vuelo_ID, Nombre, Apellido, Origen, Destino, Asiento, Fila, Fecha_Ida, Fecha_Vuelta });
            dgvVuelos.Location = new Point(12, 350);
            dgvVuelos.Name = "dgvVuelos";
            dgvVuelos.ReadOnly = true;
            dgvVuelos.RowHeadersWidth = 51;
            dgvVuelos.Size = new Size(1179, 188);
            dgvVuelos.TabIndex = 4;
            dgvVuelos.CellClick += dgvVuelos_CellClick;
            // 
            // Vuelo_ID
            // 
            Vuelo_ID.HeaderText = "Vuelo_ID";
            Vuelo_ID.MinimumWidth = 6;
            Vuelo_ID.Name = "Vuelo_ID";
            Vuelo_ID.ReadOnly = true;
            Vuelo_ID.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.MinimumWidth = 6;
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Width = 125;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.MinimumWidth = 6;
            Destino.Name = "Destino";
            Destino.ReadOnly = true;
            Destino.Width = 125;
            // 
            // Asiento
            // 
            Asiento.HeaderText = "Asiento";
            Asiento.MinimumWidth = 6;
            Asiento.Name = "Asiento";
            Asiento.ReadOnly = true;
            Asiento.Width = 125;
            // 
            // Fila
            // 
            Fila.HeaderText = "Fila";
            Fila.MinimumWidth = 6;
            Fila.Name = "Fila";
            Fila.ReadOnly = true;
            Fila.Width = 125;
            // 
            // Fecha_Ida
            // 
            Fecha_Ida.HeaderText = "Fecha_Ida";
            Fecha_Ida.MinimumWidth = 6;
            Fecha_Ida.Name = "Fecha_Ida";
            Fecha_Ida.ReadOnly = true;
            Fecha_Ida.Width = 125;
            // 
            // Fecha_Vuelta
            // 
            Fecha_Vuelta.HeaderText = "Fecha_Vuelta";
            Fecha_Vuelta.MinimumWidth = 6;
            Fecha_Vuelta.Name = "Fecha_Vuelta";
            Fecha_Vuelta.ReadOnly = true;
            Fecha_Vuelta.Width = 125;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 192);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(286, 192);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 6;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // LbeNombre
            // 
            LbeNombre.AutoSize = true;
            LbeNombre.Location = new Point(151, 166);
            LbeNombre.Name = "LbeNombre";
            LbeNombre.Size = new Size(69, 23);
            LbeNombre.TabIndex = 8;
            LbeNombre.Text = "Nombre";
            // 
            // lbeApellido
            // 
            lbeApellido.AutoSize = true;
            lbeApellido.Location = new Point(286, 166);
            lbeApellido.Name = "lbeApellido";
            lbeApellido.Size = new Size(72, 23);
            lbeApellido.TabIndex = 9;
            lbeApellido.Text = "Apellido";
            // 
            // lbeOrigen
            // 
            lbeOrigen.AutoSize = true;
            lbeOrigen.Location = new Point(417, 166);
            lbeOrigen.Name = "lbeOrigen";
            lbeOrigen.Size = new Size(60, 23);
            lbeOrigen.TabIndex = 12;
            lbeOrigen.Text = "Origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(417, 192);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(125, 27);
            txtOrigen.TabIndex = 11;
            txtOrigen.TextChanged += txtOrigen_TextChanged;
            // 
            // lbeDestino
            // 
            lbeDestino.AutoSize = true;
            lbeDestino.Location = new Point(548, 166);
            lbeDestino.Name = "lbeDestino";
            lbeDestino.Size = new Size(67, 23);
            lbeDestino.TabIndex = 14;
            lbeDestino.Text = "Destino";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(548, 192);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(125, 27);
            txtDestino.TabIndex = 13;
            txtDestino.TextChanged += txtDestino_TextChanged;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadir.Location = new Point(256, 620);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(205, 58);
            btnAñadir.TabIndex = 15;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(491, 620);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(205, 58);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(721, 620);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(205, 58);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(959, 620);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(205, 58);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dtpFecha_Ida
            // 
            dtpFecha_Ida.Location = new Point(688, 192);
            dtpFecha_Ida.Name = "dtpFecha_Ida";
            dtpFecha_Ida.Size = new Size(329, 27);
            dtpFecha_Ida.TabIndex = 19;
            // 
            // dtpFecha_Vuelta
            // 
            dtpFecha_Vuelta.Location = new Point(688, 263);
            dtpFecha_Vuelta.Name = "dtpFecha_Vuelta";
            dtpFecha_Vuelta.Size = new Size(329, 27);
            dtpFecha_Vuelta.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 167);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 22;
            label1.Text = "Vuelo_ID";
            // 
            // txtVuelo_ID
            // 
            txtVuelo_ID.Location = new Point(20, 193);
            txtVuelo_ID.Name = "txtVuelo_ID";
            txtVuelo_ID.Size = new Size(125, 27);
            txtVuelo_ID.TabIndex = 21;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Snow;
            ClientSize = new Size(1203, 718);
            Controls.Add(label1);
            Controls.Add(txtVuelo_ID);
            Controls.Add(dtpFecha_Vuelta);
            Controls.Add(dtpFecha_Ida);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAñadir);
            Controls.Add(lbeDestino);
            Controls.Add(txtDestino);
            Controls.Add(lbeOrigen);
            Controls.Add(txtOrigen);
            Controls.Add(lbeApellido);
            Controls.Add(LbeNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dgvVuelos);
            Controls.Add(pictureBox1);
            Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dgvVuelos;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label LbeNombre;
        private Label lbeApellido;
        private Label lbeOrigen;
        private TextBox txtOrigen;
        private Label lbeDestino;
        private TextBox txtDestino;
        private Button btnAñadir;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnSalir;
        private DateTimePicker dtpFecha_Ida;
        private DateTimePicker dtpFecha_Vuelta;
        private Label label1;
        private TextBox txtVuelo_ID;
        private DataGridViewTextBoxColumn Vuelo_ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Asiento;
        private DataGridViewTextBoxColumn Fila;
        private DataGridViewTextBoxColumn Fecha_Ida;
        private DataGridViewTextBoxColumn Fecha_Vuelta;
    }
}