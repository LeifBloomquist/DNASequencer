namespace DNASequencer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bGo = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.lPercentage = new System.Windows.Forms.Label();
            this.lNote = new System.Windows.Forms.Label();
            this.lAllele = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bGo
            // 
            this.bGo.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGo.Location = new System.Drawing.Point(22, 18);
            this.bGo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(209, 78);
            this.bGo.TabIndex = 0;
            this.bGo.Text = "Load";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(242, 18);
            this.bStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(209, 78);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // lStatus
            // 
            this.lStatus.BackColor = System.Drawing.Color.Black;
            this.lStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lStatus.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.ForeColor = System.Drawing.Color.White;
            this.lStatus.Location = new System.Drawing.Point(24, 127);
            this.lStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(206, 34);
            this.lStatus.TabIndex = 2;
            this.lStatus.Text = "Chromosome 2";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bStop
            // 
            this.bStop.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStop.Location = new System.Drawing.Point(462, 18);
            this.bStop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(209, 78);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            // 
            // lPercentage
            // 
            this.lPercentage.BackColor = System.Drawing.Color.Black;
            this.lPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lPercentage.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPercentage.ForeColor = System.Drawing.Color.White;
            this.lPercentage.Location = new System.Drawing.Point(522, 127);
            this.lPercentage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lPercentage.Name = "lPercentage";
            this.lPercentage.Size = new System.Drawing.Size(96, 34);
            this.lPercentage.TabIndex = 4;
            this.lPercentage.Text = "--";
            this.lPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lNote
            // 
            this.lNote.BackColor = System.Drawing.Color.Black;
            this.lNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNote.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNote.ForeColor = System.Drawing.Color.White;
            this.lNote.Location = new System.Drawing.Point(242, 127);
            this.lNote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lNote.Name = "lNote";
            this.lNote.Size = new System.Drawing.Size(150, 34);
            this.lNote.TabIndex = 5;
            this.lNote.Text = "--";
            this.lNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lAllele
            // 
            this.lAllele.BackColor = System.Drawing.Color.Black;
            this.lAllele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lAllele.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAllele.ForeColor = System.Drawing.Color.White;
            this.lAllele.Location = new System.Drawing.Point(404, 127);
            this.lAllele.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lAllele.Name = "lAllele";
            this.lAllele.Size = new System.Drawing.Size(47, 34);
            this.lAllele.TabIndex = 6;
            this.lAllele.Text = "--";
            this.lAllele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 178);
            this.Controls.Add(this.lAllele);
            this.Controls.Add(this.lNote);
            this.Controls.Add(this.lPercentage);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bGo);
            this.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "DNA Sequencer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        internal System.Windows.Forms.Button bGo;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label lPercentage;
        private System.Windows.Forms.Label lNote;
        private System.Windows.Forms.Label lAllele;

    }
}

