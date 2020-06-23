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
            this.insertarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actulizarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actulizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actulizarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actulizarProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VentaoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertarVentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VisualizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.proveedorToolStripMenuItem,
            this.VentaoolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(124, 625);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // ClienteToolStripMenuItem
            // 
            this.ClienteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarClienteToolStripMenuItem1,
            this.actulizarClienteToolStripMenuItem1,
            this.verClientesToolStripMenuItem});
            this.ClienteToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem";
            this.ClienteToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.ClienteToolStripMenuItem.Text = "cliente";
            this.ClienteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClienteToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClienteToolStripMenuItem_MouseDown);
            this.ClienteToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClienteToolStripMenuItem_MouseMove);
            // 
            // insertarClienteToolStripMenuItem1
            // 
            this.insertarClienteToolStripMenuItem1.Name = "insertarClienteToolStripMenuItem1";
            this.insertarClienteToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.insertarClienteToolStripMenuItem1.Text = "insertar";
            this.insertarClienteToolStripMenuItem1.Click += new System.EventHandler(this.insertarToolStripMenuItem1_Click_1);
            // 
            // actulizarClienteToolStripMenuItem1
            // 
            this.actulizarClienteToolStripMenuItem1.Name = "actulizarClienteToolStripMenuItem1";
            this.actulizarClienteToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.actulizarClienteToolStripMenuItem1.Text = "actulizar";
            this.actulizarClienteToolStripMenuItem1.Click += new System.EventHandler(this.actulizarClienteToolStripMenuItem1_Click);
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.verClientesToolStripMenuItem.Text = "lista";
            this.verClientesToolStripMenuItem.Click += new System.EventHandler(this.verClientesToolStripMenuItem_Click);
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
            this.EmpleadoToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.EmpleadoToolStripMenuItem.Text = "empleado";
            this.EmpleadoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpleadoToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmpleadoToolStripMenuItem_MouseMove);
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
            this.VerToolStripMenuItem.Text = "lista";
            this.VerToolStripMenuItem.Click += new System.EventHandler(this.VerToolStripMenuItem_Click_1);
            // 
            // ProductoToolStripMenuItem
            // 
            this.ProductoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ProductoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarProductoToolStripMenuItem1,
            this.actulizarProductoToolStripMenuItem1,
            this.listaProductoToolStripMenuItem});
            this.ProductoToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ProductoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem";
            this.ProductoToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.ProductoToolStripMenuItem.Text = "producto";
            this.ProductoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ProductoToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProductoToolStripMenuItem_MouseMove);
            // 
            // insertarProductoToolStripMenuItem1
            // 
            this.insertarProductoToolStripMenuItem1.Name = "insertarProductoToolStripMenuItem1";
            this.insertarProductoToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.insertarProductoToolStripMenuItem1.Text = "insertar";
            this.insertarProductoToolStripMenuItem1.Click += new System.EventHandler(this.insertarProductoToolStripMenuItem1_Click);
            // 
            // actulizarProductoToolStripMenuItem1
            // 
            this.actulizarProductoToolStripMenuItem1.Name = "actulizarProductoToolStripMenuItem1";
            this.actulizarProductoToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.actulizarProductoToolStripMenuItem1.Text = "actulizar";
            this.actulizarProductoToolStripMenuItem1.Click += new System.EventHandler(this.actulizarProductoToolStripMenuItem1_Click);
            // 
            // listaProductoToolStripMenuItem
            // 
            this.listaProductoToolStripMenuItem.Name = "listaProductoToolStripMenuItem";
            this.listaProductoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.listaProductoToolStripMenuItem.Text = "lista";
            this.listaProductoToolStripMenuItem.Click += new System.EventHandler(this.listaProductoToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarProveedorToolStripMenuItem1,
            this.actulizarProveedorToolStripMenuItem1,
            this.listaProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.proveedorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.proveedorToolStripMenuItem.Text = "proveedor";
            this.proveedorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proveedorToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.proveedorToolStripMenuItem_MouseMove);
            // 
            // insertarProveedorToolStripMenuItem1
            // 
            this.insertarProveedorToolStripMenuItem1.Name = "insertarProveedorToolStripMenuItem1";
            this.insertarProveedorToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.insertarProveedorToolStripMenuItem1.Text = "insertar";
            this.insertarProveedorToolStripMenuItem1.Click += new System.EventHandler(this.insertarProveedorToolStripMenuItem1_Click);
            // 
            // actulizarProveedorToolStripMenuItem1
            // 
            this.actulizarProveedorToolStripMenuItem1.Name = "actulizarProveedorToolStripMenuItem1";
            this.actulizarProveedorToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.actulizarProveedorToolStripMenuItem1.Text = "actulizar";
            this.actulizarProveedorToolStripMenuItem1.Click += new System.EventHandler(this.actulizarProveedorToolStripMenuItem1_Click);
            // 
            // listaProveedorToolStripMenuItem
            // 
            this.listaProveedorToolStripMenuItem.Name = "listaProveedorToolStripMenuItem";
            this.listaProveedorToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.listaProveedorToolStripMenuItem.Text = "lista";
            this.listaProveedorToolStripMenuItem.Click += new System.EventHandler(this.listaProveedorToolStripMenuItem_Click);
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
            this.VentaoolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.VentaoolStripMenuItem.Text = "venta";
            this.VentaoolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VentaoolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentaoolStripMenuItem_MouseMove);
            // 
            // InsertarVentaToolStripMenuItem1
            // 
            this.InsertarVentaToolStripMenuItem1.Name = "InsertarVentaToolStripMenuItem1";
            this.InsertarVentaToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.InsertarVentaToolStripMenuItem1.Text = "Insertar";
            this.InsertarVentaToolStripMenuItem1.Click += new System.EventHandler(this.insertarToolStripMenuItem1_Click);
            // 
            // VisualizarVentaToolStripMenuItem
            // 
            this.VisualizarVentaToolStripMenuItem.Name = "VisualizarVentaToolStripMenuItem";
            this.VisualizarVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.VisualizarVentaToolStripMenuItem.Text = "Ventas";
            this.VisualizarVentaToolStripMenuItem.Click += new System.EventHandler(this.VisualizarVentaToolStripMenuItem_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(925, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 625);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 622);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::ZapateriaSystem.Properties.Resources.WhatsApp_Image_2020_06_21_at_10_51_41_PM;
            this.pictureBox6.Location = new System.Drawing.Point(8, 512);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(128, 98);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::ZapateriaSystem.Properties.Resources.WhatsApp_Image_2020_06_21_at_10_51_41_PM__2_;
            this.pictureBox5.Location = new System.Drawing.Point(8, 385);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 100);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::ZapateriaSystem.Properties.Resources.WhatsApp_Image_2020_06_21_at_10_51_40_PM;
            this.pictureBox4.Location = new System.Drawing.Point(8, 266);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::ZapateriaSystem.Properties.Resources.pintura;
            this.pictureBox2.Location = new System.Drawing.Point(8, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::ZapateriaSystem.Properties.Resources.animal;
            this.pictureBox3.Location = new System.Drawing.Point(8, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 625);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.IsMdiContainer = true;
            this.MainMenuStrip = menuStrip1;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supreme x Team C";
            this.Load += new System.EventHandler(this.Form1_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VentaoolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actulizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertarVentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem VisualizarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actulizarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actulizarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarProveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actulizarProveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaProveedorToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

