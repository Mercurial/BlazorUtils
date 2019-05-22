window.FileBrowseDialog = {
    DotNetInstance: null,
    Open: function (dotnetInstance) {
        console.log(dotnetInstance);
        FileBrowseDialog.DotNetInstance = dotnetInstance;
        var fileInputElement = document.createElement('input');
        fileInputElement.onchange = window.FileBrowseDialog.OnFileInputChange;
        fileInputElement.setAttribute('type', 'file');
        fileInputElement.style.display = "none";
        fileInputElement.click();
    },
    OnFileInputChange: function (e) {
        FileBrowseDialog.DotNetInstance.invokeMethodAsync("OnDialogClosed", e.target.value);
    }
};