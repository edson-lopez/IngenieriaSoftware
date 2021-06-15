
namespace Views
{
    partial class Main
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
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.GroupBox();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnEstadoFabrica = new System.Windows.Forms.Button();
            this.x1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.Location = new System.Drawing.Point(103, 44);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(271, 60);
            this.btnNuevaOrden.TabIndex = 0;
            this.btnNuevaOrden.Text = "Nueva Orden";
            this.btnNuevaOrden.UseVisualStyleBackColor = true;
            this.btnNuevaOrden.Click += new System.EventHandler(this.btnNuevaOrden_Click);
            // 
            // x1
            // 
            this.x1.Controls.Add(this.btnOrdenes);
            this.x1.Controls.Add(this.btnNuevaOrden);
            this.x1.Location = new System.Drawing.Point(741, 71);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(424, 224);
            this.x1.TabIndex = 1;
            this.x1.TabStop = false;
            this.x1.Text = "Vehiculos";
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Location = new System.Drawing.Point(103, 127);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(271, 60);
            this.btnOrdenes.TabIndex = 1;
            this.btnOrdenes.Text = "Historial";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Controls.Add(this.btnNuevoCliente);
            this.groupBox1.Location = new System.Drawing.Point(741, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(103, 127);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(271, 60);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Notificaciones";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(103, 44);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(271, 60);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Registro";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDepartamentos);
            this.groupBox2.Controls.Add(this.btnEstadoFabrica);
            this.groupBox2.Location = new System.Drawing.Point(741, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 224);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fábrica";
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.Location = new System.Drawing.Point(103, 127);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(271, 60);
            this.btnDepartamentos.TabIndex = 1;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // btnEstadoFabrica
            // 
            this.btnEstadoFabrica.Location = new System.Drawing.Point(103, 44);
            this.btnEstadoFabrica.Name = "btnEstadoFabrica";
            this.btnEstadoFabrica.Size = new System.Drawing.Size(271, 60);
            this.btnEstadoFabrica.TabIndex = 0;
            this.btnEstadoFabrica.Text = "Nuevo Modelo";
            this.btnEstadoFabrica.UseVisualStyleBackColor = true;
            this.btnEstadoFabrica.Click += new System.EventHandler(this.btnEstadoFabrica_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.x1);
            this.Name = "Main";
            this.Text = "Automóviles Uneatlantico";
            this.Load += new System.EventHandler(this.Main_Load);
            this.x1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.GroupBox x1;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Button btnEstadoFabrica;
    }
}

