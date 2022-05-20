Window.onload = basicFunction();

function basicFunction()
{
    console.log("JS working");
}
// named function


var anonymous = function()
{
    console.log("JS working");
};
// anonymous function (single use only, created and called once)


var arrowFunction = () => console.log("JS Working");
//  arrow notation w/ lambda expression


(() => console.log("JS Working"))();
// IIFE (immediately invoked


function prototypeFunction()
{
    prototypeFunction.prototype.Name = "something";
    prototypeFunction.prototype.Id = "something";
    console.log(prototypeFunction.prototype);
}
// prototype function


function greeting(name)
{
    console.log("Hello " + name);
}

function Input(greeting)
{
    debugger;
    var name = prompt("Please enter your name ");
    greeting(name);
}

// callback function
// enable debugging


let li = document.getElementById("anonymous");
li.onclick = function()
{
    console.log("calling anonymous method");
}



let pokemon = {};

let pokeName = document.getElementById("pokemonName").value;

let request = new XMLHttpRequest();

// request.open();