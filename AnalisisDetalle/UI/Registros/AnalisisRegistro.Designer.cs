namespace AnalisisDetalle.UI.Registros
{
    partial class AnalisisRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalisisRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdAnalisisnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.AgregarUsuariobutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TiponumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TipotextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.IdAnalisisnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiponumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analisis ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // IdAnalisisnumericUpDown
            // 
            this.IdAnalisisnumericUpDown.Location = new System.Drawing.Point(119, 24);
            this.IdAnalisisnumericUpDown.Name = "IdAnalisisnumericUpDown";
            this.IdAnalisisnumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.IdAnalisisnumericUpDown.TabIndex = 3;
            // 
            // UsuariocomboBox
            // 
            this.UsuariocomboBox.FormattingEnabled = true;
            this.UsuariocomboBox.Location = new System.Drawing.Point(119, 61);
            this.UsuariocomboBox.Name = "UsuariocomboBox";
            this.UsuariocomboBox.Size = new System.Drawing.Size(93, 21);
            this.UsuariocomboBox.TabIndex = 4;
            // 
            // AgregarUsuariobutton
            // 
            this.AgregarUsuariobutton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarUsuariobutton.Image")));
            this.AgregarUsuariobutton.Location = new System.Drawing.Point(232, 61);
            this.AgregarUsuariobutton.Name = "AgregarUsuariobutton";
            this.AgregarUsuariobutton.Size = new System.Drawing.Size(75, 24);
            this.AgregarUsuariobutton.TabIndex = 5;
            this.AgregarUsuariobutton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo Id";
            // 
            // TiponumericUpDown
            // 
            this.TiponumericUpDown.Location = new System.Drawing.Point(119, 91);
            this.TiponumericUpDown.Name = "TiponumericUpDown";
            this.TiponumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.TiponumericUpDown.TabIndex = 7;
            // 
            // TipotextBox
            // 
            this.TipotextBox.Location = new System.Drawing.Point(119, 121);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(100, 20);
            this.TipotextBox.TabIndex = 8;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(281, 297);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 57);
            this.Eliminarbutton.TabIndex = 31;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(174, 297);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 57);
            this.GuardarButton.TabIndex = 30;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(59, 297);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 57);
            this.Nuevobutton.TabIndex = 29;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(12, 147);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(391, 118);
            this.DetalledataGridView.TabIndex = 32;
            // 
            // AnalisisRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 446);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.TipotextBox);
            this.Controls.Add(this.TiponumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgregarUsuariobutton);
            this.Controls.Add(this.UsuariocomboBox);
            this.Controls.Add(this.IdAnalisisnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnalisisRegistro";
            this.Text = "Analisis medicos";
            ((System.ComponentModel.ISupportInitialize)(this.IdAnalisisnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiponumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IdAnalisisnumericUpDown;
        private System.Windows.Forms.ComboBox UsuariocomboBox;
        private System.Windows.Forms.Button AgregarUsuariobutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TiponumericUpDown;
        private System.Windows.Forms.TextBox TipotextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DataGridView DetalledataGridView;
    }
}