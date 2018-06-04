namespace API_merca
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLeerCategorias = new System.Windows.Forms.Button();
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.btnCategoriesToXml = new System.Windows.Forms.Button();
            this.btnProductsToXml = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtUrlApiBase = new System.Windows.Forms.TextBox();
            this.btnGuardarUrlApiBase = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContadorProductosSinRepes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContadorCategorias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContadorProductos = new System.Windows.Forms.Label();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeerCategorias
            // 
            this.btnLeerCategorias.Location = new System.Drawing.Point(411, 12);
            this.btnLeerCategorias.Name = "btnLeerCategorias";
            this.btnLeerCategorias.Size = new System.Drawing.Size(128, 79);
            this.btnLeerCategorias.TabIndex = 3;
            this.btnLeerCategorias.Text = "Read \'categories.json\', download categories and products";
            this.btnLeerCategorias.UseVisualStyleBackColor = true;
            this.btnLeerCategorias.Click += new System.EventHandler(this.btnLeerCategorias_Click);
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.Location = new System.Drawing.Point(12, 67);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.Size = new System.Drawing.Size(393, 381);
            this.listBoxCategorias.TabIndex = 4;
            this.listBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.listBoxCategorias_SelectedIndexChanged);
            // 
            // btnCategoriesToXml
            // 
            this.btnCategoriesToXml.Location = new System.Drawing.Point(411, 97);
            this.btnCategoriesToXml.Name = "btnCategoriesToXml";
            this.btnCategoriesToXml.Size = new System.Drawing.Size(128, 23);
            this.btnCategoriesToXml.TabIndex = 15;
            this.btnCategoriesToXml.Text = "Categorias to XML";
            this.btnCategoriesToXml.UseVisualStyleBackColor = true;
            this.btnCategoriesToXml.Click += new System.EventHandler(this.btnCategoriesToXml_Click);
            // 
            // btnProductsToXml
            // 
            this.btnProductsToXml.Location = new System.Drawing.Point(411, 126);
            this.btnProductsToXml.Name = "btnProductsToXml";
            this.btnProductsToXml.Size = new System.Drawing.Size(128, 23);
            this.btnProductsToXml.TabIndex = 16;
            this.btnProductsToXml.Text = "Products to XML";
            this.btnProductsToXml.UseVisualStyleBackColor = true;
            this.btnProductsToXml.Click += new System.EventHandler(this.btnProductsToXml_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDelay);
            this.groupBox2.Controls.Add(this.txtUrlApiBase);
            this.groupBox2.Controls.Add(this.btnGuardarUrlApiBase);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 47);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "URL API Base + Delay (ms)";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(264, 19);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(58, 20);
            this.txtDelay.TabIndex = 6;
            // 
            // txtUrlApiBase
            // 
            this.txtUrlApiBase.Location = new System.Drawing.Point(6, 19);
            this.txtUrlApiBase.Name = "txtUrlApiBase";
            this.txtUrlApiBase.Size = new System.Drawing.Size(252, 20);
            this.txtUrlApiBase.TabIndex = 5;
            // 
            // btnGuardarUrlApiBase
            // 
            this.btnGuardarUrlApiBase.Location = new System.Drawing.Point(332, 19);
            this.btnGuardarUrlApiBase.Name = "btnGuardarUrlApiBase";
            this.btnGuardarUrlApiBase.Size = new System.Drawing.Size(55, 21);
            this.btnGuardarUrlApiBase.TabIndex = 4;
            this.btnGuardarUrlApiBase.Text = "Save";
            this.btnGuardarUrlApiBase.UseVisualStyleBackColor = true;
            this.btnGuardarUrlApiBase.Click += new System.EventHandler(this.btnGuardarUrlApiBase_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblContadorProductosSinRepes);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblContadorCategorias);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblContadorProductos);
            this.groupBox3.Location = new System.Drawing.Point(411, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 128);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Num distinct products:";
            // 
            // lblContadorProductosSinRepes
            // 
            this.lblContadorProductosSinRepes.AutoSize = true;
            this.lblContadorProductosSinRepes.Location = new System.Drawing.Point(6, 103);
            this.lblContadorProductosSinRepes.Name = "lblContadorProductosSinRepes";
            this.lblContadorProductosSinRepes.Size = new System.Drawing.Size(166, 13);
            this.lblContadorProductosSinRepes.TabIndex = 19;
            this.lblContadorProductosSinRepes.Text = "<lblContadorProductosSinRepes>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Num cats. and subcats:";
            // 
            // lblContadorCategorias
            // 
            this.lblContadorCategorias.AutoSize = true;
            this.lblContadorCategorias.Location = new System.Drawing.Point(6, 29);
            this.lblContadorCategorias.Name = "lblContadorCategorias";
            this.lblContadorCategorias.Size = new System.Drawing.Size(122, 13);
            this.lblContadorCategorias.TabIndex = 17;
            this.lblContadorCategorias.Text = "<lblContadorCategorias>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nun products:";
            // 
            // lblContadorProductos
            // 
            this.lblContadorProductos.AutoSize = true;
            this.lblContadorProductos.Location = new System.Drawing.Point(6, 65);
            this.lblContadorProductos.Name = "lblContadorProductos";
            this.lblContadorProductos.Size = new System.Drawing.Size(120, 13);
            this.lblContadorProductos.TabIndex = 15;
            this.lblContadorProductos.Text = "<lblContadorProductos>";
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(411, 289);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(128, 117);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 19;
            this.pictureBoxProduct.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProductsToXml);
            this.Controls.Add(this.btnCategoriesToXml);
            this.Controls.Add(this.listBoxCategorias);
            this.Controls.Add(this.btnLeerCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MERCA API";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLeerCategorias;
        private System.Windows.Forms.ListBox listBoxCategorias;
        private System.Windows.Forms.Button btnCategoriesToXml;
        private System.Windows.Forms.Button btnProductsToXml;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrlApiBase;
        private System.Windows.Forms.Button btnGuardarUrlApiBase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContadorProductosSinRepes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblContadorCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContadorProductos;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
    }
}

