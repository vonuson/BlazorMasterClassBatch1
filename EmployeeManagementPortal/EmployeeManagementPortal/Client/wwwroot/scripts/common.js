window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Success");
    }
    if (type === "error") {
        toastr.error(message, "Error");
    }

    if (type === "info") {
        toastr.info(message, "Info");
    }

    if (type === "warning") {
        toastr.warning(message, "Warning");
    }

    if (type === "clear") {
        toastr.clear();
    }
}

window.startRandomGenerator = (dotNetObject) => {
    return setInterval(function () {
        let text = Math.random() * 1000;
        console.log("JS: Generated " + text);
        dotNetObject.invokeMethodAsync('AddText', text.toString());
    }, 1000);
};

window.stopRandomGenerator = (handle) => {
    clearInterval(handle);
}

window.runStaticMethod = () => {
    DotNet.invokeMethodAsync("EmployeeManagementPortal.Client", "OurInvokableDotNetMethod", "FirstValue");
    DotNet.invokeMethodAsync("EmployeeManagementPortal.Client", "OurInvokableDotNetMethod", 200);
}