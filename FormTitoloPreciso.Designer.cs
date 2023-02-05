namespace OMDB_API
{
    partial class FormTitoloPreciso
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
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_director = new System.Windows.Forms.Label();
            this.label_writer = new System.Windows.Forms.Label();
            this.label_actors = new System.Windows.Forms.Label();
            this.label_awards = new System.Windows.Forms.Label();
            this.label_rating = new System.Windows.Forms.Label();
            this.label1_genre = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_box
            // 
            this.picture_box.Location = new System.Drawing.Point(12, 12);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(345, 377);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 0;
            this.picture_box.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_title.Location = new System.Drawing.Point(363, 25);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(96, 31);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Titolo: ";
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_director.Location = new System.Drawing.Point(363, 118);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(134, 31);
            this.label_director.TabIndex = 2;
            this.label_director.Text = "Direttore: ";
            // 
            // label_writer
            // 
            this.label_writer.AutoSize = true;
            this.label_writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_writer.Location = new System.Drawing.Point(363, 149);
            this.label_writer.Name = "label_writer";
            this.label_writer.Size = new System.Drawing.Size(131, 31);
            this.label_writer.TabIndex = 3;
            this.label_writer.Text = "Scrittore: ";
            // 
            // label_actors
            // 
            this.label_actors.AutoSize = true;
            this.label_actors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_actors.Location = new System.Drawing.Point(363, 180);
            this.label_actors.Name = "label_actors";
            this.label_actors.Size = new System.Drawing.Size(93, 31);
            this.label_actors.TabIndex = 4;
            this.label_actors.Text = "Attori: ";
            // 
            // label_awards
            // 
            this.label_awards.AutoSize = true;
            this.label_awards.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_awards.Location = new System.Drawing.Point(363, 211);
            this.label_awards.Name = "label_awards";
            this.label_awards.Size = new System.Drawing.Size(214, 31);
            this.label_awards.TabIndex = 5;
            this.label_awards.Text = "Riconoscimenti: ";
            // 
            // label_rating
            // 
            this.label_rating.AutoSize = true;
            this.label_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_rating.Location = new System.Drawing.Point(363, 242);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(285, 31);
            this.label_rating.TabIndex = 6;
            this.label_rating.Text = "Punteggio metascore: ";
            // 
            // label1_genre
            // 
            this.label1_genre.AutoSize = true;
            this.label1_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1_genre.Location = new System.Drawing.Point(363, 87);
            this.label1_genre.Name = "label1_genre";
            this.label1_genre.Size = new System.Drawing.Size(119, 31);
            this.label1_genre.TabIndex = 10;
            this.label1_genre.Text = "Genere: ";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_year.Location = new System.Drawing.Point(363, 56);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(92, 31);
            this.label_year.TabIndex = 11;
            this.label_year.Text = "Anno: ";
            // 
            // FormTitoloPreciso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 413);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label1_genre);
            this.Controls.Add(this.label_rating);
            this.Controls.Add(this.label_awards);
            this.Controls.Add(this.label_actors);
            this.Controls.Add(this.label_writer);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.picture_box);
            this.Name = "FormTitoloPreciso";
            this.Text = "FormTitoloPreciso";
            this.Load += new System.EventHandler(this.FormTitoloPreciso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_director;
        private System.Windows.Forms.Label label_writer;
        private System.Windows.Forms.Label label_actors;
        private System.Windows.Forms.Label label_awards;
        private System.Windows.Forms.Label label_rating;
        private System.Windows.Forms.Label label1_genre;
        private System.Windows.Forms.Label label_year;
    }
}