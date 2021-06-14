
namespace Views
{
    partial class FrmNuevoVehiculo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevoModelo = new System.Windows.Forms.Button();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMotor = new System.Windows.Forms.ComboBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.lblModelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgModels)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBrands
            // 
            this.cbxBrands.FormattingEnabled = true;
            this.cbxBrands.Location = new System.Drawing.Point(54, 87);
            this.cbxBrands.Name = "cbxBrands";
            this.cbxBrands.Size = new System.Drawing.Size(218, 24);
            this.cbxBrands.TabIndex = 0;
            this.cbxBrands.SelectedValueChanged += new System.EventHandler(this.cbxBrands_SelectedValueChanged);
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(54, 130);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(218, 24);
            this.cbxTipoVehiculo.TabIndex = 1;
            this.cbxTipoVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxTipoVehiculo_SelectedValueChanged);
            // 
            // dgModels
            // 
            this.dgModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModels.Enabled = false;
            this.dgModels.Location = new System.Drawing.Point(54, 216);
            this.dgModels.Name = "dgModels";
            this.dgModels.RowHeadersWidth = 51;
            this.dgModels.RowTemplate.Height = 24;
            this.dgModels.Size = new System.Drawing.Size(1005, 653);
            this.dgModels.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // btnNuevoModelo
            // 
            this.btnNuevoModelo.Location = new System.Drawing.Point(875, 160);
            this.btnNuevoModelo.Name = "btnNuevoModelo";
            this.btnNuevoModelo.Size = new System.Drawing.Size(184, 50);
            this.btnNuevoModelo.TabIndex = 10;
            this.btnNuevoModelo.Text = "Agregar Modelo";
            this.btnNuevoModelo.UseVisualStyleBackColor = true;
            this.btnNuevoModelo.Click += new System.EventHandler(this.btnNuevoModelo_Click);
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(379, 52);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(233, 24);
            this.cbxColor.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color";
            // 
            // cbxMotor
            // 
            this.cbxMotor.FormattingEnabled = true;
            this.cbxMotor.Location = new System.Drawing.Point(379, 90);
            this.cbxMotor.Name = "cbxMotor";
            this.cbxMotor.Size = new System.Drawing.Size(233, 24);
            this.cbxMotor.TabIndex = 13;
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(635, 90);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(44, 17);
            this.lblMotor.TabIndex = 14;
            this.lblMotor.Text = "Motor";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(54, 50);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(218, 22);
            this.txtModelName.TabIndex = 15;
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(288, 53);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(58, 17);
            this.lblModelName.TabIndex = 16;
            this.lblModelName.Text = "Nombre";
            // 
            // FrmNuevoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 881);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.cbxMotor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.btnNuevoModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgModels);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.cbxBrands);
            this.Name = "FrmNuevoVehiculo";
            this.Text = "Nuevo Modelo";
            this.Load += new System.EventHandler(this.FrmNuevaOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxBrands;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.DataGridView dgModels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevoModelo;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMotor;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label lblModelName;
    }
}