		//Shim Object.create if the browser dont have it
		if(!Object.create){
			Object.create = function(obj){
				function f(){};
				f.prototype = obj;
				return new f();    
			}
		}
		//Add Object.extend()
		Object.prototype.extend = function(properties) {
			function f() {};
			f.prototype = Object.create(this);
			for (var prop in properties) {
				f.prototype[prop] = properties[prop];
			}
			f.prototype._super = this;
			return new f();
		}


		var School = {
			init: function(name,town,classes){
				this.name = name;
				this.town = town;
				this.classes = classes;
			},
			classesStr: function(){
				this.cStr = "";
				for(var i=0;i<this.classes.length;i++){
					if(i > 0) this.cStr += ", ";
					this.cStr += this.classes[i];
				}
				return this.cStr;
			},
			schoolInfo: function(){
				return "Name: "+this.name+", Town: "+this.town+", Classes: "+this.classesStr();
			}
		};

		var Person = {
			init: function(fname,lname,age,school){
				this.fname = fname;
				this.lname = lname;
				this.age = age;
				this.school = school;
			},
			fullname: function(){
				return this.fname+" "+this.lname;
			}
		};

		var Teacher = Person.extend({
			spec: function(speciality){
				this.spec = speciality;
				return this.spec;
			},
			introduce: function(){
				return "Name: "+this.fullname()+", Age: "+this.age+", Speciality: "+this.spec;
			}
		});

		var Student = Person.extend({
			grade: function(g){
				this.grade = g;
				return this.grade;
			},
			introduce: function(){
				return "Name: "+this.fullname()+", Age: "+this.age+", Grade: "+this.grade;
			}
		});


		//DEMO

		//initalize new school
		console.log("School: ");
		var pmg = Object.create(School);
		var pmgclasses = [5,6,7,8,9,10,11,12];
		pmg.init("PMG","Montana",pmgclasses);
		console.log(pmg.schoolInfo());

		//initalize two new students
		console.log("Students: ");
		var dani = Object.create(Student);
		dani.init("Daniel", "Vasilev", 18, pmg);
		dani.grade(11);
		console.log(dani.introduce());

		var ivan = Object.create(Student);
		ivan.init("Ivan", "Georgiev", 18, pmg);
		ivan.grade(11);
		console.log(ivan.introduce());

		console.log("Teachers: ");
		//initalize two new teachers
		var dora = Object.create(Teacher);
		dora.init("Dora", "Stoqnova", 48, pmg);
		dora.spec("Math");
		console.log(dora.introduce());

		var krasi = Object.create(Teacher);
		krasi.init("Krasimir", "Asenov", 54, pmg);
		krasi.spec("IT");
		console.log(krasi.introduce());
