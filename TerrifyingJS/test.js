//Your basic module. Nothing fancy, really just for namespacing...
var SomeFuncModule = {

    someFunc : function(x){
        var wha = 2;
        return function(x){
            return x*x*wha;
        };
    },
};

var SquareFuncModule = {
    // Square returns a func too, but it's immediately invoked when the module loads;
    // it returns its result rather than the actual function that produced the result
    square: (function(x){
        var someVal = 3;
        return function(x){
            return x*x + someVal; 
        }
    }()),   
};

(function(){
    var x;
    x = 'I is a string!';
    var that = this;
})(this);

// We can call someFunc like this...
console.log(SomeFuncModule.someFunc()(3));

// Or set its return to some variable and invoke it normally
var aFunc = SomeFuncModule.someFunc();
console.log(aFunc(3));

// Square is actually invoked when the module loads
console.log(SquareFuncModule.square(3));

function Derp(){
    var herpDerp = "herp a derp";

    (function (){
        console.log(this);
        console.log(this.herpDerp);
    })();

    (function (){
        console.log(this);
        console.log(herpDerp);
    }).call(this);
}

var herp = new Derp;

var SomeClass = L.Class.extend({
    
    initialize: function(someVal){
        this.val = someVal;
    },

    printVal: function(){
        console.log(this.val);
    }
});

var myClass = new SomeClass('YAY');
myClass.printVal();