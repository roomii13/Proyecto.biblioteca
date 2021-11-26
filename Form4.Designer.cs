
namespace Romina.Celis.prog
{
    partial class inventarioform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventarioform));
            this.btnsalir3 = new System.Windows.Forms.Button();
            this.invenrichtxtbox = new System.Windows.Forms.RichTextBox();
            this.btnregsitrados = new System.Windows.Forms.Button();
            this.btnusuarioreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalir3
            // 
            this.btnsalir3.Location = new System.Drawing.Point(549, 400);
            this.btnsalir3.Name = "btnsalir3";
            this.btnsalir3.Size = new System.Drawing.Size(75, 23);
            this.btnsalir3.TabIndex = 0;
            this.btnsalir3.Text = "SALIR";
            this.btnsalir3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir3.UseVisualStyleBackColor = true;
            this.btnsalir3.Click += new System.EventHandler(this.btnsalir3_Click);
            // 
            // invenrichtxtbox
            // 
            this.invenrichtxtbox.Location = new System.Drawing.Point(100, 88);
            this.invenrichtxtbox.Name = "invenrichtxtbox";
            this.invenrichtxtbox.Size = new System.Drawing.Size(524, 274);
            this.invenrichtxtbox.TabIndex = 1;
            this.invenrichtxtbox.Text = "";
            this.invenrichtxtbox.TextChanged += new System.EventHandler(this.invenrichtxtbox_TextChanged);
            // 
            // btnregsitrados
            // 
            this.btnregsitrados.Location = new System.Drawing.Point(58, 44);
            this.btnregsitrados.Name = "btnregsitrados";
            this.btnregsitrados.Size = new System.Drawing.Size(259, 23);
            this.btnregsitrados.TabIndex = 2;
            this.btnregsitrados.Text = "VER LIBROS REGISTRADOS";
            this.btnregsitrados.UseVisualStyleBackColor = true;
            this.btnregsitrados.Click += new System.EventHandler(this.btnregsitrados_Click);
            // 
            // btnusuarioreg
            // 
            this.btnusuarioreg.Location = new System.Drawing.Point(421, 48);
            this.btnusuarioreg.Name = "btnusuarioreg";
            this.btnusuarioreg.Size = new System.Drawing.Size(262, 23);
            this.btnusuarioreg.TabIndex = 3;
            this.btnusuarioreg.Text = "VER USUARIOS REGISTRADOS";
            this.btnusuarioreg.UseVisualStyleBackColor = true;
            this.btnusuarioreg.Click += new System.EventHandler(this.btnusuarioreg_Click);
            // 
            // inventarioform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnusuarioreg);
            this.Controls.Add(this.btnregsitrados);
            this.Controls.Add(this.invenrichtxtbox);
            this.Controls.Add(this.btnsalir3);
            this.Name = "inventarioform";
            this.Text = "INVENTARIO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsalir3;
        private System.Windows.Forms.RichTextBox invenrichtxtbox;
        private System.Windows.Forms.Button btnregsitrados;
        private System.Windows.Forms.Button btnusuarioreg;
    }
}