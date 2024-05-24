namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "Nuestro cerebro es como un procesador";
    public string PersonalDescription => "Me refiero a que yo puedo realizar muchas cosas gracias a mi cerebro" +
        ", ya que es como un prpcesador de una computadora capaz de realizar cualquier actividad que me proponga";
}