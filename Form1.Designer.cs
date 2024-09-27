namespace MuniVD_Geo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.btnRelieve = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.Longitud = new System.Windows.Forms.Label();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.txtCoord2 = new System.Windows.Forms.TextBox();
            this.txtCoord1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
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
            this.gMapControl1.Size = new System.Drawing.Size(809, 537);
            this.gMapControl1.TabIndex = 136;
            this.gMapControl1.Zoom = 0D;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1046, 150);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(25, 25);
            this.btnCopy.TabIndex = 154;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSatelite
            // 
            this.btnSatelite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSatelite.ForeColor = System.Drawing.Color.White;
            this.btnSatelite.Location = new System.Drawing.Point(1010, 66);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(61, 23);
            this.btnSatelite.TabIndex = 153;
            this.btnSatelite.Text = "Satelite";
            this.btnSatelite.UseVisualStyleBackColor = false;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(846, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 152;
            this.label9.Text = "Mapa: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(827, 95);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 151;
            this.label22.Text = "Zoom:";
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(827, 115);
            this.trackZoom.Maximum = 25;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(235, 45);
            this.trackZoom.TabIndex = 150;
            this.trackZoom.Value = 12;
            this.trackZoom.ValueChanged += new System.EventHandler(this.trackZoom_ValueChanged);
            // 
            // btnRelieve
            // 
            this.btnRelieve.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRelieve.ForeColor = System.Drawing.Color.White;
            this.btnRelieve.Location = new System.Drawing.Point(949, 66);
            this.btnRelieve.Name = "btnRelieve";
            this.btnRelieve.Size = new System.Drawing.Size(61, 23);
            this.btnRelieve.TabIndex = 149;
            this.btnRelieve.Text = "Relieve";
            this.btnRelieve.UseVisualStyleBackColor = false;
            this.btnRelieve.Click += new System.EventHandler(this.btnRelieve_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOriginal.ForeColor = System.Drawing.Color.White;
            this.btnOriginal.Location = new System.Drawing.Point(891, 66);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(60, 23);
            this.btnOriginal.TabIndex = 148;
            this.btnOriginal.Text = "Normal";
            this.btnOriginal.UseVisualStyleBackColor = false;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(833, 39);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(51, 13);
            this.Longitud.TabIndex = 147;
            this.Longitud.Text = "Longitud:";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Location = new System.Drawing.Point(839, 9);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(45, 13);
            this.lblLatitud.TabIndex = 146;
            this.lblLatitud.Text = "Latitud: ";
            // 
            // txtCoord2
            // 
            this.txtCoord2.Enabled = false;
            this.txtCoord2.Location = new System.Drawing.Point(892, 36);
            this.txtCoord2.MaxLength = 20;
            this.txtCoord2.Name = "txtCoord2";
            this.txtCoord2.Size = new System.Drawing.Size(179, 20);
            this.txtCoord2.TabIndex = 145;
            // 
            // txtCoord1
            // 
            this.txtCoord1.Enabled = false;
            this.txtCoord1.Location = new System.Drawing.Point(892, 6);
            this.txtCoord1.MaxLength = 20;
            this.txtCoord1.Name = "txtCoord1";
            this.txtCoord1.Size = new System.Drawing.Size(179, 20);
            this.txtCoord1.TabIndex = 144;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSatelite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.btnRelieve);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.Longitud);
            this.Controls.Add(this.lblLatitud);
            this.Controls.Add(this.txtCoord2);
            this.Controls.Add(this.txtCoord1);
            this.Controls.Add(this.gMapControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSatelite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Button btnRelieve;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Label Longitud;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.TextBox txtCoord2;
        private System.Windows.Forms.TextBox txtCoord1;
    }
}

