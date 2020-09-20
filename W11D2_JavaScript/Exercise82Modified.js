
var name = "";
var done = false;

function ValidatesFoodItemLength(){
    while(!done){
        userInput = foodItemInput();
        if(isTooShort(userInput)){
            alert("Your entry might be too short.")
        }else{
            done = true;
        }
    }
}

function foodItemInput(){
    prompt("Type in a food item.");
}
function foodPrice(){
   prompt("Type food price.");
}
function isTooShort(name){
    return name.length<=1;
}