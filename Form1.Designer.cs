
namespace Romina.Celis.prog
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btnsalir1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btninventario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(193, 212);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(261, 23);
            this.btnregistrar.TabIndex = 0;
            this.btnregistrar.Text = "REGISTRAR LIBRO";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.Location = new System.Drawing.Point(193, 284);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(261, 23);
            this.btnusuario.TabIndex = 1;
            this.btnusuario.Text = "REGISTRAR USUARIO";
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // btnsalir1
            // 
            this.btnsalir1.Location = new System.Drawing.Point(561, 391);
            this.btnsalir1.Name = "btnsalir1";
            this.btnsalir1.Size = new System.Drawing.Size(75, 23);
            this.btnsalir1.TabIndex = 3;
            this.btnsalir1.Text = "SALIR";
            this.btnsalir1.UseVisualStyleBackColor = true;
            this.btnsalir1.Click += new System.EventHandler(this.btnsalir1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(2, 2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // btninventario
            // 
            this.btninventario.Location = new System.Drawing.Point(193, 351);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(261, 23);
            this.btninventario.TabIndex = 5;
            this.btninventario.Text = "INVENTARIO ";
            this.btninventario.UseVisualStyleBackColor = true;
            this.btninventario.Click += new System.EventHandler(this.btninventario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 106);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btninventario);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnsalir1);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btnregistrar);
            this.Name = "principal";
            this.Text = "BIBLIOTECA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Button btnsalir1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

