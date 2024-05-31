namespace productosdb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbdescripcion = new TextBox();
            tbprecio = new TextBox();
            lbldescripcion = new Label();
            lblprecio = new Label();
            btnagregar = new Button();
            SuspendLayout();
            // 
            // tbdescripcion
            // 
            tbdescripcion.Location = new Point(273, 94);
            tbdescripcion.Name = "tbdescripcion";
            tbdescripcion.Size = new Size(140, 23);
            tbdescripcion.TabIndex = 0;
            // 
            // tbprecio
            // 
            tbprecio.Location = new Point(273, 138);
            tbprecio.Name = "tbprecio";
            tbprecio.Size = new Size(140, 23);
            tbprecio.TabIndex = 1;
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Location = new Point(139, 97);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(128, 15);
            lbldescripcion.TabIndex = 2;
            lbldescripcion.Text = "Descripción de artículo";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(191, 146);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(40, 15);
            lblprecio.TabIndex = 3;
            lblprecio.Text = "Precio";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(245, 189);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 256);
            Controls.Add(btnagregar);
            Controls.Add(lblprecio);
            Controls.Add(lbldescripcion);
            Controls.Add(tbprecio);
            Controls.Add(tbdescripcion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbdescripcion;
        private TextBox tbprecio;
        private Label lbldescripcion;
        private Label lblprecio;
        private Button btnagregar;
    }
}
