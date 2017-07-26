namespace Paramedic.Mapas.WebBrowser
{
    partial class Form1
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
            this.browser = new System.Windows.Forms.WebBrowser();
            this.btnCleanMap = new System.Windows.Forms.Button();
            this.btnEditPolygon = new System.Windows.Forms.Button();
            this.btnSavePolygon = new System.Windows.Forms.Button();
            this.btnNewPolygon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(1, 1);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1073, 534);
            this.browser.TabIndex = 0;
            // 
            // btnCleanMap
            // 
            this.btnCleanMap.Location = new System.Drawing.Point(12, 550);
            this.btnCleanMap.Name = "btnCleanMap";
            this.btnCleanMap.Size = new System.Drawing.Size(115, 23);
            this.btnCleanMap.TabIndex = 4;
            this.btnCleanMap.Text = "Limpiar mapa";
            this.btnCleanMap.Click += new System.EventHandler(this.btnCleanMap_Click);
            // 
            // btnEditPolygon
            // 
            this.btnEditPolygon.Location = new System.Drawing.Point(267, 550);
            this.btnEditPolygon.Name = "btnEditPolygon";
            this.btnEditPolygon.Size = new System.Drawing.Size(118, 23);
            this.btnEditPolygon.TabIndex = 2;
            this.btnEditPolygon.Text = "Editar Poligono";
            this.btnEditPolygon.UseVisualStyleBackColor = true;
            this.btnEditPolygon.Click += new System.EventHandler(this.btnEditPolygon_Click);
            // 
            // btnSavePolygon
            // 
            this.btnSavePolygon.Location = new System.Drawing.Point(133, 550);
            this.btnSavePolygon.Name = "btnSavePolygon";
            this.btnSavePolygon.Size = new System.Drawing.Size(128, 23);
            this.btnSavePolygon.TabIndex = 3;
            this.btnSavePolygon.Text = "Guardar poligono";
            this.btnSavePolygon.UseVisualStyleBackColor = true;
            this.btnSavePolygon.Click += new System.EventHandler(this.btnSavePolygon_Click);
            // 
            // btnNewPolygon
            // 
            this.btnNewPolygon.Location = new System.Drawing.Point(391, 550);
            this.btnNewPolygon.Name = "btnNewPolygon";
            this.btnNewPolygon.Size = new System.Drawing.Size(118, 23);
            this.btnNewPolygon.TabIndex = 5;
            this.btnNewPolygon.Text = "Nuevo poligono";
            this.btnNewPolygon.UseVisualStyleBackColor = true;
            this.btnNewPolygon.Click += new System.EventHandler(this.btnNewPolygon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 585);
            this.Controls.Add(this.btnNewPolygon);
            this.Controls.Add(this.btnSavePolygon);
            this.Controls.Add(this.btnEditPolygon);
            this.Controls.Add(this.btnCleanMap);
            this.Controls.Add(this.browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button btnCleanMap;
        private System.Windows.Forms.Button btnEditPolygon;
        private System.Windows.Forms.Button btnSavePolygon;
        private System.Windows.Forms.Button btnNewPolygon;
    }
}

