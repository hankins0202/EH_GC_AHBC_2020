const calculatorGrid = document.querySelector('.calculator_grid')
const calculatorDisplay = document.querySelector('.calc_display')
const calculatorButtons = calculatorGrid.querySelector('.calc_buttons')
let firstValue = calculatorGrid.dataset.firstValue
let secondValue = calculatorGrid.dataset.secondValue
let operator

calculatorButtons.addEventListener('click',event=>{
    if(event.target.matches('button')){
        const button = event.target
        const buttonContent = button.textContent
        const action = button.dataset.action
        determineAction(action, buttonContent)
    }
});
function determineAction(action, buttonContent){
    
    if(!action){
        console.log("Number pressed")
        calculatorDisplay.textContent = buttonContent
        secondValue= buttonContent
    }else{
        if(action === 'add' || action === 'subtract'|| action === 'multiply'|| action === 'dvide'){
            firstValue = calculatorDisplay.textContent
            operator = action
        }
        if(action==='equals'){
            calculatorDisplay.textContent = compute(parseFloat(firstValue), parseFloat(secondValue), operator)
        }
    }
}

function compute(firstValue, secondValue, operator){
    let result = 0;
    switch(operator){
        case 'add' :
            result = firstValue + secondValue
            break;
        case 'subtract' :
            result = firstValue - secondValue
            break;
        case 'divide' :
            result = firstValue / secondValue
            break;
        case 'multiply' :
            result = firstValue * secondValue
            break
    }
    return result
}
