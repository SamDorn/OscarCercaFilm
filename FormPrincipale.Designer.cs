namespace OMDB_API
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_box_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.check_box_isPrecise = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_box_title
            // 
            this.txt_box_title.Location = new System.Drawing.Point(12, 41);
            this.txt_box_title.Name = "txt_box_title";
            this.txt_box_title.Size = new System.Drawing.Size(188, 20);
            this.txt_box_title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "OscarCercaFilm";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 67);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(188, 57);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Cerca";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // check_box_isPrecise
            // 
            this.check_box_isPrecise.AutoSize = true;
            this.check_box_isPrecise.Location = new System.Drawing.Point(206, 44);
            this.check_box_isPrecise.Name = "check_box_isPrecise";
            this.check_box_isPrecise.Size = new System.Drawing.Size(89, 17);
            this.check_box_isPrecise.TabIndex = 9;
            this.check_box_isPrecise.Text = "Titolo preciso";
            this.check_box_isPrecise.UseVisualStyleBackColor = true;
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 142);
            this.Controls.Add(this.check_box_isPrecise);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_box_title);
            this.Name = "FormPrincipale";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_box_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox check_box_isPrecise;
    }
}

