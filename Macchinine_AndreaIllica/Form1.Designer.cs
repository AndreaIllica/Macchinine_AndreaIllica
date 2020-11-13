using System.Windows.Forms;

namespace Macchinine_AndreaIllica
{
    partial class Form1
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
            this.picMacchina1 = new System.Windows.Forms.PictureBox();
            this.picMacchina2 = new System.Windows.Forms.PictureBox();
            this.picTrenino = new System.Windows.Forms.PictureBox();
            this.carMoveWorker1 = new System.ComponentModel.BackgroundWorker();
            this.carMoveWorker2 = new System.ComponentModel.BackgroundWorker();
            this.carMoveWorker3 = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtGiri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrenino = new System.Windows.Forms.CheckBox();
            this.lblGiri1 = new System.Windows.Forms.Label();
            this.lblGiri2 = new System.Windows.Forms.Label();
            this.lblGiri3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.carMoveDefault = new System.ComponentModel.BackgroundWorker();
            this.picStrada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMacchina1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMacchina2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrenino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStrada)).BeginInit();
            this.SuspendLayout();
            // 
            // picMacchina1
            // 
            this.picMacchina1.BackColor = System.Drawing.Color.Transparent;
            this.picMacchina1.Location = new System.Drawing.Point(22, 12);
            this.picMacchina1.Name = "picMacchina1";
            this.picMacchina1.Size = new System.Drawing.Size(99, 61);
            this.picMacchina1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMacchina1.TabIndex = 1;
            this.picMacchina1.TabStop = false;
            // 
            // picMacchina2
            // 
            this.picMacchina2.BackColor = System.Drawing.Color.Transparent;
            this.picMacchina2.Location = new System.Drawing.Point(22, 141);
            this.picMacchina2.Name = "picMacchina2";
            this.picMacchina2.Size = new System.Drawing.Size(99, 63);
            this.picMacchina2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMacchina2.TabIndex = 2;
            this.picMacchina2.TabStop = false;
            // 
            // picTrenino
            // 
            this.picTrenino.BackColor = System.Drawing.Color.Transparent;
            this.picTrenino.Location = new System.Drawing.Point(22, 260);
            this.picTrenino.Name = "picTrenino";
            this.picTrenino.Size = new System.Drawing.Size(201, 96);
            this.picTrenino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrenino.TabIndex = 3;
            this.picTrenino.TabStop = false;
            // 
            // carMoveWorker1
            // 
            this.carMoveWorker1.WorkerReportsProgress = true;
            this.carMoveWorker1.WorkerSupportsCancellation = true;
            this.carMoveWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.carMoveDefault_DoWork);
            this.carMoveWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.carMoveDefault_ProgressChanged);
            // 
            // carMoveWorker2
            // 
            this.carMoveWorker2.WorkerReportsProgress = true;
            this.carMoveWorker2.WorkerSupportsCancellation = true;
            this.carMoveWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.carMoveDefault_DoWork);
            this.carMoveWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.carMoveDefault_ProgressChanged);
            // 
            // carMoveWorker3
            // 
            this.carMoveWorker3.WorkerReportsProgress = true;
            this.carMoveWorker3.WorkerSupportsCancellation = true;
            this.carMoveWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.carMoveDefault_DoWork);
            this.carMoveWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.carMoveDefault_ProgressChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(633, 390);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 33);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(746, 390);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 33);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtGiri
            // 
            this.txtGiri.Location = new System.Drawing.Point(47, 397);
            this.txtGiri.Name = "txtGiri";
            this.txtGiri.Size = new System.Drawing.Size(31, 20);
            this.txtGiri.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giri";
            // 
            // cbTrenino
            // 
            this.cbTrenino.AutoSize = true;
            this.cbTrenino.Location = new System.Drawing.Point(189, 399);
            this.cbTrenino.Name = "cbTrenino";
            this.cbTrenino.Size = new System.Drawing.Size(99, 17);
            this.cbTrenino.TabIndex = 9;
            this.cbTrenino.Text = "Trenino thomas";
            this.cbTrenino.UseVisualStyleBackColor = true;
            this.cbTrenino.CheckedChanged += new System.EventHandler(this.cbTrenino_CheckedChanged);
            // 
            // lblGiri1
            // 
            this.lblGiri1.BackColor = System.Drawing.Color.Transparent;
            this.lblGiri1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiri1.ForeColor = System.Drawing.Color.Black;
            this.lblGiri1.Location = new System.Drawing.Point(746, 9);
            this.lblGiri1.Name = "lblGiri1";
            this.lblGiri1.Size = new System.Drawing.Size(92, 24);
            this.lblGiri1.TabIndex = 10;
            this.lblGiri1.Text = "Giri:";
            // 
            // lblGiri2
            // 
            this.lblGiri2.BackColor = System.Drawing.Color.Transparent;
            this.lblGiri2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiri2.Location = new System.Drawing.Point(746, 119);
            this.lblGiri2.Name = "lblGiri2";
            this.lblGiri2.Size = new System.Drawing.Size(92, 24);
            this.lblGiri2.TabIndex = 11;
            this.lblGiri2.Text = "Giri:";
            // 
            // lblGiri3
            // 
            this.lblGiri3.BackColor = System.Drawing.Color.Transparent;
            this.lblGiri3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiri3.Location = new System.Drawing.Point(746, 260);
            this.lblGiri3.Name = "lblGiri3";
            this.lblGiri3.Size = new System.Drawing.Size(92, 24);
            this.lblGiri3.TabIndex = 12;
            this.lblGiri3.Text = "Giri:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(519, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 33);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // carMoveDefault
            // 
            this.carMoveDefault.WorkerReportsProgress = true;
            this.carMoveDefault.WorkerSupportsCancellation = true;
            this.carMoveDefault.DoWork += new System.ComponentModel.DoWorkEventHandler(this.carMoveDefault_DoWork);
            this.carMoveDefault.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.carMoveDefault_ProgressChanged);
            // 
            // picStrada
            // 
            this.picStrada.Image = global::Macchinine_AndreaIllica.Properties.Resources.StradaBella;
            this.picStrada.Location = new System.Drawing.Point(0, -1);
            this.picStrada.Name = "picStrada";
            this.picStrada.Size = new System.Drawing.Size(852, 377);
            this.picStrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStrada.TabIndex = 14;
            this.picStrada.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 437);
            this.Controls.Add(this.lblGiri1);
            this.Controls.Add(this.lblGiri2);
            this.Controls.Add(this.lblGiri3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbTrenino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiri);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picTrenino);
            this.Controls.Add(this.picMacchina2);
            this.Controls.Add(this.picMacchina1);
            this.Controls.Add(this.picStrada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picMacchina1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMacchina2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrenino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMacchina1;
        private System.Windows.Forms.PictureBox picMacchina2;
        private System.Windows.Forms.PictureBox picTrenino;
        private System.ComponentModel.BackgroundWorker carMoveWorker1;
        private System.ComponentModel.BackgroundWorker carMoveWorker2;
        private System.ComponentModel.BackgroundWorker carMoveWorker3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtGiri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTrenino;
        private System.Windows.Forms.Label lblGiri1;
        private System.Windows.Forms.Label lblGiri2;
        private System.Windows.Forms.Label lblGiri3;
        private System.Windows.Forms.Button btnReset;
        private System.ComponentModel.BackgroundWorker carMoveDefault;
        private PictureBox picStrada;
    }
}

