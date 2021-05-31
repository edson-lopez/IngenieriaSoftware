
namespace Views
{
    partial class FrmNuevaOrden
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
            this.cbxBrands = new System.Windows.Forms.ComboBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.dgModels = new System.Windows.Forms.DataGridView();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevoDetalle = new System.Windows.Forms.Button();
            this.btnConfirmaOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgModels)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBrands
            // 
            this.cbxBrands.FormattingEnabled = true;
            this.cbxBrands.Location = new System.Drawing.Point(549, 43);
            this.cbxBrands.Name = "cbxBrands";
            this.cbxBrands.Size = new System.Drawing.Size(233, 24);
            this.cbxBrands.TabIndex = 0;
            this.cbxBrands.SelectedValueChanged += new System.EventHandler(this.cbxBrands_SelectedValueChanged);
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(55, 86);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(233, 24);
            this.cbxTipoVehiculo.TabIndex = 1;
            this.cbxTipoVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxTipoVehiculo_SelectedValueChanged);
            // 
            // dgModels
            // 
            this.dgModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModels.Enabled = false;
            this.dgModels.Location = new System.Drawing.Point(55, 293);
            this.dgModels.Name = "dgModels";
            this.dgModels.RowHeadersWidth = 51;
            this.dgModels.RowTemplate.Height = 24;
            this.dgModels.Size = new System.Drawing.Size(889, 257);
            this.dgModels.TabIndex = 2;
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(549, 86);
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(233, 24);
            this.cbxModel.TabIndex = 3;
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(55, 43);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(233, 24);
            this.cbxClient.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nueva Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(797, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // btnNuevoDetalle
            // 
            this.btnNuevoDetalle.Enabled = false;
            this.btnNuevoDetalle.Location = new System.Drawing.Point(747, 235);
            this.btnNuevoDetalle.Name = "btnNuevoDetalle";
            this.btnNuevoDetalle.Size = new System.Drawing.Size(197, 40);
            this.btnNuevoDetalle.TabIndex = 10;
            this.btnNuevoDetalle.Text = "Añadir Personalización";
            this.btnNuevoDetalle.UseVisualStyleBackColor = true;
            this.btnNuevoDetalle.Click += new System.EventHandler(this.btnNuevoDetalle_Click);
            // 
            // btnConfirmaOrden
            // 
            this.btnConfirmaOrden.Location = new System.Drawing.Point(55, 135);
            this.btnConfirmaOrden.Name = "btnConfirmaOrden";
            this.btnConfirmaOrden.Size = new System.Drawing.Size(202, 40);
            this.btnConfirmaOrden.TabIndex = 11;
            this.btnConfirmaOrden.Text = "Confirmar Orden";
            this.btnConfirmaOrden.UseVisualStyleBackColor = true;
            this.btnConfirmaOrden.Click += new System.EventHandler(this.btnConfirmaOrden_Click);
            // 
            // FrmNuevaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 562);
            this.Controls.Add(this.btnConfirmaOrden);
            this.Controls.Add(this.btnNuevoDetalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.cbxModel);
            this.Controls.Add(this.dgModels);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.cbxBrands);
            this.Name = "FrmNuevaOrden";
            this.Text = "FrmNuevaOrden";
            this.Load += new System.EventHandler(this.FrmNuevaOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxBrands;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.DataGridView dgModels;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevoDetalle;
        private System.Windows.Forms.Button btnConfirmaOrden;
    }
}