namespace Notes;

public partial class NotesPage : ContentPage
{
	// c:/Usuarios/arquivo.extensao
	// com.whatsapp.media
	// com.meta.instagram.media
	//acima, sao os pacotes dos apps

	string path = Path.Combine(FileSystem.AppDataDirectory, "file.txt");
	string text = "";
	public NotesPage()
	{
		InitializeComponent();
		if (File.Exists(path))
		{
         FileEditor.Text = File.ReadAllText(path);
        }
	}
	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		//Pegar o texto escrito no editor de texto
		//Armazenar esse texto em uma váriavel
		text = FileEditor.Text;
        //Criar um arquivo com esse conteúdo
        File.WriteAllText(path, text);
        DisplayAlert("Sucesso", "Arquivo Salvo com sucesso", "Ok");
    }

	private void DeleteButton_Clicked(Object sender, EventArgs e)
	{
		if (File.Exists(path)) { }
		File.Delete(path);
	}
}