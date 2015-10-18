function getCloneOfObject(oldObject) {
    var tempClone = {};

    if (typeof oldObject!="object") {
        tempClone = oldObject;
    }

    if (typeof oldObject=="array") {
        for (var arrIndex = 0; arrIndex <= oldArray.length; arrIndex++)
            if (typeof (oldArray[arrIndex]) == "object")
                tempClone.push(this.getCloneOfObject(oldArray[arrIndex]));
            else
                tempClone.push(oldArray[arrIndex]);
    }

    else if (typeof (oldObject) == "object")
        for (prop in oldObject)
             if (typeof (oldObject[prop]) == "object")
                tempClone[prop] = this.getCloneOfObject(oldObject[prop]);
            else
                tempClone[prop] = oldObject[prop];
    
    return tempClone;
}

var obj = {
    point: {
        x: -2,
        y: 1
    },
    point2: {
        x: 1,
        y: 5
    }
};
var number = 8;
var numbers = [1, 2, 3, 4, 5];


var numbersCopy = getCloneOfObject(numbers);
for (var i = 0; i < numbers.length; i++) {
    numbersCopy[i]++;
    jsConsole.write(numbersCopy[i]);
}
jsConsole.writeLine("");
for (var i = 0; i < numbers.length; i++) {
    jsConsole.write(numbers[i]);
}
jsConsole.writeLine("");

var numberCopy = getCloneOfObject(number);
numberCopy++;

jsConsole.writeLine(numberCopy);
jsConsole.writeLine(number);


var objCopy = getCloneOfObject(obj);
objCopy.point.x = 7;

jsConsole.writeLine(objCopy.point.x);
jsConsole.writeLine(obj.point.x);