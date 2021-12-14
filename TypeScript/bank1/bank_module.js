"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Customer = exports.Account = exports.Bank = void 0;
var Bank = /** @class */ (function () {
    function Bank(name, location) {
        this.name = name;
        this.location = location;
    }
    return Bank;
}());
exports.Bank = Bank;
var Account = /** @class */ (function () {
    function Account(balance) {
        this.balance = balance;
    }
    return Account;
}());
exports.Account = Account;
var Customer = /** @class */ (function () {
    function Customer(custid, firstName) {
        this.custid = custid;
        this.firstName = firstName;
    }
    return Customer;
}());
exports.Customer = Customer;
