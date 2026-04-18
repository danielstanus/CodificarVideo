namespace CodificarVideoStanus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonVideo = new Button();
            buttonConvertir = new Button();
            buttonSubtitulo = new Button();
            VideoPathLabel = new Label();
            VideoInputTextBox = new TextBox();
            SubtitlesTextBox = new TextBox();
            OutputVideoTextBox = new TextBox();
            groupBox1 = new GroupBox();
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


            checkOnlyConvert = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVideo
            // 
            buttonVideo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVideo.Location = new Point(12, 12);
            buttonVideo.Name = "buttonVideo";
            buttonVideo.Size = new Size(141, 122);
            buttonVideo.TabIndex = 0;
            buttonVideo.Text = "📁 Seleccionar video";
            buttonVideo.UseVisualStyleBackColor = true;
            buttonVideo.Click += buttonVideo_Click;
            // 
            // buttonConvertir
            // 
            buttonConvertir.BackColor = Color.MistyRose;
            buttonConvertir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConvertir.Location = new Point(12, 274);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(141, 97);
            buttonConvertir.TabIndex = 2;
            buttonConvertir.Text = "🚀 Convertir";
            buttonConvertir.UseVisualStyleBackColor = false;
            buttonConvertir.Click += buttonConvertir_Click;
            // 
            // buttonSubtitulo
            // 
            buttonSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubtitulo.Location = new Point(12, 156);
            buttonSubtitulo.Name = "buttonSubtitulo";
            buttonSubtitulo.Size = new Size(141, 62);
            buttonSubtitulo.TabIndex = 3;
            buttonSubtitulo.Text = "📜 Seleccionar subtitulo";
            buttonSubtitulo.UseVisualStyleBackColor = true;
            buttonSubtitulo.Click += buttonSubtitulo_Click;
            // 
            // VideoPathLabel
            // 
            VideoPathLabel.AutoSize = true;
            VideoPathLabel.Location = new Point(172, 12);
            VideoPathLabel.Name = "VideoPathLabel";
            VideoPathLabel.Size = new Size(38, 15);
            VideoPathLabel.TabIndex = 4;
            VideoPathLabel.Text = "Input:";
            // 
            // VideoInputTextBox
            // 
            VideoInputTextBox.Location = new Point(172, 30);
            VideoInputTextBox.Multiline = true;
            VideoInputTextBox.Name = "VideoInputTextBox";
            VideoInputTextBox.Size = new Size(916, 44);
            VideoInputTextBox.TabIndex = 5;
            // 
            // SubtitlesTextBox
            // 
            SubtitlesTextBox.Location = new Point(172, 174);
            SubtitlesTextBox.Multiline = true;
            SubtitlesTextBox.Name = "SubtitlesTextBox";
            SubtitlesTextBox.Size = new Size(916, 44);
            SubtitlesTextBox.TabIndex = 6;
            // 
            // OutputVideoTextBox
            // 
            OutputVideoTextBox.Location = new Point(172, 95);
            OutputVideoTextBox.Multiline = true;
            OutputVideoTextBox.Name = "OutputVideoTextBox";
            OutputVideoTextBox.Size = new Size(916, 39);
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
            groupBox1.Location = new Point(172, 247);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 158);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuracion";
            // 
            // checkEspañol
            // 
            checkEspañol.AutoSize = true;
            checkEspañol.Location = new Point(365, 62);
            checkEspañol.Name = "checkEspañol";
            checkEspañol.Size = new Size(67, 19);
            checkEspañol.TabIndex = 17;
            checkEspañol.Text = "Español";
            checkEspañol.UseVisualStyleBackColor = true;
            // 
            // checkRumano
            // 
            checkRumano.AutoSize = true;
            checkRumano.Location = new Point(365, 31);
            checkRumano.Name = "checkRumano";
            checkRumano.Size = new Size(71, 19);
            checkRumano.TabIndex = 16;
            checkRumano.Text = "Rumano";
            checkRumano.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 119);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 14;
            label4.Text = "Preset:";
            // 
            // PresetTextBox
            // 
            PresetTextBox.Location = new Point(91, 116);
            PresetTextBox.Name = "PresetTextBox";
            PresetTextBox.Size = new Size(196, 23);
            PresetTextBox.TabIndex = 15;
            // 
            // labelQuality
            // 
            labelQuality.AutoSize = true;
            labelQuality.Location = new Point(21, 90);
            labelQuality.Name = "labelQuality";
            labelQuality.Size = new Size(55, 15);
            labelQuality.TabIndex = 12;
            labelQuality.Text = "Calidad:";
            // 
            // QualityPresetComboBox
            // 
            QualityPresetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            QualityPresetComboBox.FormattingEnabled = true;
            QualityPresetComboBox.Location = new Point(91, 87);
            QualityPresetComboBox.Name = "QualityPresetComboBox";
            QualityPresetComboBox.Size = new Size(196, 23);
            QualityPresetComboBox.TabIndex = 13;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 61);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 10;
            label2.Text = "Fontsize:";
            // 
            // FontSizeTextBox
            // 
            FontSizeTextBox.Location = new Point(91, 58);
            FontSizeTextBox.Name = "FontSizeTextBox";
            FontSizeTextBox.Size = new Size(196, 23);
            FontSizeTextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "Pad:";
            // 
            // PadTextBox
            // 
            PadTextBox.Location = new Point(91, 27);
            PadTextBox.Name = "PadTextBox";
            PadTextBox.Size = new Size(196, 23);
            PadTextBox.TabIndex = 9;
            // 
            // CommandTextBox
            // 
            CommandTextBox.Location = new Point(12, 426);
            CommandTextBox.Multiline = true;
            CommandTextBox.Name = "CommandTextBox";
            CommandTextBox.Size = new Size(1076, 93);
            CommandTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 77);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Output:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 156);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 11;
            label6.Text = "Input subtitle:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 408);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 12;
            label7.Text = "Comando:";
            // 
            // labelFfmpegPath
            // 
            labelFfmpegPath.AutoSize = true;
            labelFfmpegPath.Location = new Point(12, 375);
            labelFfmpegPath.Name = "labelFfmpegPath";
            labelFfmpegPath.Size = new Size(75, 15);
            labelFfmpegPath.TabIndex = 15;
            labelFfmpegPath.Text = "FFmpeg EXE:";
            // 
            // txtFfmpegPath
            // 
            txtFfmpegPath.Location = new Point(91, 372);
            txtFfmpegPath.Name = "txtFfmpegPath";
            txtFfmpegPath.Size = new Size(780, 23);
            txtFfmpegPath.TabIndex = 16;
            // 
            // btnFfmpegPath
            // 
            btnFfmpegPath.Location = new Point(877, 372);
            btnFfmpegPath.Name = "btnFfmpegPath";
            btnFfmpegPath.Size = new Size(210, 23);
            btnFfmpegPath.TabIndex = 17;
            btnFfmpegPath.Text = "🔍 Buscar FFmpeg";
            btnFfmpegPath.UseVisualStyleBackColor = true;
            btnFfmpegPath.Click += btnFfmpegPath_Click;

            btnStop.Location = new Point(947, 274);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(141, 97);
            btnStop.TabIndex = 13;
            btnStop.Text = "🛑 STOP";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // checkOnlyConvert
            // 
            checkOnlyConvert.AutoSize = true;
            checkOnlyConvert.Location = new Point(365, 105);
            checkOnlyConvert.Name = "checkOnlyConvert";
            checkOnlyConvert.Size = new Size(93, 19);
            checkOnlyConvert.TabIndex = 18;
            checkOnlyConvert.Text = "OnlyConvert";
            checkOnlyConvert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 550);
            Controls.Add(btnStop);
            Controls.Add(rtbLog);
            Controls.Add(btnFfmpegPath);
            Controls.Add(txtFfmpegPath);
            Controls.Add(labelFfmpegPath);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CommandTextBox);
            Controls.Add(groupBox1);
            Controls.Add(OutputVideoTextBox);
            Controls.Add(SubtitlesTextBox);
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

        #endregion

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