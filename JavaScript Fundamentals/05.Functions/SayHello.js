function solve(args) {
 let name = args[0];
 SayHello(name);

 function SayHello(name) {
    console.log("Hello, " + name + "!");
}
}


solve(["Pesho"]);