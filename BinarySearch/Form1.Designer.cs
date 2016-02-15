namespace BinarySearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.track = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.interval_rnd_left = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.interval_rnd_right = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество элементов генерируемого массива";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 130);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(417, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Найти элемент";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(276, 25);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(100, 20);
            this.key.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Что ищем";
            // 
            // track
            // 
            this.track.Location = new System.Drawing.Point(12, 79);
            this.track.Maximum = 100;
            this.track.Minimum = 1;
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(417, 45);
            this.track.TabIndex = 3;
            this.track.Value = 10;
            this.track.Scroll += new System.EventHandler(this.track_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "10";
            // 
            // interval_rnd_left
            // 
            this.interval_rnd_left.Location = new System.Drawing.Point(74, 25);
            this.interval_rnd_left.Name = "interval_rnd_left";
            this.interval_rnd_left.Size = new System.Drawing.Size(40, 20);
            this.interval_rnd_left.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Интервал рандома";
            // 
            // interval_rnd_right
            // 
            this.interval_rnd_right.Location = new System.Drawing.Point(134, 25);
            this.interval_rnd_right.Name = "interval_rnd_right";
            this.interval_rnd_right.Size = new System.Drawing.Size(40, 20);
            this.interval_rnd_right.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(177, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(52, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "[";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(441, 162);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.track);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval_rnd_right);
            this.Controls.Add(this.interval_rnd_left);
            this.Controls.Add(this.key);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Search";
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar track;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interval_rnd_left;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox interval_rnd_right;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

