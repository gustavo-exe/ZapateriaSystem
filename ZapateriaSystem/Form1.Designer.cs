namespace ZapateriaSystem
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.ClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actulizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VentaoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertarVentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VisualizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Black;
            menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 0, 0, 400);
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClienteToolStripMenuItem,
            this.EmpleadoToolStripMenuItem,
            this.ProductoToolStripMenuItem,
            this.InventarioToolStripMenuItem,
            this.VentaoolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(135, 588);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // ClienteToolStripMenuItem
            // 
            this.ClienteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ClienteToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem";
            this.ClienteToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.ClienteToolStripMenuItem.Text = "cliente";
            this.ClienteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmpleadoToolStripMenuItem
            // 
            this.EmpleadoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.EmpleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.actulizarToolStripMenuItem,
            this.VerToolStripMenuItem});
            this.EmpleadoToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem";
            this.EmpleadoToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.EmpleadoToolStripMenuItem.Text = "empleado";
            this.EmpleadoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.insertarToolStripMenuItem.Text = "insertar";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.insertarToolStripMenuItem_Click);
            // 
            // actulizarToolStripMenuItem
            // 
            this.actulizarToolStripMenuItem.Name = "actulizarToolStripMenuItem";
            this.actulizarToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.actulizarToolStripMenuItem.Text = "actualizar";
            this.actulizarToolStripMenuItem.Click += new System.EventHandler(this.actulizarToolStripMenuItem_Click);
            // 
            // VerToolStripMenuItem
            // 
            this.VerToolStripMenuItem.Name = "VerToolStripMenuItem";
            this.VerToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.VerToolStripMenuItem.Text = "ver";
            this.VerToolStripMenuItem.Click += new System.EventHandler(this.VerToolStripMenuItem_Click_1);
            // 
            // ProductoToolStripMenuItem
            // 
            this.ProductoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ProductoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProductoToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ProductoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem";
            this.ProductoToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.ProductoToolStripMenuItem.Text = "producto";
            this.ProductoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // InventarioToolStripMenuItem
            // 
            this.InventarioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.InventarioToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InventarioToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.InventarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.InventarioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem";
            this.InventarioToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.InventarioToolStripMenuItem.Text = "inventario";
            this.InventarioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VentaoolStripMenuItem
            // 
            this.VentaoolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.VentaoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertarVentaToolStripMenuItem1,
            this.VisualizarVentaToolStripMenuItem});
            this.VentaoolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.VentaoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.VentaoolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentaoolStripMenuItem.Name = "VentaoolStripMenuItem";
            this.VentaoolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.VentaoolStripMenuItem.Text = "venta";
            this.VentaoolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InsertarVentaToolStripMenuItem1
            // 
            this.InsertarVentaToolStripMenuItem1.Name = "InsertarVentaToolStripMenuItem1";
            this.InsertarVentaToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.InsertarVentaToolStripMenuItem1.Text = "Insertar";
            this.InsertarVentaToolStripMenuItem1.Click += new System.EventHandler(this.insertarToolStripMenuItem1_Click);
            // 
            // VisualizarVentaToolStripMenuItem
            // 
            this.VisualizarVentaToolStripMenuItem.Name = "VisualizarVentaToolStripMenuItem";
            this.VisualizarVentaToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.VisualizarVentaToolStripMenuItem.Text = "Visualizar";
            this.VisualizarVentaToolStripMenuItem.Click += new System.EventHandler(this.VisualizarVentaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tiempo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.IsMdiContainer = true;
            this.MainMenuStrip = menuStrip1;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Zapateria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VentaoolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actulizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertarVentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem VisualizarVentaToolStripMenuItem;
    }
}

