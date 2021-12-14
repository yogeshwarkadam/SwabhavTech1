"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
//import Bank,{Account,Customer} from './bank_module'
//let b = new Bank("hdfc","mumbai")
var b = require("./bank_module");
var a = new b.Account(2000);
var c = new b.Customer(2, "krishna");
console.log(a, c);
