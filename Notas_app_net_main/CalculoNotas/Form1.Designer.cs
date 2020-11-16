namespace CalculoNotas
{
    partial class frmcalculonotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculonotas));
            this.menuiconos = new System.Windows.Forms.ToolStrip();
            this.tsbAddStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbEditStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.tsbTrash = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.txtNote3 = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.txtNote4 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiconos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuiconos
            // 
            this.menuiconos.BackColor = System.Drawing.Color.White;
            this.menuiconos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddStudent,
            this.tsbSearchStudent,
            this.tsbEditStudent,
            this.tsbDeleteStudent,
            this.tsbReload,
            this.tsbTrash,
            this.tsbExit});
            this.menuiconos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuiconos.Location = new System.Drawing.Point(0, 0);
            this.menuiconos.Name = "menuiconos";
            this.menuiconos.Padding = new System.Windows.Forms.Padding(0, 10, 1, 10);
            this.menuiconos.Size = new System.Drawing.Size(909, 106);
            this.menuiconos.Stretch = true;
            this.menuiconos.TabIndex = 0;
            this.menuiconos.Text = "toolStrip1";
            // 
            // tsbAddStudent
            // 
            this.tsbAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbAddStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddStudent.Image")));
            this.tsbAddStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddStudent.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tsbAddStudent.Name = "tsbAddStudent";
            this.tsbAddStudent.Size = new System.Drawing.Size(84, 84);
            this.tsbAddStudent.Text = "toolStripButton2";
            this.tsbAddStudent.ToolTipText = "Agregar alumno";
            this.tsbAddStudent.Click += new System.EventHandler(this.tsbAddStudent_Click);
            // 
            // tsbSearchStudent
            // 
            this.tsbSearchStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbSearchStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchStudent.Image")));
            this.tsbSearchStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearchStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchStudent.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tsbSearchStudent.Name = "tsbSearchStudent";
            this.tsbSearchStudent.Size = new System.Drawing.Size(84, 84);
            this.tsbSearchStudent.Text = "toolStripButton3";
            this.tsbSearchStudent.ToolTipText = "Buscar alumno";
            this.tsbSearchStudent.Click += new System.EventHandler(this.tsbSearchStudent_Click);
            // 
            // tsbEditStudent
            // 
            this.tsbEditStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbEditStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditStudent.Enabled = false;
            this.tsbEditStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditStudent.Image")));
            this.tsbEditStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditStudent.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tsbEditStudent.Name = "tsbEditStudent";
            this.tsbEditStudent.Size = new System.Drawing.Size(84, 84);
            this.tsbEditStudent.Text = "toolStripButton5";
            this.tsbEditStudent.ToolTipText = "Editar alumno";
            this.tsbEditStudent.Click += new System.EventHandler(this.tsbEditStudent_Click);
            // 
            // tsbDeleteStudent
            // 
            this.tsbDeleteStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbDeleteStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteStudent.Enabled = false;
            this.tsbDeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteStudent.Image")));
            this.tsbDeleteStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDeleteStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteStudent.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tsbDeleteStudent.Name = "tsbDeleteStudent";
            this.tsbDeleteStudent.Size = new System.Drawing.Size(84, 84);
            this.tsbDeleteStudent.Text = "toolStripButton4";
            this.tsbDeleteStudent.ToolTipText = "Eliminar alumno";
            this.tsbDeleteStudent.Click += new System.EventHandler(this.tsbDeleteStudent_Click);
            // 
            // tsbReload
            // 
            this.tsbReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.Image = ((System.Drawing.Image)(resources.GetObject("tsbReload.Image")));
            this.tsbReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(84, 84);
            this.tsbReload.Text = "<";
            this.tsbReload.ToolTipText = "Actualizar lista";
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // tsbTrash
            // 
            this.tsbTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbTrash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTrash.Image = ((System.Drawing.Image)(resources.GetObject("tsbTrash.Image")));
            this.tsbTrash.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTrash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTrash.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tsbTrash.Name = "tsbTrash";
            this.tsbTrash.Size = new System.Drawing.Size(84, 84);
            this.tsbTrash.Text = "<";
            this.tsbTrash.ToolTipText = "Papelera";
            this.tsbTrash.Click += new System.EventHandler(this.tsbTrash_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Margin = new System.Windows.Forms.Padding(0, 1, 35, 1);
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(84, 84);
            this.tsbExit.Text = "<";
            this.tsbExit.ToolTipText = "Salir";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nota 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nota 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nota 4";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(145, 190);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(636, 29);
            this.txtName.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(636, 29);
            this.txtEmail.TabIndex = 10;
            // 
            // txtNote1
            // 
            this.txtNote1.Location = new System.Drawing.Point(145, 290);
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(49, 29);
            this.txtNote1.TabIndex = 11;
            // 
            // txtNote2
            // 
            this.txtNote2.Location = new System.Drawing.Point(332, 291);
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.Size = new System.Drawing.Size(49, 29);
            this.txtNote2.TabIndex = 12;
            // 
            // txtNote3
            // 
            this.txtNote3.Location = new System.Drawing.Point(524, 291);
            this.txtNote3.Name = "txtNote3";
            this.txtNote3.Size = new System.Drawing.Size(49, 29);
            this.txtNote3.TabIndex = 13;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(682, 144);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(99, 29);
            this.txtCode.TabIndex = 14;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(68, 338);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.Size = new System.Drawing.Size(712, 197);
            this.dgvAlumnos.TabIndex = 15;
            // 
            // txtNote4
            // 
            this.txtNote4.Location = new System.Drawing.Point(731, 291);
            this.txtNote4.Name = "txtNote4";
            this.txtNote4.Size = new System.Drawing.Size(49, 29);
            this.txtNote4.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 106);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmcalculonotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 547);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtNote4);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtNote3);
            this.Controls.Add(this.txtNote2);
            this.Controls.Add(this.txtNote1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuiconos);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmcalculonotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo notas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmcalculonotas_FormClosed);
            this.Load += new System.EventHandler(this.frmcalculonotas_Load);
            this.menuiconos.ResumeLayout(false);
            this.menuiconos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuiconos;
        private System.Windows.Forms.ToolStripButton tsbAddStudent;
        private System.Windows.Forms.ToolStripButton tsbSearchStudent;
        private System.Windows.Forms.ToolStripButton tsbDeleteStudent;
        private System.Windows.Forms.ToolStripButton tsbEditStudent;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNote1;
        private System.Windows.Forms.TextBox txtNote2;
        private System.Windows.Forms.TextBox txtNote3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.TextBox txtNote4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton tsbTrash;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

