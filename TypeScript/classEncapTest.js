var Account = /** @class */ (function () {
    function Account(_accno, _name, _balance) {
        this._accno = _accno;
        this._name = _name;
        this._balance = _balance;
    }
    Object.defineProperty(Account.prototype, "balance", {
        get: function () {
            return this._balance;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Account.prototype, "accno", {
        get: function () {
            return this._accno;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Account.prototype, "name", {
        get: function () {
            return this._name;
        },
        enumerable: false,
        configurable: true
    });
    Account.prototype.Deposite = function (amount) {
        this._balance += amount;
    };
    return Account;
}());
var acc1 = new Account(101, "yogeshwar", 1000);
acc1.Deposite(2000);
console.log("balace is:" + acc1.balance);
console.log(acc1);
