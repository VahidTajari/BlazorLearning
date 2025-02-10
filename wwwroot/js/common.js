window.ShowToastr = (type, message) => {
    toastr.options.toastClass = "toastr";
    if (type === "success") {
        toastr.success(message, "Operation Successfull", { timeout: 20000 });
    }
    if (type === "error") {
        toastr.error(message, "Operation failed", { timeout: 20000 });
    }
};