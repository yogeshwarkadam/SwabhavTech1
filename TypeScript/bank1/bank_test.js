"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var bank_module_1 = require("./bank_module");
var a = new bank_module_1.Account(1000);
var b = new bank_module_1.Bank("icici", "mumbai");
var c = new bank_module_1.Customer(1, "yogeshwar");
console.log(a, b, c);
console.log({ a: a, b: b, c: c });
