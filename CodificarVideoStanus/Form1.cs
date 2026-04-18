using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace CodificarVideoStanus
{
    public partial class Form1 : Form
    {
        private Task? ffmpegTask; // Tarea para ejecutar el proceso de FFmpeg de forma asíncrona
        private CancellationTokenSource? cancellationTokenSource; // Fuente de cancelación para detener el proceso
        private Process? ffmpegProcess; // Proceso de FFmpeg

        public Form1()
        {
            InitializeComponent();

            // Agregar la ruta de C:\ffmpeg al PATH
            string pathVariable = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            if (pathVariable != null && !pathVariable.Contains(@"C:\ffmpeg"))
            {
                pathVariable += @";C:\ffmpeg";
                Environment.SetEnvironmentVariable("PATH", pathVariable, EnvironmentVariableTarget.Machine);
            }

            // Establecer los valores por defecto en los TextBox
            PadTextBox.Text = "3840:2160:0:280";
            FontSizeTextBox.Text = "18";
            PresetTextBox.Text = "fast";

            QualityPresetComboBox.Items.AddRange(new object[] {
                "Sin pérdida (Lossless)",
                "Alta calidad",
                "Equilibrio"
            });
            QualityPresetComboBox.SelectedIndex = 1; // Alta calidad por defecto
            txtFfmpegPath.Text = @"C:\ffmpeg\ffmpeg.exe";
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de video|*.mkv;*.mp4;*.avi|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccione el archivo de video de entrada";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    VideoInputTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void buttonSubtitulo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de subtítulos|*.srt|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccione el archivo de subtítulos";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SubtitlesTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkRumano.Checked = true;
        }

        private void btnFfmpegPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Ejecutable de FFmpeg|ffmpeg.exe|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccione el ejecutable de FFmpeg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFfmpegPath.Text = openFileDialog.FileName;
                }
            }
        }

        private async void buttonConvertir_Click(object sender, EventArgs e)
        {
            if (ffmpegTask != null && !ffmpegTask.IsCompleted)
            {
                MessageBox.Show("Ya se está ejecutando un proceso de conversión.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inputVideo = VideoInputTextBox.Text;
            string subtitles = SubtitlesTextBox.Text;
            string outputVideo = OutputVideoTextBox.Text;

            if (string.IsNullOrEmpty(inputVideo))
            {
                MessageBox.Show("Por favor, seleccione un video de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener valores configurados
            string padValue = PadTextBox.Text;
            string fontSizeValue = FontSizeTextBox.Text;
            string presetValue = PresetTextBox.Text;

            string qualityValue = "20";
            switch (QualityPresetComboBox.SelectedItem?.ToString())
            {
                case "Sin pérdida (Lossless)": qualityValue = "0"; break;
                case "Alta calidad": qualityValue = "20"; break;
                case "Equilibrio": qualityValue = "30"; break;
            }

            string idiomaVideo = "";
            if (checkRumano.Checked) idiomaVideo = "_RO";
            if (checkEspañol.Checked) idiomaVideo = "_ES";

            string formattedDate = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            if (string.IsNullOrEmpty(outputVideo))
                outputVideo = Path.GetFileNameWithoutExtension(inputVideo) + idiomaVideo + $"_{formattedDate}.mp4";

            string videoDirectory = Path.GetDirectoryName(inputVideo) ?? "";
            
            // FFmpeg usa argumentos separados, no una sola cadena de comando de CMD
            // Para ejecutarlo directamente, necesitamos separar el ejecutable de los argumentos
            string ffmpegExe = txtFfmpegPath.Text;

            if (string.IsNullOrEmpty(ffmpegExe) || !File.Exists(ffmpegExe))
            {
                MessageBox.Show("La ruta de FFmpeg no es válida. Por favor, seleccione el ejecutable ffmpeg.exe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            // Argumentos para FFmpeg
            string args = $"-i \"{Path.GetFileName(inputVideo)}\" ";
            if (!checkOnlyConvert.Checked)
            {
                args += $"-vf \"pad={padValue},subtitles={Path.GetFileName(subtitles)}:force_style='Fontname=Calibri,Fontsize={fontSizeValue},Bold=1,BackColour=&H80000000,Outline=0.5,Shadow=0.5'\" ";
            }
            args += $"-c:v h264_nvenc -preset {presetValue} -cq {qualityValue} -c:a copy \"{Path.GetFileName(outputVideo)}\"";

            CommandTextBox.Text = $"{ffmpegExe} {args}";
            rtbLog.Clear();
            rtbLog.AppendText("Iniciando conversión...\n");

            cancellationTokenSource = new CancellationTokenSource();
            
            try
            {
                ffmpegTask = RunFfmpegAsync(ffmpegExe, args, videoDirectory, cancellationTokenSource.Token);
                await ffmpegTask;
                MessageBox.Show("La conversión ha terminado.", "CodificarVideoStanus");
            }
            catch (OperationCanceledException)
            {
                rtbLog.AppendText("\nProceso cancelado por el usuario.\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cancellationTokenSource.Dispose();
                cancellationTokenSource = null;
            }
        }

        private async Task RunFfmpegAsync(string exe, string args, string workingDir, CancellationToken token)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = exe,
                Arguments = args,
                WorkingDirectory = workingDir,
                UseShellExecute = false,
                RedirectStandardError = true, // FFmpeg envía el log a stderr
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            ffmpegProcess = new Process
            {
                StartInfo = startInfo
            };

            ffmpegProcess.OutputDataReceived += (s, e) => LogOutput(e.Data);
            ffmpegProcess.ErrorDataReceived += (s, e) => LogOutput(e.Data);

            ffmpegProcess.Start();
            ffmpegProcess.BeginOutputReadLine();
            ffmpegProcess.BeginErrorReadLine();

            while (!ffmpegProcess.HasExited)
            {
                if (token.IsCancellationRequested)
                {
                    try { ffmpegProcess.Kill(); } catch { }
                    throw new OperationCanceledException();
                }
                await Task.Delay(100, token);
            }
        }

        private void LogOutput(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            
            // Invocar en el hilo de la UI
            this.Invoke(new Action(() =>
            {
                rtbLog.AppendText(text + Environment.NewLine);
                rtbLog.SelectionStart = rtbLog.Text.Length;
                rtbLog.ScrollToCaret();
            }));
        }

        private void OutputVideoTextBox_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                MessageBox.Show("Solicitando detener la conversión...", "Detenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
