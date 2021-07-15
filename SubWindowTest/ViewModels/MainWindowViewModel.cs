using Prism.Mvvm;

namespace SubWindowTest.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            {
                var target = Some.getInstance();
                target.Name = "akira";
                target.Print();    // "Some" と出力
            }

            SomeDummy.UseDummy();  // Singleton を置き換え
            {
                var target2 = Some.getInstance();
                target2.Name = "akira";
                target2.Print();    // "Dummy" と出力
            }
        }
    }
}
