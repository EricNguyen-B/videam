using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Videam.ViewModels
{
    public class TimelineViewModel : ViewModelBase
    {
        private string? _sceneName;
        private ObservableCollection<SceneViewModel> _allScenes = new ObservableCollection<SceneViewModel>();
        
        //public ICommand AddSceneCommand { get; }

        public string? SceneName
        {
            get
            {
                return _sceneName;
            }
            set
            {
                _sceneName = value;
                OnPropertyChanged(nameof(SceneName));
            }
        }

        public ObservableCollection<SceneViewModel> AllScenes
        {
            get
            {
                return _allScenes;
            }
            set
            {
                _allScenes = value;
                OnPropertyChanged(nameof(AllScenes));
            }
        }
    }

    class Updater : ICommand
    {
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
