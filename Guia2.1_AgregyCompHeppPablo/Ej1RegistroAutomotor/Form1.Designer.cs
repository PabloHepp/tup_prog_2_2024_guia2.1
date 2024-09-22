namespace Ej1RegistroAutomotor
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
            this.listBPersonas = new System.Windows.Forms.ListBox();
            this.listBRegistros = new System.Windows.Forms.ListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListarRegistros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBPersonas
            // 
            this.listBPersonas.FormattingEnabled = true;
            this.listBPersonas.Location = new System.Drawing.Point(30, 10);
            this.listBPersonas.Name = "listBPersonas";
            this.listBPersonas.Size = new System.Drawing.Size(502, 290);
            this.listBPersonas.TabIndex = 0;
            // 
            // listBRegistros
            // 
            this.listBRegistros.FormattingEnabled = true;
            this.listBRegistros.Location = new System.Drawing.Point(538, 10);
            this.listBRegistros.Name = "listBRegistros";
            this.listBRegistros.Size = new System.Drawing.Size(462, 290);
            this.listBRegistros.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(225, 317);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListarRegistros
            // 
            this.btnListarRegistros.Location = new System.Drawing.Point(754, 317);
            this.btnListarRegistros.Name = "btnListarRegistros";
            this.btnListarRegistros.Size = new System.Drawing.Size(75, 23);
            this.btnListarRegistros.TabIndex = 3;
            this.btnListarRegistros.Text = "ListarRegistros";
            this.btnListarRegistros.UseVisualStyleBackColor = true;
            this.btnListarRegistros.Click += new System.EventHandler(this.btnListarRegistros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 357);
            this.Controls.Add(this.btnListarRegistros);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.listBRegistros);
            this.Controls.Add(this.listBPersonas);
            this.Name = "Form1";
            this.Text = "RegistroVehicular";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBPersonas;
        public System.Windows.Forms.ListBox listBRegistros;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.Button btnListarRegistros;
    }
}

