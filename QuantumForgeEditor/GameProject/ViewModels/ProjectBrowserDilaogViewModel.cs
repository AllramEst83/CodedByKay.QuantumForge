using QuantumForgeEditor.Commands;
using QuantumForgeEditor.GameProject.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace QuantumForgeEditor.ViewModels
{
    public class ProjectBrowserDilaogViewModel : INotifyPropertyChanged
    {
        private bool _isCreateProjectVisible;
        private string _selectedProjectType;

        public ProjectBrowserDilaogViewModel()
        {
            _isCreateProjectVisible = true;
            ToggleCommand = new ProjectBrowserRelayCommand(ToggleVisibility);

            ProjectTypes =
            [
                new ProjectType { Name = "First Person Game", ImagePath = "pack://application:,,,/GameProject/Resources/first_person.jpeg" },
                new ProjectType { Name = "Third Person Game", ImagePath = "pack://application:,,,/GameProject/Resources/third_person.jpeg" },
                new ProjectType { Name = "Top Down Game", ImagePath = "pack://application:,,,/GameProject/Resources/top_down.jpeg" }
            ];
        }

        public bool IsCreateProjectVisible
        {
            get => _isCreateProjectVisible;
            set
            {
                if (_isCreateProjectVisible != value)
                {
                    _isCreateProjectVisible = value;
                    OnPropertyChanged(nameof(IsCreateProjectVisible));
                    OnPropertyChanged(nameof(IsOpenProjectVisible));
                }
            }
        }

        public bool IsOpenProjectVisible => !IsCreateProjectVisible;

        public string SelectedProjectType
        {
            get => _selectedProjectType;
            set
            {
                if (_selectedProjectType != value)
                {
                    _selectedProjectType = value;
                    OnPropertyChanged(nameof(SelectedProjectType));
                }
            }
        }

        public ICommand ToggleCommand { get; }

        private void ToggleVisibility(object? parameter)
        {
            if (parameter is string commandParameter)
            {
                IsCreateProjectVisible = commandParameter == "Create";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<ProjectType> ProjectTypes { get; }
    }
}
