
//function downloadFile(fileName, base64String) {
//    console.log('downloadFile function called with:', fileName, base64String);
    //var fileDataUrl = "data:" + fileType + ";base64," + base64String;
    //fetch(fileDataUrl)
    //    .then(response => response.blob())
    //    .then(blob => {

    //        var link = window.document.createElement("a");
    //        link.href = window.URL.createObjectURL(blob, { type: fileType });
    //        link.download = fileName;

    //        document.body.appendChild(link);
    //        link.click();
    //        document.body.removeChild(link);
    //    });
//    var link = document.createElement('a');
//    link.download = fileName;
//    link.href = 'data:application/vnd.openxmlformats-officedocument.wordprocessingml.document;base64' + base64String;
//    document.body.appendChild(link);
//    link.click();
//    document.body.removeChild(link);

//}

function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}