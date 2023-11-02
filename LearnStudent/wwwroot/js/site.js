

function openNav() {
    
    document.getElementById("mySidebar").style.width = "250px";

}

function closeNav() {
    document.getElementById("mySidebar").style.width = "0";
}


document.querySelectorAll('.dropdown').forEach(function (dropDownWrapper) {
    const dropDownBtn = dropDownWrapper.querySelector('.dropdown .levels');
    const dropDownContent = dropDownWrapper.querySelector('.dropdown-content');

    dropDownBtn.addEventListener('click', function (e) {
        e.preventDefault();
        dropDownContent.classList.toggle('show');
    });
});

document.querySelectorAll('.dropdown2').forEach(function (dropDownWrapper) {
    const dropDownBtn = dropDownWrapper.querySelector('.dropdown2 .levels');
    const dropDownContent = dropDownWrapper.querySelector('.dropdown-content2');

    dropDownBtn.addEventListener('click', function (e) {
        e.preventDefault();
        dropDownContent.classList.toggle('show');
    });
});
