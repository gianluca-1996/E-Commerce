namespace AlmacenGranate
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
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxCarrito = new System.Windows.Forms.GroupBox();
            this.labelListaProductos = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelCostoEnvio = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxCostoEnvio = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTipoEntrega = new System.Windows.Forms.Label();
            this.radioButtonEnvio = new System.Windows.Forms.RadioButton();
            this.radioButtonRetiroLocal = new System.Windows.Forms.RadioButton();
            this.groupBoxDatosCliente = new System.Windows.Forms.GroupBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelCuil = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelDirección = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxCuil = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.groupBoxCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBoxDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabPagePrincipal);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(816, 488);
            this.Menu.TabIndex = 0;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.BackColor = System.Drawing.Color.White;
            this.tabPagePrincipal.Controls.Add(this.buttonConfirmar);
            this.tabPagePrincipal.Controls.Add(this.groupBoxDatosCliente);
            this.tabPagePrincipal.Controls.Add(this.groupBoxCarrito);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 26);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(808, 458);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxCarrito
            // 
            this.groupBoxCarrito.BackColor = System.Drawing.Color.White;
            this.groupBoxCarrito.Controls.Add(this.radioButtonRetiroLocal);
            this.groupBoxCarrito.Controls.Add(this.radioButtonEnvio);
            this.groupBoxCarrito.Controls.Add(this.labelTipoEntrega);
            this.groupBoxCarrito.Controls.Add(this.textBoxTotal);
            this.groupBoxCarrito.Controls.Add(this.textBoxCostoEnvio);
            this.groupBoxCarrito.Controls.Add(this.textBoxSubtotal);
            this.groupBoxCarrito.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxCarrito.Controls.Add(this.listBoxProductos);
            this.groupBoxCarrito.Controls.Add(this.labelTotal);
            this.groupBoxCarrito.Controls.Add(this.labelCostoEnvio);
            this.groupBoxCarrito.Controls.Add(this.labelSubtotal);
            this.groupBoxCarrito.Controls.Add(this.labelCantidad);
            this.groupBoxCarrito.Controls.Add(this.labelListaProductos);
            this.groupBoxCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCarrito.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCarrito.Location = new System.Drawing.Point(8, 27);
            this.groupBoxCarrito.Name = "groupBoxCarrito";
            this.groupBoxCarrito.Size = new System.Drawing.Size(408, 269);
            this.groupBoxCarrito.TabIndex = 0;
            this.groupBoxCarrito.TabStop = false;
            this.groupBoxCarrito.Text = "Detalle carrito";
            // 
            // labelListaProductos
            // 
            this.labelListaProductos.AutoSize = true;
            this.labelListaProductos.ForeColor = System.Drawing.Color.Black;
            this.labelListaProductos.Location = new System.Drawing.Point(6, 30);
            this.labelListaProductos.Name = "labelListaProductos";
            this.labelListaProductos.Size = new System.Drawing.Size(103, 16);
            this.labelListaProductos.TabIndex = 0;
            this.labelListaProductos.Text = "Lista Productos:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.ForeColor = System.Drawing.Color.Black;
            this.labelCantidad.Location = new System.Drawing.Point(44, 69);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(65, 16);
            this.labelCantidad.TabIndex = 1;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.ForeColor = System.Drawing.Color.Black;
            this.labelSubtotal.Location = new System.Drawing.Point(49, 104);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(60, 16);
            this.labelSubtotal.TabIndex = 2;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // labelCostoEnvio
            // 
            this.labelCostoEnvio.AutoSize = true;
            this.labelCostoEnvio.ForeColor = System.Drawing.Color.Black;
            this.labelCostoEnvio.Location = new System.Drawing.Point(26, 141);
            this.labelCostoEnvio.Name = "labelCostoEnvio";
            this.labelCostoEnvio.Size = new System.Drawing.Size(83, 16);
            this.labelCostoEnvio.TabIndex = 3;
            this.labelCostoEnvio.Text = "Costo Envío:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(6, 233);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(74, 20);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "TOTAL :";
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.ItemHeight = 16;
            this.listBoxProductos.Location = new System.Drawing.Point(127, 30);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(174, 20);
            this.listBoxProductos.TabIndex = 5;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(127, 69);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(41, 22);
            this.numericUpDownCantidad.TabIndex = 6;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Location = new System.Drawing.Point(127, 101);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(84, 22);
            this.textBoxSubtotal.TabIndex = 1;
            // 
            // textBoxCostoEnvio
            // 
            this.textBoxCostoEnvio.Location = new System.Drawing.Point(127, 138);
            this.textBoxCostoEnvio.Name = "textBoxCostoEnvio";
            this.textBoxCostoEnvio.ReadOnly = true;
            this.textBoxCostoEnvio.Size = new System.Drawing.Size(100, 22);
            this.textBoxCostoEnvio.TabIndex = 7;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(127, 233);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotal.TabIndex = 8;
            // 
            // labelTipoEntrega
            // 
            this.labelTipoEntrega.AutoSize = true;
            this.labelTipoEntrega.ForeColor = System.Drawing.Color.Black;
            this.labelTipoEntrega.Location = new System.Drawing.Point(20, 182);
            this.labelTipoEntrega.Name = "labelTipoEntrega";
            this.labelTipoEntrega.Size = new System.Drawing.Size(89, 16);
            this.labelTipoEntrega.TabIndex = 9;
            this.labelTipoEntrega.Text = "Tipo Entrega:";
            // 
            // radioButtonEnvio
            // 
            this.radioButtonEnvio.AutoSize = true;
            this.radioButtonEnvio.ForeColor = System.Drawing.Color.Black;
            this.radioButtonEnvio.Location = new System.Drawing.Point(127, 180);
            this.radioButtonEnvio.Name = "radioButtonEnvio";
            this.radioButtonEnvio.Size = new System.Drawing.Size(60, 20);
            this.radioButtonEnvio.TabIndex = 10;
            this.radioButtonEnvio.TabStop = true;
            this.radioButtonEnvio.Text = "Envío";
            this.radioButtonEnvio.UseVisualStyleBackColor = true;
            // 
            // radioButtonRetiroLocal
            // 
            this.radioButtonRetiroLocal.AutoSize = true;
            this.radioButtonRetiroLocal.ForeColor = System.Drawing.Color.Black;
            this.radioButtonRetiroLocal.Location = new System.Drawing.Point(193, 182);
            this.radioButtonRetiroLocal.Name = "radioButtonRetiroLocal";
            this.radioButtonRetiroLocal.Size = new System.Drawing.Size(98, 20);
            this.radioButtonRetiroLocal.TabIndex = 11;
            this.radioButtonRetiroLocal.TabStop = true;
            this.radioButtonRetiroLocal.Text = "Retiro Local";
            this.radioButtonRetiroLocal.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatosCliente
            // 
            this.groupBoxDatosCliente.Controls.Add(this.textBox1);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxCuil);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxDNI);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxApellido);
            this.groupBoxDatosCliente.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosCliente.Controls.Add(this.labelDirección);
            this.groupBoxDatosCliente.Controls.Add(this.labelTel);
            this.groupBoxDatosCliente.Controls.Add(this.labelCuil);
            this.groupBoxDatosCliente.Controls.Add(this.labelDni);
            this.groupBoxDatosCliente.Controls.Add(this.labelApellido);
            this.groupBoxDatosCliente.Controls.Add(this.labelNombre);
            this.groupBoxDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosCliente.Location = new System.Drawing.Point(422, 27);
            this.groupBoxDatosCliente.Name = "groupBoxDatosCliente";
            this.groupBoxDatosCliente.Size = new System.Drawing.Size(362, 269);
            this.groupBoxDatosCliente.TabIndex = 12;
            this.groupBoxDatosCliente.TabStop = false;
            this.groupBoxDatosCliente.Text = "Datos del Cliente";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 30);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(60, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(6, 69);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(61, 16);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(32, 104);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(34, 16);
            this.labelDni.TabIndex = 2;
            this.labelDni.Text = "DNI:";
            // 
            // labelCuil
            // 
            this.labelCuil.AutoSize = true;
            this.labelCuil.Location = new System.Drawing.Point(26, 141);
            this.labelCuil.Name = "labelCuil";
            this.labelCuil.Size = new System.Drawing.Size(40, 16);
            this.labelCuil.TabIndex = 3;
            this.labelCuil.Text = "CUIL:";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(2, 182);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(65, 16);
            this.labelTel.TabIndex = 4;
            this.labelTel.Text = "Teléfono:";
            // 
            // labelDirección
            // 
            this.labelDirección.AutoSize = true;
            this.labelDirección.Location = new System.Drawing.Point(-2, 218);
            this.labelDirección.Name = "labelDirección";
            this.labelDirección.Size = new System.Drawing.Size(68, 16);
            this.labelDirección.TabIndex = 5;
            this.labelDirección.Text = "Dirección:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(72, 24);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(218, 22);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(72, 66);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(218, 22);
            this.textBoxApellido.TabIndex = 7;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(73, 101);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 22);
            this.textBoxDNI.TabIndex = 8;
            // 
            // textBoxCuil
            // 
            this.textBoxCuil.Location = new System.Drawing.Point(73, 138);
            this.textBoxCuil.Name = "textBoxCuil";
            this.textBoxCuil.Size = new System.Drawing.Size(100, 22);
            this.textBoxCuil.TabIndex = 9;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(73, 179);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelefono.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 22);
            this.textBox1.TabIndex = 11;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(262, 336);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(240, 43);
            this.buttonConfirmar.TabIndex = 13;
            this.buttonConfirmar.Text = "Confirmar Venta";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Sistema Almacen Granate";
            this.Menu.ResumeLayout(false);
            this.tabPagePrincipal.ResumeLayout(false);
            this.groupBoxCarrito.ResumeLayout(false);
            this.groupBoxCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBoxDatosCliente.ResumeLayout(false);
            this.groupBoxDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPagePrincipal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxCarrito;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCostoEnvio;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelListaProductos;
        private System.Windows.Forms.RadioButton radioButtonRetiroLocal;
        private System.Windows.Forms.RadioButton radioButtonEnvio;
        private System.Windows.Forms.Label labelTipoEntrega;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxCostoEnvio;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.GroupBox groupBoxDatosCliente;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxCuil;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDirección;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelCuil;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
    }
}

