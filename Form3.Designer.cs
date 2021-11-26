
namespace Romina.Celis.prog
{
    partial class usuarioform
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
            this.labelnombre = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.diretxtbox = new System.Windows.Forms.TextBox();
            this.nomyaptxtbox1 = new System.Windows.Forms.TextBox();
            this.telfonotxtbox = new System.Windows.Forms.TextBox();
            this.btnregistrar2 = new System.Windows.Forms.Button();
            this.btnsalir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(71, 71);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(119, 13);
            this.labelnombre.TabIndex = 0;
            this.labelnombre.Text = "NOMBRE Y APELLIDO";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Location = new System.Drawing.Point(71, 135);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(66, 13);
            this.labeldireccion.TabIndex = 1;
            this.labeldireccion.Text = "DIRECCION";
            // 
            // labeltelefono
            // 
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.Location = new System.Drawing.Point(71, 204);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(64, 13);
            this.labeltelefono.TabIndex = 2;
            this.labeltelefono.Text = "TELEFONO";
            // 
            // diretxtbox
            // 
            this.diretxtbox.Location = new System.Drawing.Point(74, 163);
            this.diretxtbox.Name = "diretxtbox";
            this.diretxtbox.Size = new System.Drawing.Size(346, 20);
            this.diretxtbox.TabIndex = 3;
            // 
            // nomyaptxtbox1
            // 
            this.nomyaptxtbox1.Location = new System.Drawing.Point(74, 98);
            this.nomyaptxtbox1.Name = "nomyaptxtbox1";
            this.nomyaptxtbox1.Size = new System.Drawing.Size(346, 20);
            this.nomyaptxtbox1.TabIndex = 4;
            // 
            // telfonotxtbox
            // 
            this.telfonotxtbox.Location = new System.Drawing.Point(74, 241);
            this.telfonotxtbox.Name = "telfonotxtbox";
            this.telfonotxtbox.Size = new System.Drawing.Size(346, 20);
            this.telfonotxtbox.TabIndex = 5;
            // 
            // btnregistrar2
            // 
            this.btnregistrar2.Location = new System.Drawing.Point(203, 374);
            this.btnregistrar2.Name = "btnregistrar2";
            this.btnregistrar2.Size = new System.Drawing.Size(86, 23);
            this.btnregistrar2.TabIndex = 6;
            this.btnregistrar2.Text = "REGISTRAR";
            this.btnregistrar2.UseVisualStyleBackColor = true;
            this.btnregistrar2.Click += new System.EventHandler(this.btnregistrar2_Click);
            // 
            // btnsalir2
            // 
            this.btnsalir2.Location = new System.Drawing.Point(508, 374);
            this.btnsalir2.Name = "btnsalir2";
            this.btnsalir2.Size = new System.Drawing.Size(75, 23);
            this.btnsalir2.TabIndex = 7;
            this.btnsalir2.Text = "SALIR";
            this.btnsalir2.UseVisualStyleBackColor = true;
            this.btnsalir2.Click += new System.EventHandler(this.btnsalir2_Click);
            // 
            // usuarioform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir2);
            this.Controls.Add(this.btnregistrar2);
            this.Controls.Add(this.telfonotxtbox);
            this.Controls.Add(this.nomyaptxtbox1);
            this.Controls.Add(this.diretxtbox);
            this.Controls.Add(this.labeltelefono);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.labelnombre);
            this.Name = "usuarioform";
            this.Text = "USUARIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.TextBox diretxtbox;
        private System.Windows.Forms.TextBox nomyaptxtbox1;
        private System.Windows.Forms.TextBox telfonotxtbox;
        private System.Windows.Forms.Button btnregistrar2;
        private System.Windows.Forms.Button btnsalir2;
    }
}