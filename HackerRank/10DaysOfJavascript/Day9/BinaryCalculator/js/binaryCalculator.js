class Calculator {
    constructor() {
        this.operand1 = '';
        this.operand2 = '';
        this.isOperand1 = true;
        this.operator = '';
        this.display = '';
    }

    pushNumber(num) {
        if (this.isOperand1) {
            this.operand1 += num;
        } else {
            this.operand2 += num;
        }

        this.display += num;
    }

    changeOperand() {
        this.isOperand1 = !this.isOperand1;
    }

    addOperator(operator) {
        this.operator = operator;

        this.display += operator;
        this.changeOperand();
    }

    calculate() {
        var operand1Decimal = parseInt(this.operand1, 2);
        var operand2Decimal = parseInt(this.operand2, 2);

        var result;

        switch (this.operator) {
            case '+':
                result = operand1Decimal + operand2Decimal;
                break;
            case '-':
                result = operand1Decimal - operand2Decimal;
                break;
            case '*':
                result = operand1Decimal * operand2Decimal;
                break;
            case '/':
                result = operand1Decimal / operand2Decimal;
                break;

            default:
                result = operand1Decimal;
                break;
        }

        this.display = result.toString(2);
        this.operand1 = result.toString(2);
        this.operand2 = '';
        this.isOperand1 = true;
        this.operator = '';
    }
}

var calculator = new Calculator();
var res = document.getElementById('res');

document.getElementById("btn0").addEventListener("click", () => {
    calculator.pushNumber('0');
    res.innerHTML = calculator.display;
}, false);

document.getElementById("btn1").addEventListener("click", () => {
    calculator.pushNumber('1');
    res.innerHTML = calculator.display;
}, false);

document.getElementById("btnClr").addEventListener("click", () => {
    calculator = new Calculator();
    res.innerHTML = calculator.display;
}, false);

document.getElementById("btnEql").addEventListener("click", () => {
    calculator.calculate();
    res.innerHTML = calculator.display;
}, false);

document.getElementById("btnSum").addEventListener("click", () => {
    calculator.addOperator('+');
    res.innerHTML = calculator.display;
}, false);

document.getElementById("btnSub").addEventListener("click", () => {
    calculator.addOperator('-');
    res.innerHTML = calculator.display;
}, false);

document.getElementById("btnMul").addEventListener("click", () => {
    calculator.addOperator('*');
    res.innerHTML = calculator.display;
}, false);

document.getElementById("btnDiv").addEventListener("click", () => {
    calculator.addOperator('/');
    res.innerHTML = calculator.display;
}, false);