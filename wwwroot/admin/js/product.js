const fileUploader = document.getElementById('file-uploader');

fileUploader.addEventListener('change', (event) => {
    const files = event.target.files;
    console.log('files', files);
});
