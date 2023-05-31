namespace Accesorios.View
{
    partial class frmAgregarProducto
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroComboEstado = new MetroFramework.Controls.MetroComboBox();
            this.metroComboCategoria = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTexPrecioUnitario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTexboxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(358, 271);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(153, 38);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 43;
            this.metroButton2.Text = "Cancelar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.metroLabel3);
            this.metroTile1.Location = new System.Drawing.Point(0, 5);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(618, 45);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 42;
            this.metroTile1.Text = "Administracion de Productos";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(575, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(24, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "X";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(109, 271);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(153, 38);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 41;
            this.metroButton1.Text = "Guardar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(354, 102);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(75, 19);
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "Categoria";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(354, 180);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 19);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Estado";
            // 
            // metroComboEstado
            // 
            this.metroComboEstado.FormattingEnabled = true;
            this.metroComboEstado.ItemHeight = 23;
            this.metroComboEstado.Location = new System.Drawing.Point(354, 202);
            this.metroComboEstado.Name = "metroComboEstado";
            this.metroComboEstado.Size = new System.Drawing.Size(234, 29);
            this.metroComboEstado.TabIndex = 38;
            this.metroComboEstado.UseSelectable = true;
            // 
            // metroComboCategoria
            // 
            this.metroComboCategoria.FormattingEnabled = true;
            this.metroComboCategoria.ItemHeight = 23;
            this.metroComboCategoria.Location = new System.Drawing.Point(354, 124);
            this.metroComboCategoria.Name = "metroComboCategoria";
            this.metroComboCategoria.Size = new System.Drawing.Size(234, 29);
            this.metroComboCategoria.TabIndex = 37;
            this.metroComboCategoria.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(39, 156);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Descripcion";
            // 
            // metroTextDescripcion
            // 
            // 
            // 
            // 
            this.metroTextDescripcion.CustomButton.Image = null;
            this.metroTextDescripcion.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.metroTextDescripcion.CustomButton.Name = "";
            this.metroTextDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextDescripcion.CustomButton.TabIndex = 1;
            this.metroTextDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextDescripcion.CustomButton.UseSelectable = true;
            this.metroTextDescripcion.CustomButton.Visible = false;
            this.metroTextDescripcion.Lines = new string[0];
            this.metroTextDescripcion.Location = new System.Drawing.Point(151, 156);
            this.metroTextDescripcion.MaxLength = 32767;
            this.metroTextDescripcion.Name = "metroTextDescripcion";
            this.metroTextDescripcion.PasswordChar = '\0';
            this.metroTextDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextDescripcion.SelectedText = "";
            this.metroTextDescripcion.SelectionLength = 0;
            this.metroTextDescripcion.SelectionStart = 0;
            this.metroTextDescripcion.ShortcutsEnabled = true;
            this.metroTextDescripcion.Size = new System.Drawing.Size(145, 23);
            this.metroTextDescripcion.TabIndex = 35;
            this.metroTextDescripcion.UseSelectable = true;
            this.metroTextDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(39, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "PrecioUnitario";
            // 
            // metroTexPrecioUnitario
            // 
            // 
            // 
            // 
            this.metroTexPrecioUnitario.CustomButton.Image = null;
            this.metroTexPrecioUnitario.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.metroTexPrecioUnitario.CustomButton.Name = "";
            this.metroTexPrecioUnitario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTexPrecioUnitario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTexPrecioUnitario.CustomButton.TabIndex = 1;
            this.metroTexPrecioUnitario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTexPrecioUnitario.CustomButton.UseSelectable = true;
            this.metroTexPrecioUnitario.CustomButton.Visible = false;
            this.metroTexPrecioUnitario.Lines = new string[0];
            this.metroTexPrecioUnitario.Location = new System.Drawing.Point(151, 208);
            this.metroTexPrecioUnitario.MaxLength = 32767;
            this.metroTexPrecioUnitario.Name = "metroTexPrecioUnitario";
            this.metroTexPrecioUnitario.PasswordChar = '\0';
            this.metroTexPrecioUnitario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTexPrecioUnitario.SelectedText = "";
            this.metroTexPrecioUnitario.SelectionLength = 0;
            this.metroTexPrecioUnitario.SelectionStart = 0;
            this.metroTexPrecioUnitario.ShortcutsEnabled = true;
            this.metroTexPrecioUnitario.Size = new System.Drawing.Size(145, 23);
            this.metroTexPrecioUnitario.TabIndex = 33;
            this.metroTexPrecioUnitario.UseSelectable = true;
            this.metroTexPrecioUnitario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTexPrecioUnitario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(39, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Nombre";
            // 
            // metroTexboxNombre
            // 
            // 
            // 
            // 
            this.metroTexboxNombre.CustomButton.Image = null;
            this.metroTexboxNombre.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.metroTexboxNombre.CustomButton.Name = "";
            this.metroTexboxNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTexboxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTexboxNombre.CustomButton.TabIndex = 1;
            this.metroTexboxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTexboxNombre.CustomButton.UseSelectable = true;
            this.metroTexboxNombre.CustomButton.Visible = false;
            this.metroTexboxNombre.Lines = new string[0];
            this.metroTexboxNombre.Location = new System.Drawing.Point(151, 102);
            this.metroTexboxNombre.MaxLength = 32767;
            this.metroTexboxNombre.Name = "metroTexboxNombre";
            this.metroTexboxNombre.PasswordChar = '\0';
            this.metroTexboxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTexboxNombre.SelectedText = "";
            this.metroTexboxNombre.SelectionLength = 0;
            this.metroTexboxNombre.SelectionStart = 0;
            this.metroTexboxNombre.ShortcutsEnabled = true;
            this.metroTexboxNombre.Size = new System.Drawing.Size(145, 23);
            this.metroTexboxNombre.TabIndex = 31;
            this.metroTexboxNombre.UseSelectable = true;
            this.metroTexboxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTexboxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 356);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroComboEstado);
            this.Controls.Add(this.metroComboCategoria);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextDescripcion);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTexPrecioUnitario);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTexboxNombre);
            this.Name = "frmAgregarProducto";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboEstado;
        private MetroFramework.Controls.MetroComboBox metroComboCategoria;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTexPrecioUnitario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTexboxNombre;
    }
}