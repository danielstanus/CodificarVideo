# CodificarVideoStanus

Herramienta sencilla para la codificación de videos y la incrustación de subtítulos utilizando **FFmpeg** con aceleración por hardware de NVIDIA.

## 🚀 Características

- **Aceleración por Hardware**: Utiliza el codificador `h264_nvenc` de NVIDIA para un procesamiento rápido.
- **Subtítulos Personalizados**: Permite añadir subtítulos `.srt` con control sobre el tamaño de fuente y estilo.
- **Ajustes de Calidad**: Configuración de bitrate y presets de codificación.
- **Soporte de Idiomas**: Opciones rápidas para etiquetar videos en Rumano (_RO) o Español (_ES).
- **Modo Solo Conversión**: Opción de convertir el video sin añadir subtítulos.

## 📋 Requisitos

Para que la aplicación funcione correctamente, debes tener:

1. **FFmpeg instalado**: La aplicación busca el ejecutable en `C:\ffmpeg\ffmpeg.exe`. 
   - Puedes descargarlo desde [ffmpeg.org](https://ffmpeg.org/download.html).
2. **GPU NVIDIA**: Para utilizar el codificador `h264_nvenc`.

## 🛠️ Instalación y Uso

1. Clona este repositorio:
   ```bash
   git clone https://github.com/danielstanus/CodificarVideo.git
   ```
2. Abre el archivo `.sln` en **Visual Studio**.
3. Compila y ejecuta el proyecto.
4. Selecciona el archivo de video, el archivo de subtítulos y haz clic en **Convertir**.

## ⚙️ Parámetros por Defecto

- **Pad**: `3840:2160:0:280`
- **Tamaño de Fuente**: `18`
- **Bitrate**: `5M`
- **Preset**: `fast`
