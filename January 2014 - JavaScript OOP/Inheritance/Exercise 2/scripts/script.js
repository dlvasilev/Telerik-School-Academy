		function School(name, town, classes){
			this.name = name;
			this.town = town;
			this.classes = classes;
			this.classesStr = "";

			var n = 0;
			for(c in classes){
				if(n > 0) this.classesStr += ", ";
				this.classesStr += classes[c];
				n++
			}

			this.schoolInfo = function(){
				return "School Name: "+this.name+", Town: "+this.town+", Classes: "+this.classesStr;
			}
		}

		function Person(fname,lname,age,school){
			this.fname = fname;
			this.lname = lname;
			this.age = age;
			this.school = school;
			this.fullname = fname+" "+lname;
		}

		function Student(fname,lname,age,school,grade){
			Person.call(this, fname, lname, age,school);

			this.grade = grade;
			this.introduce = function(){
				return "Name: "+this.fullname+", Age: "+this.age+", Grade: "+this.grade;
			}
		}
		Student.prototype = new Person();
		Student.prototype.constructor = Student;


		function Teacher(fname,lname,age,school,spec){
			Person.call(this, fname, lname, age,school);

			this.speciality = spec;
			this.introduce = function(){
				return "Name: "+this.fullname+", Age: "+this.age+", Speciality: "+this.speciality;
			}
		}
		Teacher.prototype = new Person();
		Teacher.prototype.constructor = Teacher;

		//DEMO

		//new school
		console.log("School: ");
		var pmgclasses = [5,6,7,8,9,10,11,12];
		var pmg = new School("PMG","Montana", pmgclasses);
		console.log(pmg.schoolInfo());

		//two new students and introducing
		console.log("Students: ");
		var dani = new Student("Daniel","Vasilev",18,pmg,11);
		console.log(dani.introduce());
		var ivan = new Student("Ivan","Georgiev",18,pmg,11);
		console.log(ivan.introduce());

		//two new teachers and introducing
		console.log("Teachers: ");
		var dora = new Teacher("Dora","Stoqnova",48,pmg,"Math");
		console.log(dora.introduce());
		var krasi = new Teacher("Krasimir","Asenov",53,pmg,"IT");
		console.log(krasi.introduce());