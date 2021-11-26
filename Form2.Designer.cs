
namespace Romina.Celis.prog
{
    partial class librosform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(librosform));
            this.btnsalir2 = new System.Windows.Forms.Button();
            this.labelautor = new System.Windows.Forms.Label();
            this.labellibro = new System.Windows.Forms.Label();
            this.autortxtbox = new System.Windows.Forms.TextBox();
            this.librotxtbox = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalir2
            // 
            this.btnsalir2.Location = new System.Drawing.Point(508, 378);
            this.btnsalir2.Name = "btnsalir2";
            this.btnsalir2.Size = new System.Drawing.Size(75, 23);
            this.btnsalir2.TabIndex = 0;
            this.btnsalir2.Text = "SALIR";
            this.btnsalir2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsalir2.UseVisualStyleBackColor = true;
            this.btnsalir2.Click += new System.EventHandler(this.btnsalir2_Click);
            // 
            // labelautor
            // 
            this.labelautor.AutoSize = true;
            this.labelautor.Location = new System.Drawing.Point(83, 61);
            this.labelautor.Name = "labelautor";
            this.labelautor.Size = new System.Drawing.Size(119, 13);
            this.labelautor.TabIndex = 2;
            this.labelautor.Text = "NOMBRE DEL AUTOR";
            // 
            // labellibro
            // 
            this.labellibro.AutoSize = true;
            this.labellibro.Location = new System.Drawing.Point(83, 179);
            this.labellibro.Name = "labellibro";
            this.labellibro.Size = new System.Drawing.Size(113, 13);
            this.labellibro.TabIndex = 3;
            this.labellibro.Text = "NOMBRE DEL LIBRO";
            // 
            // autortxtbox
            // 
            this.autortxtbox.Location = new System.Drawing.Point(86, 107);
            this.autortxtbox.Name = "autortxtbox";
            this.autortxtbox.Size = new System.Drawing.Size(278, 20);
            this.autortxtbox.TabIndex = 5;
            // 
            // librotxtbox
            // 
            this.librotxtbox.Location = new System.Drawing.Point(86, 240);
            this.librotxtbox.Name = "librotxtbox";
            this.librotxtbox.Size = new System.Drawing.Size(278, 20);
            this.librotxtbox.TabIndex = 6;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(198, 378);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(86, 23);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // librosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.librotxtbox);
            this.Controls.Add(this.autortxtbox);
            this.Controls.Add(this.labellibro);
            this.Controls.Add(this.labelautor);
            this.Controls.Add(this.btnsalir2);
            this.Name = "librosform";
            this.Text = "REGISTRO DE LIBROS";
            this.Load += new System.EventHandler(this.librosform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir2;
        private System.Windows.Forms.Label labelautor;
        private System.Windows.Forms.Label labellibro;
        private System.Windows.Forms.TextBox autortxtbox;
        private System.Windows.Forms.TextBox librotxtbox;
        private System.Windows.Forms.Button btnregistrar;
    }
}