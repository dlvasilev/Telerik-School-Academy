function grouped(person, property) {
    var array = new Array();
    for (var i = 0; i < person.length; i++) {

        for (var j in person[i]) {
            
            if (j==property) {
                array.push(person[i][j]);
            }
        }
    }
    
        var wordsCount = {};
        var word = {};
        for (var i in array) {
            word = array[i];
            if (wordsCount[word]) {
                wordsCount[word]++;
            }
            else {
                wordsCount[word] = 1;
            }
        }

        return wordsCount;  
}


var persons = [
    { firstName: "Joro", lastName: "Petrow", age: 16 },
    { firstName: "Ivan", lastName: "Ivanov", age: 16 },
    { firstName: "Ivan", lastName: "Borisov", age: 23 }
]

var groupedByAge = grouped(persons, "age");
var groupedByFirstName = grouped(persons, "firstName");

for (var i in groupedByAge) {
    jsConsole.writeLine(i+" => "+ groupedByAge[i]);
}
for (var i in groupedByFirstName) {
    jsConsole.writeLine(i+" => "+groupedByFirstName[i]);
}