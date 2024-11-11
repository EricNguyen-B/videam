using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videam.Models;

namespace Videam.ViewModels
{
    public class SceneViewModel : ViewModelBase
    {
        public SceneViewModel(Scene scene)
        {
            _name = scene.Name;
        }
        
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }
    }
}
