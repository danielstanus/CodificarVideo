using System.Diagnostics;
using System.Threading;

namespace CodificarVideoStanus
{
    public partial class Form1 : Form
    {
        private Thread ffmpegThread; // Hilo para ejecutar el proceso de FFmpeg
        private CancellationTokenSource cancellationTokenSource; // Fuente de cancelación para detener el proceso
        private Process ffmpegProcess; // Proceso de FFmpeg

        public Form1()
        {
            InitializeComponent();

            // Agregar la ruta de C:\ffmpeg al PATH
            string pathVariable = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            if (!pathVariable.Contains(@"C:\ffmpeg"))
            {
                pathVariable += @";C:\ffmpeg";
                Environment.SetEnvironmentVariable("PATH", pathVariable, EnvironmentVariableTarget.Machine);
            }
            // Establecer los valores por defecto en los TextBox
            PadTextBox.Text = "3840:2160:0:280";
            FontSizeTextBox.Text = "18";
            BitrateTextBox.Text = "5M";
            PresetTextBox.Text = "fast";
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

        private void buttonConvertir_Click(object sender, EventArgs e)
        {

            if (ffmpegThread != null && ffmpegThread.IsAlive)
            {
                MessageBox.Show("Ya se está ejecutando un proceso de conversión.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inputVideo = VideoInputTextBox.Text;
            string subtitles = SubtitlesTextBox.Text;
            string outputVideo = OutputVideoTextBox.Text;

            // Obtener valores configurados desde los TextBox
            string padValue = PadTextBox.Text;
            string fontSizeValue = FontSizeTextBox.Text;
            string bitrateValue = BitrateTextBox.Text;
            string presetValue = PresetTextBox.Text;

            string idiomaVideo = "";
            if (checkRumano.Checked)
                idiomaVideo = "_RO";

            if (checkEspañol.Checked)
                idiomaVideo = "_ES";

            // Obtener la fecha y hora actual
            DateTime now = DateTime.Now;

            // Formatear la fecha y hora actual en un formato que incluya segundos
            string formattedDate = now.ToString("yyyyMMdd_HHmmss");
            if (outputVideo == "")
                outputVideo = Path.GetFileNameWithoutExtension(inputVideo) + idiomaVideo + $"_{formattedDate}.mp4";


            // Obtener el directorio donde se encuentra el archivo de video
            string videoDirectory = Path.GetDirectoryName(inputVideo);

            // Construir la línea de comando para cambiar al directorio
            string cdCommand = $"cd /d \"{videoDirectory}\"";

            // Construir la línea de comando de FFmpeg con valores configurados
            string ffmpegCommand = $"C:\\ffmpeg\\ffmpeg.exe -i \"{Path.GetFileName(inputVideo)}\" -vf \"pad={padValue},subtitles={Path.GetFileName(subtitles)}:force_style='Fontname=Calibri,Fontsize={fontSizeValue},Bold=1,BackColour=&H80000000,Outline=0.5,Shadow=0.5'\" -c:v h264_nvenc -preset {presetValue} -b:v {bitrateValue} -c:a copy \"{Path.GetFileName(outputVideo)}\"";

            if(checkOnlyConvert.Checked)
                ffmpegCommand = $"C:\\ffmpeg\\ffmpeg.exe -i \"{Path.GetFileName(inputVideo)}\" -c:v h264_nvenc -preset {presetValue} -b:v {bitrateValue} -c:a copy \"{Path.GetFileName(outputVideo)}\"";



            CommandTextBox.Text = ffmpegCommand;

            // Configurar la información de inicio para ejecutar CMD
            //ProcessStartInfo cmdStartInfo = new ProcessStartInfo
            //{
            //    FileName = "cmd.exe",
            //    RedirectStandardInput = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = false // Establecer en true si no se desea abrir una ventana de CMD
            //};

            //cmdProcess = new Process
            //{
            //    StartInfo = cmdStartInfo
            //};

            //// Iniciar el proceso CMD y redirigir la entrada
            //cmdProcess.Start();

            //// Enviar el comando CD a la ventana de CMD
            //cmdProcess.StandardInput.WriteLine(cdCommand);

            //// Esperar unos segundos antes de ejecutar FFmpeg
            //Thread.Sleep(2000); // Esperar 2 segundos (puedes ajustar el tiempo)

            //// Enviar el comando FFmpeg a la ventana de CMD
            //cmdProcess.StandardInput.WriteLine(ffmpegCommand);

            //// Esperar unos segundos antes de ejecutar FFmpeg
            //Thread.Sleep(2000); // Esperar 2 segundos (puedes ajustar el tiempo)

            ////Esperar a que el proceso de CMD termine
            //cmdProcess.WaitForExit();

            ////Finalizar el proceso de CMD
            //cmdProcess.Close();

            //MessageBox.Show("La conversión ha terminado.", "CodificarVideoStanus");


            // Configurar la fuente de cancelación
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;


            // Iniciar un nuevo hilo para ejecutar CMD
            // Iniciar un nuevo hilo para ejecutar FFmpeg
            ffmpegThread = new Thread(() =>
            {
                try
                {
                    // Crear y configurar el proceso de FFmpeg
                    ffmpegProcess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = false
                        }
                    };

                    // Iniciar el proceso FFmpeg
                    ffmpegProcess.Start();


                    // Enviar el comando CD a la ventana de CMD
                    ffmpegProcess.StandardInput.WriteLine(cdCommand);

                    // Esperar unos segundos antes de ejecutar FFmpeg
                    Thread.Sleep(2000); // Esperar 2 segundos (puedes ajustar el tiempo)

                    // Enviar el comando FFmpeg a la ventana de CMD
                    ffmpegProcess.StandardInput.WriteLine(ffmpegCommand);

                    // Esperar unos segundos antes de ejecutar FFmpeg
                    Thread.Sleep(2000); // Esperar 2 segundos (puedes ajustar el tiempo)

                    //Esperar a que el proceso de CMD termine
                    ffmpegProcess.WaitForExit();

                    MessageBox.Show("La conversión ha terminado.", "CodificarVideoStanus");

                    // Esperar a que FFmpeg termine
                    while (!ffmpegProcess.HasExited)
                    {
                        // Verificar si se ha solicitado la cancelación
                        if (cancellationToken.IsCancellationRequested)
                        {
                            // Detener FFmpeg de manera ordenada
                            ffmpegProcess.StandardInput.WriteLine("q");
                            break;
                        }

                        // Esperar un breve período para evitar un bucle de CPU
                        Thread.Sleep(100);
                    }

                    // Cerrar el proceso FFmpeg
                    ffmpegProcess.Close();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que pueda ocurrir durante la ejecución
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Liberar recursos
                    cancellationTokenSource.Dispose();
                    ffmpegProcess.Close();
                }
            });

            // Iniciar el hilo FFmpeg
            ffmpegThread.Start();


        }

        private void OutputVideoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                // Solicitar la cancelación del hilo de FFmpeg
                cancellationTokenSource.Cancel();

                // Puedes mostrar un mensaje aquí si lo deseas
                MessageBox.Show("Proceso de conversión detenido.", "Detenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //// Detener el hilo si es necesario
            //if (cmdThread != null && cmdThread.IsAlive)
            //{
            //    cmdThread.Abort(); // Terminar el hilo
            //}

            //// Detener el proceso de CMD al hacer clic en el botón
            //if (cmdProcess != null && !cmdProcess.HasExited)
            //{
            //    cmdProcess.StandardInput.WriteLine("exit"); // Cerrar la ventana de CMD
            //    cmdProcess.WaitForExit(); // Esperar a que el proceso de CMD termine
            //    cmdProcess.Close(); // Cerrar el proceso de CMD
            //}
        }
    }
}