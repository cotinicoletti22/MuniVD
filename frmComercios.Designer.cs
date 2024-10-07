namespace MuniVD_Geo
{
    partial class frmComercios
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.btnRelieve = new System.Windows.Forms.Button();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdComercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Comercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NActa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Comerciante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Comerciante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(549, 308);
            this.gMapControl1.TabIndex = 137;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 341);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 20);
            this.textBox1.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 139;
            this.label1.Text = "Nombre Comercio :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnOriginal);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.btnSatelite);
            this.groupBox1.Controls.Add(this.btnRelieve);
            this.groupBox1.Controls.Add(this.trackZoom);
            this.groupBox1.Location = new System.Drawing.Point(567, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 111);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles de mapa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 152;
            this.label9.Text = "Mapa: ";
            // 
            // btnOriginal
            // 
            this.btnOriginal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOriginal.ForeColor = System.Drawing.Color.White;
            this.btnOriginal.Location = new System.Drawing.Point(75, 29);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(60, 23);
            this.btnOriginal.TabIndex = 148;
            this.btnOriginal.Text = "Normal";
            this.btnOriginal.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 151;
            this.label22.Text = "Zoom:";
            // 
            // btnSatelite
            // 
            this.btnSatelite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSatelite.ForeColor = System.Drawing.Color.White;
            this.btnSatelite.Location = new System.Drawing.Point(194, 29);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(61, 23);
            this.btnSatelite.TabIndex = 153;
            this.btnSatelite.Text = "Satelite";
            this.btnSatelite.UseVisualStyleBackColor = false;
            // 
            // btnRelieve
            // 
            this.btnRelieve.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRelieve.ForeColor = System.Drawing.Color.White;
            this.btnRelieve.Location = new System.Drawing.Point(133, 29);
            this.btnRelieve.Name = "btnRelieve";
            this.btnRelieve.Size = new System.Drawing.Size(61, 23);
            this.btnRelieve.TabIndex = 149;
            this.btnRelieve.Text = "Relieve";
            this.btnRelieve.UseVisualStyleBackColor = false;
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(11, 78);
            this.trackZoom.Maximum = 25;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(235, 45);
            this.trackZoom.TabIndex = 150;
            this.trackZoom.Value = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdComercio,
            this.Nombre_Comercio,
            this.Latitud,
            this.Longitud,
            this.IdCondicion,
            this.Direccion,
            this.NActa,
            this.Id_Comerciante,
            this.Telefono_Comerciante,
            this.Id_Barrio,
            this.Id_Localidad,
            this.Id_Provincia,
            this.Id_Calle,
            this.Id_Rubro});
            this.dataGridView1.Location = new System.Drawing.Point(567, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 190);
            this.dataGridView1.TabIndex = 157;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdComercio
            // 
            this.IdComercio.HeaderText = "IdComercio";
            this.IdComercio.Name = "IdComercio";
            this.IdComercio.Visible = false;
            // 
            // Nombre_Comercio
            // 
            this.Nombre_Comercio.HeaderText = "Nombre_Comercio";
            this.Nombre_Comercio.Name = "Nombre_Comercio";
            // 
            // Latitud
            // 
            this.Latitud.HeaderText = "Latitud";
            this.Latitud.Name = "Latitud";
            // 
            // Longitud
            // 
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.Name = "Longitud";
            // 
            // IdCondicion
            // 
            this.IdCondicion.HeaderText = "IdCondicion";
            this.IdCondicion.Name = "IdCondicion";
            this.IdCondicion.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // NActa
            // 
            this.NActa.HeaderText = "NActa";
            this.NActa.Name = "NActa";
            this.NActa.Visible = false;
            // 
            // Id_Comerciante
            // 
            this.Id_Comerciante.HeaderText = "Id_Comerciante";
            this.Id_Comerciante.Name = "Id_Comerciante";
            this.Id_Comerciante.Visible = false;
            // 
            // Telefono_Comerciante
            // 
            this.Telefono_Comerciante.HeaderText = "Telefono_Comerciante";
            this.Telefono_Comerciante.Name = "Telefono_Comerciante";
            // 
            // Id_Barrio
            // 
            this.Id_Barrio.HeaderText = "Id_Barrio";
            this.Id_Barrio.Name = "Id_Barrio";
            this.Id_Barrio.Visible = false;
            // 
            // Id_Localidad
            // 
            this.Id_Localidad.HeaderText = "Id_Localidad";
            this.Id_Localidad.Name = "Id_Localidad";
            this.Id_Localidad.Visible = false;
            // 
            // Id_Provincia
            // 
            this.Id_Provincia.HeaderText = "Id_Provincia";
            this.Id_Provincia.Name = "Id_Provincia";
            this.Id_Provincia.Visible = false;
            // 
            // Id_Calle
            // 
            this.Id_Calle.HeaderText = "Id_Calle";
            this.Id_Calle.Name = "Id_Calle";
            this.Id_Calle.Visible = false;
            // 
            // Id_Rubro
            // 
            this.Id_Rubro.HeaderText = "Id_Rubro";
            this.Id_Rubro.Name = "Id_Rubro";
            this.Id_Rubro.Visible = false;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(13, 434);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(51, 13);
            this.lblLongitud.TabIndex = 158;
            this.lblLongitud.Text = "Longitud:";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Location = new System.Drawing.Point(13, 388);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(42, 13);
            this.lblLatitud.TabIndex = 159;
            this.lblLatitud.Text = "Latitud:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(600, 388);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(114, 13);
            this.lblTelefono.TabIndex = 160;
            this.lblTelefono.Text = "Telefono Comerciante:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(600, 341);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 161;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(116, 385);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(445, 20);
            this.txtLatitud.TabIndex = 162;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(116, 434);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(445, 20);
            this.txtLongitud.TabIndex = 163;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(672, 338);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(365, 20);
            this.txtDireccion.TabIndex = 164;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(723, 381);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(394, 20);
            this.txtTelefono.TabIndex = 165;
            // 
            // frmComercios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 506);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblLatitud);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gMapControl1);
            this.Name = "frmComercios";
            this.Text = "frmComercios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnSatelite;
        private System.Windows.Forms.Button btnRelieve;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComercio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Comercio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NActa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Comerciante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Comerciante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Rubro;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}