namespace DI_Suf_Ejer5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasar1 = new System.Windows.Forms.Button();
            this.btnTraspasar2 = new System.Windows.Forms.Button();
            this.txb = new System.Windows.Forms.TextBox();
            this.lblElementos = new System.Windows.Forms.Label();
            this.lblIndices = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lista1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lista2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(88, 47);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb1.Size = new System.Drawing.Size(120, 95);
            this.lb1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lb1, "Tabla 1");
            this.lb1.SelectedValueChanged += new System.EventHandler(this.lb1_SelectedValueChanged);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(214, 47);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(120, 95);
            this.lb2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.lb2, "Tabla 2\r\nElementos: 0");
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(340, 73);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.btnAñadir, "Añadir elemento del textbox");
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(421, 73);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.TabStop = false;
            this.btnQuitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btnQuitar, "Quitar elementos seleccionados en la tabla 1");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnTraspasar1
            // 
            this.btnTraspasar1.Location = new System.Drawing.Point(116, 148);
            this.btnTraspasar1.Name = "btnTraspasar1";
            this.btnTraspasar1.Size = new System.Drawing.Size(75, 23);
            this.btnTraspasar1.TabIndex = 1;
            this.btnTraspasar1.Text = "Traspasar 1";
            this.toolTip1.SetToolTip(this.btnTraspasar1, "Pasar elementos de la tabla 1 a la tabla 2");
            this.btnTraspasar1.UseVisualStyleBackColor = true;
            this.btnTraspasar1.Click += new System.EventHandler(this.btnTraspasar);
            // 
            // btnTraspasar2
            // 
            this.btnTraspasar2.Location = new System.Drawing.Point(243, 148);
            this.btnTraspasar2.Name = "btnTraspasar2";
            this.btnTraspasar2.Size = new System.Drawing.Size(75, 23);
            this.btnTraspasar2.TabIndex = 3;
            this.btnTraspasar2.Text = "Traspasar 2";
            this.toolTip1.SetToolTip(this.btnTraspasar2, "Pasar elementos de la tabla 2 a la tabla 1");
            this.btnTraspasar2.UseVisualStyleBackColor = true;
            this.btnTraspasar2.Click += new System.EventHandler(this.btnTraspasar);
            // 
            // txb
            // 
            this.txb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txb.Location = new System.Drawing.Point(340, 47);
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(156, 20);
            this.txb.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txb, "Elemento a añadir");
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(12, 47);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(35, 13);
            this.lblElementos.TabIndex = 7;
            this.lblElementos.Text = "label1";
            this.toolTip1.SetToolTip(this.lblElementos, "Elementos en la tabla 1");
            // 
            // lblIndices
            // 
            this.lblIndices.AutoSize = true;
            this.lblIndices.Location = new System.Drawing.Point(12, 73);
            this.lblIndices.Name = "lblIndices";
            this.lblIndices.Size = new System.Drawing.Size(44, 13);
            this.lblIndices.TabIndex = 8;
            this.lblIndices.Text = "Indices:";
            this.toolTip1.SetToolTip(this.lblIndices, "Elementos seleccionados en la tabla 1");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.lista1ToolStripMenuItem,
            this.lista2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pausarToolStripMenuItem,
            this.continuarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "&General";
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pausarToolStripMenuItem.Text = "&Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // continuarToolStripMenuItem
            // 
            this.continuarToolStripMenuItem.Name = "continuarToolStripMenuItem";
            this.continuarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.continuarToolStripMenuItem.Text = "&Continuar";
            this.continuarToolStripMenuItem.Click += new System.EventHandler(this.continuarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lista1ToolStripMenuItem
            // 
            this.lista1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.traspasarToolStripMenuItem,
            this.quitarToolStripMenuItem});
            this.lista1ToolStripMenuItem.Name = "lista1ToolStripMenuItem";
            this.lista1ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lista1ToolStripMenuItem.Text = "&Lista 1";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.añadirToolStripMenuItem.Text = "&Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // traspasarToolStripMenuItem
            // 
            this.traspasarToolStripMenuItem.Name = "traspasarToolStripMenuItem";
            this.traspasarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.traspasarToolStripMenuItem.Text = "&Traspasar";
            this.traspasarToolStripMenuItem.Click += new System.EventHandler(this.btnTraspasar);
            // 
            // quitarToolStripMenuItem
            // 
            this.quitarToolStripMenuItem.Name = "quitarToolStripMenuItem";
            this.quitarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.quitarToolStripMenuItem.Text = "&Quitar";
            this.quitarToolStripMenuItem.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lista2ToolStripMenuItem
            // 
            this.lista2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traspasarToolStripMenuItem1,
            this.borrarTodoToolStripMenuItem});
            this.lista2ToolStripMenuItem.Name = "lista2ToolStripMenuItem";
            this.lista2ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lista2ToolStripMenuItem.Text = "L&ista 2";
            // 
            // traspasarToolStripMenuItem1
            // 
            this.traspasarToolStripMenuItem1.Name = "traspasarToolStripMenuItem1";
            this.traspasarToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.traspasarToolStripMenuItem1.Text = "&Traspasar";
            this.traspasarToolStripMenuItem1.Click += new System.EventHandler(this.btnTraspasar);
            // 
            // borrarTodoToolStripMenuItem
            // 
            this.borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            this.borrarTodoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.borrarTodoToolStripMenuItem.Text = "&Borrar Todo";
            this.borrarTodoToolStripMenuItem.Click += new System.EventHandler(this.borrarTodoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAñadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 266);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblIndices);
            this.Controls.Add(this.lblElementos);
            this.Controls.Add(this.txb);
            this.Controls.Add(this.btnTraspasar2);
            this.Controls.Add(this.btnTraspasar1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Titulo Formulario";
            this.Enter += new System.EventHandler(this.btnAñadir_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasar1;
        private System.Windows.Forms.Button btnTraspasar2;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Label lblIndices;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lista1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspasarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lista2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspasarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

