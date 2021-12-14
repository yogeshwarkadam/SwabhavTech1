class Account{
    constructor(private _accno:number,private _name:string,private _balance:number){

    }
    get balance()
    {
        return this._balance;
    }
    get accno()
    {
        return this._accno;
    }
    get name()
    {
        return this._name;
    }
    Deposite(amount){
        this._balance += amount;
    }
   
}
let acc1 = new Account(101,"yogeshwar",1000);
acc1.Deposite(2000);
console.log("balace is:" +acc1.balance);
console.log(acc1);