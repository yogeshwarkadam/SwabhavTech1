//import Bank,{Account,Customer} from './bank_module'
//let b = new Bank("hdfc","mumbai")
import *as b from './bank_module'
let a = new b.Account(2000)
let c = new b.Customer(2,"krishna")
console.log(a,c)