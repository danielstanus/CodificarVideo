namespace CodificarVideoStanus
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonVideo = new Button();
            buttonConvertir = new Button();
            buttonSubtitulo = new Button();
            VideoPathLabel = new Label();
            VideoInputTextBox = new TextBox();
            SubtitlesTextBox = new TextBox();
            OutputVideoTextBox = new TextBox();
            groupBox1 = new GroupBox();
            checkOnlyConvert = new CheckBox();
            checkEspañol = new CheckBox();
            checkRumano = new CheckBox();
            label4 = new Label();
            PresetTextBox = new TextBox();
            labelQuality = new Label();
            QualityPresetComboBox = new ComboBox();
            label2 = new Label();
            FontSizeTextBox = new TextBox();
            label1 = new Label();
            PadTextBox = new TextBox();
            CommandTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rtbLog = new RichTextBox();
            btnFfmpegPath = new Button();
            txtFfmpegPath = new TextBox();
            labelFfmpegPath = new Label();
            btnStop = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVideo
            // 
            buttonVideo.Font = new Font("Segoe UI", 11F);
            buttonVideo.Location = new Point(12, 12);
            buttonVideo.Name = "buttonVideo";
            buttonVideo.Size = new Size(160, 50);
            buttonVideo.TabIndex = 0;
            buttonVideo.Text = "📁 Seleccionar video";
            buttonVideo.UseVisualStyleBackColor = true;
            buttonVideo.Click += buttonVideo_Click;
            // 
            // buttonConvertir
            // 
            buttonConvertir.BackColor = Color.MistyRose;
            buttonConvertir.Font = new Font("Segoe UI", 14F);
            buttonConvertir.Location = new Point(12, 124);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(160, 60);
            buttonConvertir.TabIndex = 2;
            buttonConvertir.Text = "🚀 Convertir";
            buttonConvertir.UseVisualStyleBackColor = false;
            buttonConvertir.Click += buttonConvertir_Click;
            // 
            // buttonSubtitulo
            // 
            buttonSubtitulo.Font = new Font("Segoe UI", 11F);
            buttonSubtitulo.Location = new Point(12, 68);
            buttonSubtitulo.Name = "buttonSubtitulo";
            buttonSubtitulo.Size = new Size(160, 50);
            buttonSubtitulo.TabIndex = 1;
            buttonSubtitulo.Text = "📜 Seleccionar subtitulo";
            buttonSubtitulo.UseVisualStyleBackColor = true;
            buttonSubtitulo.Click += buttonSubtitulo_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Tomato;
            btnStop.Font = new Font("Segoe UI", 12F);
            btnStop.Location = new Point(12, 190);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(160, 45);
            btnStop.TabIndex = 3;
            btnStop.Text = "🛑 STOP";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // VideoPathLabel
            // 
            VideoPathLabel.AutoSize = true;
            VideoPathLabel.Location = new Point(190, 25);
            VideoPathLabel.Name = "VideoPathLabel";
            VideoPathLabel.Size = new Size(38, 15);
            VideoPathLabel.TabIndex = 4;
            VideoPathLabel.Text = "Input:";
            // 
            // VideoInputTextBox
            // 
            VideoInputTextBox.Location = new Point(190, 43);
            VideoInputTextBox.Multiline = true;
            VideoInputTextBox.Name = "VideoInputTextBox";
            VideoInputTextBox.Size = new Size(898, 30);
            VideoInputTextBox.TabIndex = 5;
            // 
            // SubtitlesTextBox
            // 
            SubtitlesTextBox.Location = new Point(190, 153);
            SubtitlesTextBox.Multiline = true;
            SubtitlesTextBox.Name = "SubtitlesTextBox";
            SubtitlesTextBox.Size = new Size(898, 30);
            SubtitlesTextBox.TabIndex = 9;
            // 
            // OutputVideoTextBox
            // 
            OutputVideoTextBox.Location = new Point(190, 98);
            OutputVideoTextBox.Multiline = true;
            OutputVideoTextBox.Name = "OutputVideoTextBox";
            OutputVideoTextBox.Size = new Size(898, 30);
            OutputVideoTextBox.TabIndex = 7;
            OutputVideoTextBox.TextChanged += OutputVideoTextBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkOnlyConvert);
            groupBox1.Controls.Add(checkEspañol);
            groupBox1.Controls.Add(checkRumano);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(PresetTextBox);
            groupBox1.Controls.Add(labelQuality);
            groupBox1.Controls.Add(QualityPresetComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(FontSizeTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PadTextBox);
            groupBox1.Location = new Point(190, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 180);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuracion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "Pad:";
            // 
            // PadTextBox
            // 
            PadTextBox.Location = new Point(80, 22);
            PadTextBox.Name = "PadTextBox";
            PadTextBox.Size = new Size(150, 23);
            PadTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 10;
            label2.Text = "Fontsize:";
            // 
            // FontSizeTextBox
            // 
            FontSizeTextBox.Location = new Point(80, 52);
            FontSizeTextBox.Name = "FontSizeTextBox";
            FontSizeTextBox.Size = new Size(150, 23);
            FontSizeTextBox.TabIndex = 11;
            // 
            // labelQuality
            // 
            labelQuality.AutoSize = true;
            labelQuality.Location = new Point(15, 85);
            labelQuality.Name = "labelQuality";
            labelQuality.Size = new Size(50, 15);
            labelQuality.TabIndex = 12;
            labelQuality.Text = "Calidad:";
            // 
            // QualityPresetComboBox
            // 
            QualityPresetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            QualityPresetComboBox.FormattingEnabled = true;
            QualityPresetComboBox.Location = new Point(80, 82);
            QualityPresetComboBox.Name = "QualityPresetComboBox";
            QualityPresetComboBox.Size = new Size(150, 23);
            QualityPresetComboBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 115);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 14;
            label4.Text = "Preset:";
            // 
            // PresetTextBox
            // 
            PresetTextBox.Location = new Point(80, 112);
            PresetTextBox.Name = "PresetTextBox";
            PresetTextBox.Size = new Size(150, 23);
            PresetTextBox.TabIndex = 15;
            // 
            // checkRumano
            // 
            checkRumano.AutoSize = true;
            checkRumano.Location = new Point(240, 25);
            checkRumano.Name = "checkRumano";
            checkRumano.Size = new Size(71, 19);
            checkRumano.TabIndex = 16;
            checkRumano.Text = "Rumano";
            checkRumano.UseVisualStyleBackColor = true;
            // 
            // checkEspañol
            // 
            checkEspañol.AutoSize = true;
            checkEspañol.Location = new Point(240, 50);
            checkEspañol.Name = "checkEspañol";
            checkEspañol.Size = new Size(67, 19);
            checkEspañol.TabIndex = 17;
            checkEspañol.Text = "Español";
            checkEspañol.UseVisualStyleBackColor = true;
            // 
            // checkOnlyConvert
            // 
            checkOnlyConvert.AutoSize = true;
            checkOnlyConvert.Location = new Point(240, 75);
            checkOnlyConvert.Name = "checkOnlyConvert";
            checkOnlyConvert.Size = new Size(93, 19);
            checkOnlyConvert.TabIndex = 18;
            checkOnlyConvert.Text = "OnlyConvert";
            checkOnlyConvert.UseVisualStyleBackColor = true;
            // 
            // CommandTextBox
            // 
            CommandTextBox.Location = new Point(12, 268);
            CommandTextBox.Multiline = true;
            CommandTextBox.Name = "CommandTextBox";
            CommandTextBox.Size = new Size(160, 30);
            CommandTextBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 80);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 6;
            label5.Text = "Output:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 135);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 8;
            label6.Text = "Input subtitle:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 250);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 14;
            label7.Text = "Comando:";
            // 
            // rtbLog
            // 
            rtbLog.BackColor = Color.Black;
            rtbLog.Font = new Font("Consolas", 9F);
            rtbLog.ForeColor = Color.LimeGreen;
            rtbLog.Location = new Point(510, 240);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(578, 150);
            rtbLog.TabIndex = 16;
            rtbLog.Text = "";
            // 
            // btnFfmpegPath
            // 
            btnFfmpegPath.Location = new Point(964, 208);
            btnFfmpegPath.Name = "btnFfmpegPath";
            btnFfmpegPath.Size = new Size(124, 23);
            btnFfmpegPath.TabIndex = 12;
            btnFfmpegPath.Text = "🔍 Buscar";
            btnFfmpegPath.UseVisualStyleBackColor = true;
            btnFfmpegPath.Click += btnFfmpegPath_Click;
            // 
            // txtFfmpegPath
            // 
            txtFfmpegPath.Location = new Point(190, 208);
            txtFfmpegPath.Name = "txtFfmpegPath";
            txtFfmpegPath.Size = new Size(768, 23);
            txtFfmpegPath.TabIndex = 11;
            // 
            // labelFfmpegPath
            // 
            labelFfmpegPath.AutoSize = true;
            labelFfmpegPath.Location = new Point(190, 190);
            labelFfmpegPath.Name = "labelFfmpegPath";
            labelFfmpegPath.Size = new Size(75, 15);
            labelFfmpegPath.TabIndex = 10;
            labelFfmpegPath.Text = "FFmpeg EXE:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 410);
            Controls.Add(rtbLog);
            Controls.Add(btnFfmpegPath);
            Controls.Add(txtFfmpegPath);
            Controls.Add(labelFfmpegPath);
            Controls.Add(label7);
            Controls.Add(CommandTextBox);
            Controls.Add(groupBox1);
            Controls.Add(SubtitlesTextBox);
            Controls.Add(label6);
            Controls.Add(OutputVideoTextBox);
            Controls.Add(label5);
            Controls.Add(VideoInputTextBox);
            Controls.Add(VideoPathLabel);
            Controls.Add(buttonSubtitulo);
            Controls.Add(buttonConvertir);
            Controls.Add(buttonVideo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Codificar Videos Stanus";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonVideo;
        private Button buttonConvertir;
        private Button buttonSubtitulo;
        private Label VideoPathLabel;
        private TextBox VideoInputTextBox;
        private TextBox SubtitlesTextBox;
        private TextBox OutputVideoTextBox;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox PresetTextBox;
        private Label labelQuality;
        private ComboBox QualityPresetComboBox;
        private Label label2;
        private TextBox FontSizeTextBox;
        private Label label1;
        private TextBox PadTextBox;
        private TextBox CommandTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnStop;
        private CheckBox checkEspañol;
        private CheckBox checkRumano;
        private CheckBox checkOnlyConvert;
        private RichTextBox rtbLog;
        private Button btnFfmpegPath;
        private TextBox txtFfmpegPath;
        private Label labelFfmpegPath;
    }
}