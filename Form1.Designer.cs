namespace Consola_Bis_Moderna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_preuba = new Button();
            SuspendLayout();
            // 
            // btn_preuba
            // 
            btn_preuba.Location = new Point(317, 316);
            btn_preuba.Name = "btn_preuba";
            btn_preuba.Size = new Size(75, 23);
            btn_preuba.TabIndex = 0;
            btn_preuba.Text = "Preuba";
            btn_preuba.UseVisualStyleBackColor = true;
            btn_preuba.Click += btn_preuba_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_preuba);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_preuba;
    }
}