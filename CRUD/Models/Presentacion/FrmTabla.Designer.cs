namespace CRUD.Models.Presentacion
{
    partial class FrmTabla
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxArtista = new System.Windows.Forms.TextBox();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.dateTimePickerlanzamiento = new System.Windows.Forms.DateTimePicker();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lanzamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duracion";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(177, 31);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(301, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxArtista
            // 
            this.textBoxArtista.Location = new System.Drawing.Point(177, 66);
            this.textBoxArtista.Name = "textBoxArtista";
            this.textBoxArtista.Size = new System.Drawing.Size(301, 20);
            this.textBoxArtista.TabIndex = 6;
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(177, 136);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(301, 20);
            this.textBoxAlbum.TabIndex = 7;
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Location = new System.Drawing.Point(177, 171);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(301, 20);
            this.textBoxDuracion.TabIndex = 8;
            // 
            // dateTimePickerlanzamiento
            // 
            this.dateTimePickerlanzamiento.Location = new System.Drawing.Point(177, 101);
            this.dateTimePickerlanzamiento.Name = "dateTimePickerlanzamiento";
            this.dateTimePickerlanzamiento.Size = new System.Drawing.Size(301, 20);
            this.dateTimePickerlanzamiento.TabIndex = 9;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(60, 271);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FrmTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 340);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dateTimePickerlanzamiento);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.textBoxArtista);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTabla";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FrmTabla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxArtista;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.DateTimePicker dateTimePickerlanzamiento;
        private System.Windows.Forms.Button buttonGuardar;
    }
}