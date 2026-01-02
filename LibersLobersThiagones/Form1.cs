namespace LibersLobersThiagones;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void gerarButton_Click(object sender, EventArgs e)
    {
        GeradorCodinomeService geradorCodinomeService = new();
        string nome = geradorCodinomeService.GerarCodinome();

        richTextBox1.Visible = true;
        progressBarPensando.Visible = true;

        await Task.Delay(3500);

        richTextBox1.Visible = false;

        string mensagemConvite = $"Bora jogar um {nome}?";
        MessageBox.Show(mensagemConvite, "Convite", MessageBoxButtons.OK, MessageBoxIcon.Information);

        Clipboard.SetText(mensagemConvite);

        progressBarPensando.Visible = false;
    }
}