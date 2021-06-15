
namespace Views
{
    partial class FrmCliente
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
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtClastname = new System.Windows.Forms.TextBox();
            this.txtCphone = new System.Windows.Forms.TextBox();
            this.txtCemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(44, 38);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(175, 22);
            this.txtCname.TabIndex = 0;
            // 
            // txtClastname
            // 
            this.txtClastname.Location = new System.Drawing.Point(392, 38);
            this.txtClastname.Name = "txtClastname";
            this.txtClastname.Size = new System.Drawing.Size(175, 22);
            this.txtClastname.TabIndex = 1;
            // 
            // txtCphone
            // 
            this.txtCphone.Location = new System.Drawing.Point(44, 80);
            this.txtCphone.Name = "txtCphone";
            this.txtCphone.Size = new System.Drawing.Size(175, 22);
            this.txtCphone.TabIndex = 2;
            // 
            // txtCemail
            // 
            this.txtCemail.Location = new System.Drawing.Point(392, 83);
            this.txtCemail.Name = "txtCemail";
            this.txtCemail.Size = new System.Drawing.Size(175, 22);
            this.txtCemail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "email";
            // 
            // dgClients
            // 
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Location = new System.Drawing.Point(12, 199);
            this.dgClients.Name = "dgClients";
            this.dgClients.RowHeadersWidth = 51;
            this.dgClients.RowTemplate.Height = 24;
            this.dgClients.Size = new System.Drawing.Size(759, 601);
            this.dgClients.TabIndex = 8;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Location = new System.Drawing.Point(638, 140);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(133, 34);
            this.btnCrearCliente.TabIndex = 9;
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 812);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCemail);
            this.Controls.Add(this.txtCphone);
            this.Controls.Add(this.txtClastname);
            this.Controls.Add(this.txtCname);
            this.Name = "FrmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtClastname;
        private System.Windows.Forms.TextBox txtCphone;
        private System.Windows.Forms.TextBox txtCemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.Button btnCrearCliente;
    }
}