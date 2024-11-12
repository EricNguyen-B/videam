using System.Collections.ObjectModel;
using System.Windows.Input;
using Videam.Commands;
using Videam.Models;

namespace Videam.ViewModels
{
    public class TimelineViewModel : ViewModelBase
    {
        public ICommand MakeSceneCommand { get; }

        private string? _sceneName = "Enter Scene Name";
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

        private int _width;
        public int width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                OnPropertyChanged(nameof(_width));  
            }
        }

        private ObservableCollection<SceneViewModel> _allScenes = new ObservableCollection<SceneViewModel>();
        public ObservableCollection<SceneViewModel> allScenes
        {
            get
            {
                return _allScenes;
            }
            set
            {
                _allScenes = value;
                OnPropertyChanged(nameof(allScenes));
            }
        }

        public TimelineViewModel()
        {
            TimelineManager manager = new TimelineManager();
            MakeSceneCommand = new MakeSceneCommand(this, manager);
        }
    }
}
