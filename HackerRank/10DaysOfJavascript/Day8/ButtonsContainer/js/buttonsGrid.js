var btn5 = document.getElementById('btn5');

btn5.addEventListener("click", function () {
    let btn1Text = document.getElementById('btn1').innerHTML;
    let btn2Text = document.getElementById('btn2').innerHTML;
    let btn3Text = document.getElementById('btn3').innerHTML;
    let btn4Text = document.getElementById('btn4').innerHTML;
    let btn6Text = document.getElementById('btn6').innerHTML;
    let btn7Text = document.getElementById('btn7').innerHTML;
    let btn8Text = document.getElementById('btn8').innerHTML;
    let btn9Text = document.getElementById('btn9').innerHTML;

    document.getElementById('btn1').innerHTML = btn4Text;
    document.getElementById('btn2').innerHTML = btn1Text;
    document.getElementById('btn3').innerHTML = btn2Text;
    document.getElementById('btn4').innerHTML = btn7Text;
    document.getElementById('btn6').innerHTML = btn3Text;
    document.getElementById('btn7').innerHTML = btn8Text;
    document.getElementById('btn8').innerHTML = btn9Text;
    document.getElementById('btn9').innerHTML = btn6Text;
});