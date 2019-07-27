namespace MigracionGym.UI.Forms.ViewModels.Infrastucture
{
    public class InstanceLocator
    {

    public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
