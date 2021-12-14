function sayHello(name:string) : string{
    return `
             Hello mr ${name}
           `


}
console.log(sayHello("yogeshwar"));

let username:string = "yogeshwar";
let cgpa:number = 9.11;
let isActiveUser = true;
let displayText = `
                    showing user details:
                    name : ${username}
                    CGPA : ${cgpa}
                    IsActiveUser : ${isActiveUser}
                  `
console.log(displayText);