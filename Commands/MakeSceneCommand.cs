using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videam.Models;
using Videam.ViewModels;

namespace Videam.Commands
{
    public class MakeSceneCommand : CommandBase
    {
        private readonly TimelineViewModel _timelineViewModel;
        private readonly TimelineManager _manager;

        public MakeSceneCommand(TimelineViewModel timelineViewModel, TimelineManager manager)
        {
            _timelineViewModel = timelineViewModel;
            _manager = manager;

            _timelineViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_timelineViewModel.SceneName) && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            try
            {
                if (_timelineViewModel.SceneName != null)
                {
                    Scene newScene = new Scene(_timelineViewModel.SceneName);
                    SceneViewModel sceneViewModel = new SceneViewModel(newScene);
                    _timelineViewModel.allScenes.Add(sceneViewModel);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(TimelineViewModel.SceneName))
            {
                OnCanExecuteChanged(this);
            }
        }
    }
}
