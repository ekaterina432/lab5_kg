namespace lab5_kg
{
    partial class form_fraktal
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
            this.Open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.textBoxChangeGeneration = new System.Windows.Forms.TextBox();
            this.labelRandom = new System.Windows.Forms.Label();
            this.labelRandomFrom = new System.Windows.Forms.Label();
            this.labelRandomTo = new System.Windows.Forms.Label();
            this.textBoxRandomFrom = new System.Windows.Forms.TextBox();
            this.textBoxRandomTo = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(42, 47);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(128, 45);
            this.Open.TabIndex = 0;
            this.Open.Text = "Выбери L-систему";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 381);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelGeneration
            // 
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Location = new System.Drawing.Point(428, 27);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(80, 16);
            this.labelGeneration.TabIndex = 2;
            this.labelGeneration.Text = "Поколение";
            // 
            // textBoxChangeGeneration
            // 
            this.textBoxChangeGeneration.Location = new System.Drawing.Point(411, 58);
            this.textBoxChangeGeneration.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxChangeGeneration.Name = "textBoxChangeGeneration";
            this.textBoxChangeGeneration.Size = new System.Drawing.Size(113, 22);
            this.textBoxChangeGeneration.TabIndex = 1;
            this.textBoxChangeGeneration.TextChanged += new System.EventHandler(this.textBoxChangeGeneration_TextChanged);
            this.textBoxChangeGeneration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxChangeGeneration_KeyPress);
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Location = new System.Drawing.Point(249, 27);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(93, 16);
            this.labelRandom.TabIndex = 4;
            this.labelRandom.Text = "Случайность";
            // 
            // labelRandomFrom
            // 
            this.labelRandomFrom.AutoSize = true;
            this.labelRandomFrom.Location = new System.Drawing.Point(224, 61);
            this.labelRandomFrom.Name = "labelRandomFrom";
            this.labelRandomFrom.Size = new System.Drawing.Size(22, 16);
            this.labelRandomFrom.TabIndex = 5;
            this.labelRandomFrom.Text = "от";
            // 
            // labelRandomTo
            // 
            this.labelRandomTo.AutoSize = true;
            this.labelRandomTo.Location = new System.Drawing.Point(305, 61);
            this.labelRandomTo.Name = "labelRandomTo";
            this.labelRandomTo.Size = new System.Drawing.Size(23, 16);
            this.labelRandomTo.TabIndex = 6;
            this.labelRandomTo.Text = "до";
            // 
            // textBoxRandomFrom
            // 
            this.textBoxRandomFrom.Location = new System.Drawing.Point(252, 58);
            this.textBoxRandomFrom.Name = "textBoxRandomFrom";
            this.textBoxRandomFrom.Size = new System.Drawing.Size(35, 22);
            this.textBoxRandomFrom.TabIndex = 7;
            this.textBoxRandomFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRandomFrom_KeyPress);
            // 
            // textBoxRandomTo
            // 
            this.textBoxRandomTo.Location = new System.Drawing.Point(334, 58);
            this.textBoxRandomTo.Name = "textBoxRandomTo";
            this.textBoxRandomTo.Size = new System.Drawing.Size(35, 22);
            this.textBoxRandomTo.TabIndex = 8;
            this.textBoxRandomTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRandomTo_KeyPress);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(555, 47);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(141, 45);
            this.Create.TabIndex = 1;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_fraktal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.textBoxRandomTo);
            this.Controls.Add(this.textBoxRandomFrom);
            this.Controls.Add(this.labelRandomTo);
            this.Controls.Add(this.labelRandomFrom);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.labelGeneration);
            this.Controls.Add(this.textBoxChangeGeneration);
            this.Controls.Add(this.Create);
            this.Name = "form_fraktal";
            this.Text = "Фракталы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGeneration;
        private System.Windows.Forms.TextBox textBoxChangeGeneration;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label labelRandomFrom;
        private System.Windows.Forms.Label labelRandomTo;
        private System.Windows.Forms.TextBox textBoxRandomFrom;
        private System.Windows.Forms.TextBox textBoxRandomTo;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}