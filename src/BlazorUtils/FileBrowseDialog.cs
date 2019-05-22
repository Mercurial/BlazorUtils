using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorUtils
{
    public class FileBrowseDialog
    {
        private IJSRuntime JSRuntime { get; set; }

        public event EventHandler<FileDialogClosedEventArgs> DialogClosed;

        public FileBrowseDialog(IJSRuntime runtime)
        {
            JSRuntime = runtime;
        }

        public void Open()
        {
            JSRuntime.InvokeAsync<object>("FileBrowseDialog.Open", new DotNetObjectRef(this));
        }

        [JSInvokable]
        public void OnDialogClosed(string path)
        {
            DialogClosed?.Invoke(null, new FileDialogClosedEventArgs(path));
        }
    }
}
