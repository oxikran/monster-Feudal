namespace pruebaDB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.import = new System.Windows.Forms.Button();
            this.seefich = new System.Windows.Forms.Button();
            this.findIndex = new System.Windows.Forms.Button();
            this.editBut = new System.Windows.Forms.Button();
            this.verActive = new System.Windows.Forms.Button();
            this.DelActive = new System.Windows.Forms.Button();
            this.firstBut = new System.Windows.Forms.Button();
            this.closeDB = new System.Windows.Forms.Button();
            this.openExist = new System.Windows.Forms.Button();
            this.preBut = new System.Windows.Forms.Button();
            this.ultBut = new System.Windows.Forms.Button();
            this.sigBut = new System.Windows.Forms.Button();
            this.ClaveBut = new System.Windows.Forms.Button();
            this.kriptoBut = new System.Windows.Forms.Button();
            this.unkriptoBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(17, 215);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(157, 80);
            this.import.TabIndex = 1;
            this.import.Text = "Importar";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // seefich
            // 
            this.seefich.Location = new System.Drawing.Point(174, 215);
            this.seefich.Name = "seefich";
            this.seefich.Size = new System.Drawing.Size(157, 80);
            this.seefich.TabIndex = 2;
            this.seefich.Text = "ver fichero";
            this.seefich.UseVisualStyleBackColor = true;
            // 
            // findIndex
            // 
            this.findIndex.Location = new System.Drawing.Point(331, 215);
            this.findIndex.Name = "findIndex";
            this.findIndex.Size = new System.Drawing.Size(157, 80);
            this.findIndex.TabIndex = 3;
            this.findIndex.Text = "buscar un indice";
            this.findIndex.UseVisualStyleBackColor = true;
            // 
            // editBut
            // 
            this.editBut.Location = new System.Drawing.Point(645, 295);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(157, 80);
            this.editBut.TabIndex = 4;
            this.editBut.Text = "editar registro activo";
            this.editBut.UseVisualStyleBackColor = true;
            // 
            // verActive
            // 
            this.verActive.Location = new System.Drawing.Point(645, 215);
            this.verActive.Name = "verActive";
            this.verActive.Size = new System.Drawing.Size(157, 80);
            this.verActive.TabIndex = 5;
            this.verActive.Text = "ver registro activo";
            this.verActive.UseVisualStyleBackColor = true;
            // 
            // DelActive
            // 
            this.DelActive.Location = new System.Drawing.Point(488, 295);
            this.DelActive.Name = "DelActive";
            this.DelActive.Size = new System.Drawing.Size(157, 80);
            this.DelActive.TabIndex = 6;
            this.DelActive.Text = "borrar activo";
            this.DelActive.UseVisualStyleBackColor = true;
            // 
            // firstBut
            // 
            this.firstBut.Location = new System.Drawing.Point(331, 295);
            this.firstBut.Name = "firstBut";
            this.firstBut.Size = new System.Drawing.Size(157, 80);
            this.firstBut.TabIndex = 7;
            this.firstBut.Text = "ir al primer registro";
            this.firstBut.UseVisualStyleBackColor = true;
            // 
            // closeDB
            // 
            this.closeDB.Location = new System.Drawing.Point(17, 295);
            this.closeDB.Name = "closeDB";
            this.closeDB.Size = new System.Drawing.Size(157, 80);
            this.closeDB.TabIndex = 8;
            this.closeDB.Text = "cerrar fichero";
            this.closeDB.UseVisualStyleBackColor = true;
            // 
            // openExist
            // 
            this.openExist.Location = new System.Drawing.Point(174, 295);
            this.openExist.Name = "openExist";
            this.openExist.Size = new System.Drawing.Size(157, 80);
            this.openExist.TabIndex = 9;
            this.openExist.Text = "Abrir base de datos existente";
            this.openExist.UseVisualStyleBackColor = true;
            // 
            // preBut
            // 
            this.preBut.Location = new System.Drawing.Point(174, 375);
            this.preBut.Name = "preBut";
            this.preBut.Size = new System.Drawing.Size(157, 80);
            this.preBut.TabIndex = 10;
            this.preBut.Text = "ir al registro anterior";
            this.preBut.UseVisualStyleBackColor = true;
            // 
            // ultBut
            // 
            this.ultBut.Location = new System.Drawing.Point(331, 375);
            this.ultBut.Name = "ultBut";
            this.ultBut.Size = new System.Drawing.Size(157, 80);
            this.ultBut.TabIndex = 11;
            this.ultBut.Text = "ir al ultimo registro";
            this.ultBut.UseVisualStyleBackColor = true;
            // 
            // sigBut
            // 
            this.sigBut.Location = new System.Drawing.Point(488, 375);
            this.sigBut.Name = "sigBut";
            this.sigBut.Size = new System.Drawing.Size(157, 80);
            this.sigBut.TabIndex = 12;
            this.sigBut.Text = "ir al siguiente registro";
            this.sigBut.UseVisualStyleBackColor = true;
            // 
            // ClaveBut
            // 
            this.ClaveBut.Location = new System.Drawing.Point(488, 215);
            this.ClaveBut.Name = "ClaveBut";
            this.ClaveBut.Size = new System.Drawing.Size(157, 80);
            this.ClaveBut.TabIndex = 13;
            this.ClaveBut.Text = "ver clave";
            this.ClaveBut.UseVisualStyleBackColor = true;
            // 
            // kriptoBut
            // 
            this.kriptoBut.Location = new System.Drawing.Point(17, 375);
            this.kriptoBut.Name = "kriptoBut";
            this.kriptoBut.Size = new System.Drawing.Size(157, 80);
            this.kriptoBut.TabIndex = 14;
            this.kriptoBut.Text = "encripta";
            this.kriptoBut.UseVisualStyleBackColor = true;
            // 
            // unkriptoBut
            // 
            this.unkriptoBut.Location = new System.Drawing.Point(645, 375);
            this.unkriptoBut.Name = "unkriptoBut";
            this.unkriptoBut.Size = new System.Drawing.Size(157, 80);
            this.unkriptoBut.TabIndex = 15;
            this.unkriptoBut.Text = "desencripta";
            this.unkriptoBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 468);
            this.Controls.Add(this.unkriptoBut);
            this.Controls.Add(this.kriptoBut);
            this.Controls.Add(this.ClaveBut);
            this.Controls.Add(this.sigBut);
            this.Controls.Add(this.ultBut);
            this.Controls.Add(this.preBut);
            this.Controls.Add(this.openExist);
            this.Controls.Add(this.closeDB);
            this.Controls.Add(this.firstBut);
            this.Controls.Add(this.DelActive);
            this.Controls.Add(this.verActive);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.findIndex);
            this.Controls.Add(this.seefich);
            this.Controls.Add(this.import);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button seefich;
        private System.Windows.Forms.Button findIndex;
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.Button verActive;
        private System.Windows.Forms.Button DelActive;
        private System.Windows.Forms.Button firstBut;
        private System.Windows.Forms.Button closeDB;
        private System.Windows.Forms.Button openExist;
        private System.Windows.Forms.Button preBut;
        private System.Windows.Forms.Button ultBut;
        private System.Windows.Forms.Button sigBut;
        private System.Windows.Forms.Button ClaveBut;
        private System.Windows.Forms.Button kriptoBut;
        private System.Windows.Forms.Button unkriptoBut;
    }
}

