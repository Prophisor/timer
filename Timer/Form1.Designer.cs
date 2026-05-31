
namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tittel = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.subbutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Tittel
            // 
            this.Tittel.AutoSize = true;
            this.Tittel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittel.Location = new System.Drawing.Point(16, 23);
            this.Tittel.Name = "Tittel";
            this.Tittel.Size = new System.Drawing.Size(353, 46);
            this.Tittel.TabIndex = 0;
            this.Tittel.Text = "Timer Count Down";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.Location = new System.Drawing.Point(92, 135);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(174, 36);
            this.Counter.TabIndex = 0;
            this.Counter.Text = "60 Seconds";
            // 
            // Resetbutton
            // 
            this.Resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbutton.Location = new System.Drawing.Point(85, 217);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(89, 39);
            this.Resetbutton.TabIndex = 1;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbutton.Location = new System.Drawing.Point(180, 217);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(89, 39);
            this.stopbutton.TabIndex = 1;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(85, 299);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(89, 39);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "+";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // subbutton
            // 
            this.subbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subbutton.Location = new System.Drawing.Point(180, 299);
            this.subbutton.Name = "subbutton";
            this.subbutton.Size = new System.Drawing.Size(89, 39);
            this.subbutton.TabIndex = 1;
            this.subbutton.Text = "-";
            this.subbutton.UseVisualStyleBackColor = true;
            this.subbutton.Click += new System.EventHandler(this.subbutton_Click);
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(85, 257);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(184, 39);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(401, 357);
            this.Controls.Add(this.subbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.Tittel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Timer Count Down";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tittel;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button subbutton;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Timer timer1;
    }
}

