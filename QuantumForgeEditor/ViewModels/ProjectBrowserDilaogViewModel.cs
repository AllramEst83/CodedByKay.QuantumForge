using System.ComponentModel;
using System.Windows.Input;

namespace QuantumForgeEditor.ViewModels
{
    public class ProjectBrowserDilaogViewModel : INotifyPropertyChanged
    {
        private bool _isCreateProjectVisible;

        public ProjectBrowserDilaogViewModel()
        {
            _isCreateProjectVisible = true;
            ToggleCommand = new RelayCommand(ToggleVisibility);
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
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Func<object?, bool>? _canExecute;

        public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute(parameter);

        public void Execute(object? parameter) => _execute(parameter);

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
