class Student
{
    constructor(public firstName:string,public lastName:string){

    }
    get FullName(){
        return `${this.firstName} - ${this.lastName}`
    }
    set fullName(value:string){
       let values:string[] = value.split("")
       console.log(values)
       this.firstName = values[0]
       this.lastName = values[1]
    }
}
let s1 = new Student("yogesh","kadam")
console.log(s1)
s1.firstName = "YOGESH"
console.log(s1)
console.log(s1.FullName)

s1.fullName = "Rahul Dravid"
console.log(s1)
