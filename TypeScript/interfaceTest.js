printDetails([
    { id: 101, firstName: 'yogeshwar', lastName: 'kadam' },
    { id: 102, firstName: 'akshay', lastName: 'wani', location: 'mumbai' },
]);
function printDetails(customers) {
    for (var c in customers) {
        console.log(c);
    }
}
