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
            CuerpoRocola = new TableLayoutPanel();
            CuerpoControles = new TableLayoutPanel();
            ControlesArchivo = new TableLayoutPanel();
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
            ControlesMusica = new TableLayoutPanel();
            after_button = new Button();
            pause_button = new Button();
            play_button = new Button();
            before_button = new Button();
            pBMusicProgress = new ProgressBar();
            DataGridViewVistaCanciones = new DataGridView();
            ProgressTimer = new System.Windows.Forms.Timer(components);
            CuerpoRocola.SuspendLayout();
            CuerpoControles.SuspendLayout();
            ControlesArchivo.SuspendLayout();
            ControlesMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewVistaCanciones).BeginInit();
            SuspendLayout();
            // 
            // CuerpoRocola
            // 
            CuerpoRocola.ColumnCount = 1;
            CuerpoRocola.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CuerpoRocola.Controls.Add(CuerpoControles, 0, 1);
            CuerpoRocola.Controls.Add(DataGridViewVistaCanciones, 0, 0);
            CuerpoRocola.Dock = DockStyle.Fill;
            CuerpoRocola.Location = new Point(0, 0);
            CuerpoRocola.Name = "CuerpoRocola";
            CuerpoRocola.RowCount = 2;
            CuerpoRocola.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            CuerpoRocola.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            CuerpoRocola.Size = new Size(800, 450);
            CuerpoRocola.TabIndex = 0;
            // 
            // CuerpoControles
            // 
            CuerpoControles.ColumnCount = 2;
            CuerpoControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            CuerpoControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            CuerpoControles.Controls.Add(ControlesArchivo, 0, 0);
            CuerpoControles.Controls.Add(ControlesMusica, 1, 0);
            CuerpoControles.Dock = DockStyle.Fill;
            CuerpoControles.Location = new Point(3, 295);
            CuerpoControles.Name = "CuerpoControles";
            CuerpoControles.RowCount = 1;
            CuerpoControles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CuerpoControles.Size = new Size(794, 152);
            CuerpoControles.TabIndex = 0;
            // 
            // ControlesArchivo
            // 
            ControlesArchivo.ColumnCount = 3;
            ControlesArchivo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ControlesArchivo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ControlesArchivo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ControlesArchivo.Controls.Add(txtbxDuracion, 1, 1);
            ControlesArchivo.Controls.Add(label1, 0, 0);
            ControlesArchivo.Controls.Add(txtbxNombreCancion, 1, 0);
            ControlesArchivo.Controls.Add(label2, 0, 1);
            ControlesArchivo.Controls.Add(label3, 0, 2);
            ControlesArchivo.Controls.Add(label5, 0, 4);
            ControlesArchivo.Controls.Add(label4, 0, 3);
            ControlesArchivo.Controls.Add(txtbxAlbum, 1, 2);
            ControlesArchivo.Controls.Add(txtboxGenero, 1, 3);
            ControlesArchivo.Controls.Add(btnSubirArchivo, 1, 4);
            ControlesArchivo.Controls.Add(btnAgregarActualizar, 2, 2);
            ControlesArchivo.Dock = DockStyle.Fill;
            ControlesArchivo.Location = new Point(3, 3);
            ControlesArchivo.Name = "ControlesArchivo";
            ControlesArchivo.RowCount = 5;
            ControlesArchivo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ControlesArchivo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ControlesArchivo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ControlesArchivo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ControlesArchivo.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ControlesArchivo.Size = new Size(430, 146);
            ControlesArchivo.TabIndex = 0;
            // 
            // txtbxDuracion
            // 
            txtbxDuracion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbxDuracion.Location = new Point(146, 32);
            txtbxDuracion.Name = "txtbxDuracion";
            txtbxDuracion.Size = new Size(137, 23);
            txtbxDuracion.TabIndex = 2;
            txtbxDuracion.KeyPress += txtbxDuracion_KeyPress;
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
            btnSubirArchivo.Click += btnSubirArchivo_Click;
            // 
            // btnAgregarActualizar
            // 
            btnAgregarActualizar.Anchor = AnchorStyles.None;
            btnAgregarActualizar.Location = new Point(305, 68);
            btnAgregarActualizar.Name = "btnAgregarActualizar";
            ControlesArchivo.SetRowSpan(btnAgregarActualizar, 2);
            btnAgregarActualizar.Size = new Size(105, 37);
            btnAgregarActualizar.TabIndex = 9;
            btnAgregarActualizar.Text = "Agregar";
            btnAgregarActualizar.UseVisualStyleBackColor = true;
            btnAgregarActualizar.Click += btnAgregarActualizar_Click;
            // 
            // ControlesMusica
            // 
            ControlesMusica.ColumnCount = 4;
            ControlesMusica.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ControlesMusica.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ControlesMusica.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ControlesMusica.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ControlesMusica.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ControlesMusica.Controls.Add(after_button, 3, 1);
            ControlesMusica.Controls.Add(pause_button, 2, 1);
            ControlesMusica.Controls.Add(play_button, 1, 1);
            ControlesMusica.Controls.Add(before_button, 0, 1);
            ControlesMusica.Controls.Add(pBMusicProgress, 0, 0);
            ControlesMusica.Dock = DockStyle.Fill;
            ControlesMusica.Location = new Point(439, 3);
            ControlesMusica.Name = "ControlesMusica";
            ControlesMusica.RowCount = 2;
            ControlesMusica.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ControlesMusica.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ControlesMusica.Size = new Size(352, 146);
            ControlesMusica.TabIndex = 1;
            // 
            // after_button
            // 
            after_button.BackColor = Color.Transparent;
            after_button.BackgroundImage = Rocola_Bis_Moderna.Properties.Resources.arrow;
            after_button.BackgroundImageLayout = ImageLayout.Zoom;
            after_button.Cursor = Cursors.Hand;
            after_button.Dock = DockStyle.Fill;
            after_button.FlatStyle = FlatStyle.Flat;
            after_button.ForeColor = Color.Transparent;
            after_button.Location = new Point(267, 76);
            after_button.Name = "after_button";
            after_button.Size = new Size(82, 67);
            after_button.TabIndex = 8;
            after_button.TextImageRelation = TextImageRelation.ImageAboveText;
            after_button.UseVisualStyleBackColor = true;
            after_button.Click += after_button_Click;
            // 
            // pause_button
            // 
            pause_button.BackColor = Color.Transparent;
            pause_button.BackgroundImage = Rocola_Bis_Moderna.Properties.Resources.music_pause;
            pause_button.BackgroundImageLayout = ImageLayout.Zoom;
            pause_button.Cursor = Cursors.Hand;
            pause_button.Dock = DockStyle.Fill;
            pause_button.FlatStyle = FlatStyle.Flat;
            pause_button.ForeColor = Color.Transparent;
            pause_button.Location = new Point(179, 76);
            pause_button.Name = "pause_button";
            pause_button.Size = new Size(82, 67);
            pause_button.TabIndex = 7;
            pause_button.TextImageRelation = TextImageRelation.ImageAboveText;
            pause_button.UseVisualStyleBackColor = true;
            pause_button.Click += pause_button_Click;
            // 
            // play_button
            // 
            play_button.BackColor = Color.Transparent;
            play_button.BackgroundImage = Rocola_Bis_Moderna.Properties.Resources.music_play;
            play_button.BackgroundImageLayout = ImageLayout.Zoom;
            play_button.Cursor = Cursors.Hand;
            play_button.Dock = DockStyle.Fill;
            play_button.FlatStyle = FlatStyle.Flat;
            play_button.ForeColor = Color.Transparent;
            play_button.Location = new Point(91, 76);
            play_button.Name = "play_button";
            play_button.Size = new Size(82, 67);
            play_button.TabIndex = 6;
            play_button.TextImageRelation = TextImageRelation.ImageAboveText;
            play_button.UseVisualStyleBackColor = true;
            play_button.Click += play_button_Click;
            // 
            // before_button
            // 
            before_button.BackColor = Color.Transparent;
            before_button.BackgroundImage = Rocola_Bis_Moderna.Properties.Resources.arrow;
            before_button.BackgroundImageLayout = ImageLayout.Zoom;
            before_button.Cursor = Cursors.Hand;
            before_button.Dock = DockStyle.Fill;
            before_button.FlatStyle = FlatStyle.Flat;
            before_button.ForeColor = Color.Transparent;
            before_button.Location = new Point(3, 76);
            before_button.Name = "before_button";
            before_button.Size = new Size(82, 67);
            before_button.TabIndex = 5;
            before_button.TextImageRelation = TextImageRelation.ImageAboveText;
            before_button.UseVisualStyleBackColor = true;
            before_button.Click += before_button_Click;
            // 
            // pBMusicProgress
            // 
            pBMusicProgress.Anchor = AnchorStyles.None;
            ControlesMusica.SetColumnSpan(pBMusicProgress, 4);
            pBMusicProgress.Location = new Point(4, 25);
            pBMusicProgress.Name = "pBMusicProgress";
            pBMusicProgress.Size = new Size(343, 23);
            pBMusicProgress.TabIndex = 4;
            // 
            // DataGridViewVistaCanciones
            // 
            DataGridViewVistaCanciones.AllowUserToAddRows = false;
            DataGridViewVistaCanciones.AllowUserToDeleteRows = false;
            DataGridViewVistaCanciones.AllowUserToResizeColumns = false;
            DataGridViewVistaCanciones.AllowUserToResizeRows = false;
            DataGridViewVistaCanciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewVistaCanciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DataGridViewVistaCanciones.BorderStyle = BorderStyle.None;
            DataGridViewVistaCanciones.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            DataGridViewVistaCanciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewVistaCanciones.Dock = DockStyle.Fill;
            DataGridViewVistaCanciones.Location = new Point(3, 3);
            DataGridViewVistaCanciones.MultiSelect = false;
            DataGridViewVistaCanciones.Name = "DataGridViewVistaCanciones";
            DataGridViewVistaCanciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridViewVistaCanciones.RowTemplate.Height = 25;
            DataGridViewVistaCanciones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridViewVistaCanciones.ShowCellErrors = false;
            DataGridViewVistaCanciones.Size = new Size(794, 286);
            DataGridViewVistaCanciones.TabIndex = 1;
            DataGridViewVistaCanciones.CellContentClick += DataGridViewVistaCanciones_CellContentClick;
            // 
            // ProgressTimer
            // 
            ProgressTimer.Tick += ProgressTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CuerpoRocola);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            CuerpoRocola.ResumeLayout(false);
            CuerpoControles.ResumeLayout(false);
            ControlesArchivo.ResumeLayout(false);
            ControlesArchivo.PerformLayout();
            ControlesMusica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewVistaCanciones).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TableLayoutPanel CuerpoRocola;
        private TableLayoutPanel CuerpoControles;
        private TableLayoutPanel ControlesArchivo;
        private TableLayoutPanel ControlesMusica;
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
        private ProgressBar pBMusicProgress;
        private System.Windows.Forms.Timer ProgressTimer;
        private DataGridView DataGridViewVistaCanciones;
        private Button after_button;
        private Button pause_button;
        private Button play_button;
        private Button before_button;
    }
}