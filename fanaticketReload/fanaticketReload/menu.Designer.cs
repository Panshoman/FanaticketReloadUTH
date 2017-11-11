namespace fanaticketReload_Desktop
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.brnEvento = new System.Windows.Forms.Button();
            this.btnSoporte = new System.Windows.Forms.Button();
            this.logo2 = new fanaticketReload_Desktop.logo();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(90, 169);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(105, 32);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(106, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 27);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // brnEvento
            // 
            this.brnEvento.BackColor = System.Drawing.Color.DodgerBlue;
            this.brnEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.brnEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.brnEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnEvento.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEvento.ForeColor = System.Drawing.SystemColors.Control;
            this.brnEvento.Image = ((System.Drawing.Image)(resources.GetObject("brnEvento.Image")));
            this.brnEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnEvento.Location = new System.Drawing.Point(90, 131);
            this.brnEvento.Name = "brnEvento";
            this.brnEvento.Size = new System.Drawing.Size(105, 32);
            this.brnEvento.TabIndex = 7;
            this.brnEvento.Text = "&Evento";
            this.brnEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.brnEvento.UseVisualStyleBackColor = false;
            // 
            // btnSoporte
            // 
            this.btnSoporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSoporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSoporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoporte.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSoporte.Image = ((System.Drawing.Image)(resources.GetObject("btnSoporte.Image")));
            this.btnSoporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoporte.Location = new System.Drawing.Point(90, 93);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(105, 32);
            this.btnSoporte.TabIndex = 6;
            this.btnSoporte.Text = "&Soporte";
            this.btnSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSoporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSoporte.UseVisualStyleBackColor = false;
            this.btnSoporte.Click += new System.EventHandler(this.btnSoporte_Click);
            // 
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logo2.Location = new System.Drawing.Point(3, -1);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(285, 69);
            this.logo2.TabIndex = 11;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(287, 271);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.brnEvento);
            this.Controls.Add(this.btnSoporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button brnEvento;
        private System.Windows.Forms.Button btnSoporte;
        private logo logo2;
    }
}