interface Icustomer{
    id : number,
    firstName : string,
    lastName : string,
    location ? : string
}
printDetails
([
    {id:101,firstName:'yogeshwar',lastName:'kadam'},
    {id:102,firstName:'akshay',lastName:'wani',location:'mumbai'},

])
function printDetails(customers:Array<Icustomer>)
{
    for (let c in customers){
        console.log(c)
    }

}