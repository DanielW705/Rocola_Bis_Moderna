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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtbxDuracion = new TextBox();
            label1 = new Label();
            txtbxNombreCancion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtbxAlbum = new TextBox();
            txtboxGenero = new TextBox();
            btnSubirArchivo = new Button();
            btnAgregarActualizar = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pBMusicProgress = new ProgressBar();
            ProgressTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 295);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 152);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(txtbxDuracion, 1, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(txtbxNombreCancion, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(txtbxAlbum, 1, 2);
            tableLayoutPanel3.Controls.Add(txtboxGenero, 1, 3);
            tableLayoutPanel3.Controls.Add(btnSubirArchivo, 1, 4);
            tableLayoutPanel3.Controls.Add(btnAgregarActualizar, 2, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(430, 146);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtbxDuracion
            // 
            txtbxDuracion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbxDuracion.Location = new Point(146, 32);
            txtbxDuracion.Name = "txtbxDuracion";
            txtbxDuracion.Size = new Size(137, 23);
            txtbxDuracion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 29);
            label1.TabIndex = 1;
            label1.Text = "Nombre de la cancion: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbxNombreCancion
            // 
            txtbxNombreCancion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbxNombreCancion.Location = new Point(146, 3);
            txtbxNombreCancion.Name = "txtbxNombreCancion";
            txtbxNombreCancion.Size = new Size(137, 23);
            txtbxNombreCancion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(137, 29);
            label2.TabIndex = 2;
            label2.Text = "Duracion: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(137, 29);
            label3.TabIndex = 3;
            label3.Text = "Album: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 116);
            label5.Name = "label5";
            label5.Size = new Size(137, 30);
            label5.TabIndex = 5;
            label5.Text = "Archivo: ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 87);
            label4.Name = "label4";
            label4.Size = new Size(137, 29);
            label4.TabIndex = 4;
            label4.Text = "Genero: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbxAlbum
            // 
            txtbxAlbum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbxAlbum.Location = new Point(146, 61);
            txtbxAlbum.Name = "txtbxAlbum";
            txtbxAlbum.Size = new Size(137, 23);
            txtbxAlbum.TabIndex = 6;
            // 
            // txtboxGenero
            // 
            txtboxGenero.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtboxGenero.Location = new Point(146, 90);
            txtboxGenero.Name = "txtboxGenero";
            txtboxGenero.Size = new Size(137, 23);
            txtboxGenero.TabIndex = 7;
            // 
            // btnSubirArchivo
            // 
            btnSubirArchivo.Anchor = AnchorStyles.None;
            btnSubirArchivo.Location = new Point(177, 119);
            btnSubirArchivo.Name = "btnSubirArchivo";
            btnSubirArchivo.Size = new Size(75, 23);
            btnSubirArchivo.TabIndex = 8;
            btnSubirArchivo.Text = "Subir Archivo";
            btnSubirArchivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarActualizar
            // 
            btnAgregarActualizar.Anchor = AnchorStyles.None;
            btnAgregarActualizar.Location = new Point(305, 68);
            btnAgregarActualizar.Name = "btnAgregarActualizar";
            tableLayoutPanel3.SetRowSpan(btnAgregarActualizar, 2);
            btnAgregarActualizar.Size = new Size(105, 37);
            btnAgregarActualizar.TabIndex = 9;
            btnAgregarActualizar.Text = "Agregar";
            btnAgregarActualizar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel4.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel4.Controls.Add(pictureBox3, 2, 1);
            tableLayoutPanel4.Controls.Add(pictureBox4, 3, 1);
            tableLayoutPanel4.Controls.Add(pBMusicProgress, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(439, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(352, 146);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Rocola_Bis_Moderna.Properties.Resources.arrow;
            pictureBox1.Location = new Point(3, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Rocola_Bis_Moderna.Properties.Resources.music_play;
            pictureBox2.Location = new Point(91, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Rocola_Bis_Moderna.Properties.Resources.music_pause;
            pictureBox3.Location = new Point(179, 76);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Rocola_Bis_Moderna.Properties.Resources.arrow;
            pictureBox4.Location = new Point(267, 76);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(82, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pBMusicProgress
            // 
            pBMusicProgress.Anchor = AnchorStyles.None;
            tableLayoutPanel4.SetColumnSpan(pBMusicProgress, 4);
            pBMusicProgress.Location = new Point(4, 25);
            pBMusicProgress.Name = "pBMusicProgress";
            pBMusicProgress.Size = new Size(343, 23);
            pBMusicProgress.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtbxDuracion;
        private TextBox txtbxNombreCancion;
        private TextBox txtbxAlbum;
        private TextBox txtboxGenero;
        private Button btnSubirArchivo;
        private Button btnAgregarActualizar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ProgressBar pBMusicProgress;
        private System.Windows.Forms.Timer ProgressTimer;
    }
}