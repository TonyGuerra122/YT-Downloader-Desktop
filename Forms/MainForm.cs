using System.Runtime.InteropServices;
using YTDownloaderDesktop.Services;

namespace YTDownloaderDesktop;

public partial class MainForm : Form
{
    private readonly YTService YTService;
    public MainForm()
    {
        YTService = new YTService();
        InitializeComponent();
    }

    private void CloseFormAction(object sender, EventArgs e) => Application.Exit();

    private void MinimizeFormAction(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

    private async void WriteUrlAction(object sender, EventArgs e)
    {
        var url = TBUrl.Text;

        if (string.IsNullOrEmpty(url)) return;

        PBLoader.Visible = true;

        var videoInfo = await YTService.GetVideoInformation(url);

        PBLoader.Visible = false;

        if (videoInfo == null) return;

        PBThumb.Image = videoInfo.Value.Thumb;
        PBThumb.Visible = true;

        LabelVideoName.Text = "Título: " + videoInfo.Value.Title;
        LabelVideoName.Visible = true;

        LabelVideoDuration.Text = "Duração: " + videoInfo.Value.Duration.ToString();
        LabelVideoDuration.Visible = true;

        BtnDownload.Visible = true;
    }

    private async void BtnDownloadAction(object sender, EventArgs e)
    {
        var url = TBUrl.Text;

        if (string.IsNullOrEmpty(url)) return;

        BtnDownload.Visible = false;

        PBLoader.Visible = true;

        try
        {
            await YTService.DownloadVideo(url, false);

            MessageBox.Show("Download feito com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            PBLoader.Visible = false;
            PBThumb.Visible = false;
            LabelVideoName.Visible = false;
            LabelVideoDuration.Visible = false;
            TBUrl.Clear();
        }
    }

    [LibraryImport("user32.dll", EntryPoint = "ReleaseCapture")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static partial bool ReleaseCapture();

    [LibraryImport("user32.dll", EntryPoint = "SendMessageA")]
    private static partial int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

    public const int WM_NCLBUTTONDOWN = 0xA1;

    public const int HTCAPTION = 0x2;

    private void MouseDownAction(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();

            _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
