using CommunityToolkit.Mvvm.Input;
using holaMundo.Models;

namespace holaMundo.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}