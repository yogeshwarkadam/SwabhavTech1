import {Account,Bank,Customer} from './bank_module'

let a= new Account(1000)
let b = new Bank("icici","mumbai")
let c = new Customer(1,"yogeshwar")

console.log(a,b,c)
console.log({a,b,c})