  /* This assigns the element with id 'buttonId' to 'btn' */
var btn = document.getElementById('btn');

/* This sets the action to perform on a click event */
btn.addEventListener("click", function() {
    /* This changes the button's label */
    let num = Number(btn.innerHTML);
    
    btn.innerHTML = num + 1;
});
