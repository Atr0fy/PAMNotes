namespace PAMNotes
{
    public partial class MainPage : ContentPage
    {
        string filePath = Path.Combine(FileSystem.AppDataDirectory,"Notes.txt");

        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
                NoteEditor.Text = File.ReadAllText(filePath);
            }
        }
        
        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            string texto = NoteEditor.Text;
            TextLabel.Text = "Arquivo foi salvo em: " + filePath;
            File.WriteAllText(filePath, texto);
            DisplayAlert("Alerta", "Arquivo salvo", "ok");
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            NoteEditor.Text = "";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                DisplayAlert("Alerta", "Arquivo deletado", "OK");
                NoteEditor.Text = string.Empty;
                TextLabel.Text = "";
            }
            else
            {
                DisplayAlert("Alerta", "Arquivo não encontrado", "OK");
            }
            TextLabel.Text = "";
        }
    }

}
