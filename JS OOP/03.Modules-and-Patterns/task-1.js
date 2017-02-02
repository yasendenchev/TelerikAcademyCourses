/* Task Description */
/* 
* Create a module for a Telerik Academy controls
  * The controls has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the controls
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the controls
  * Create method init
    * Accepts a string - controls title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the controls
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the controls
*/

function solve() {
  'use strict';

  var Course = {

    init: function (title, presentations) {
      if (title[0] === " " || title[title.length - 1] === " " || title.includes("  ") || title.length === 0) {
        throw Error;
      }

      if (presentations.length === 0 || presentations === undefined) {
        throw Error
      }

      for (var i = 0; i < presentations.length; i++) {
        if (presentations[i][0] === " " || presentations[i][presentations[i].length - 1] === " " || presentations[i].includes("  ") || presentations[i].length === 0) {
          throw Error;
        }
      }

      this.students = [];
      this.title = title;
      this.presentations = presentations;

      return this;

    },

    addStudent: function (name) {
      let names = name.split(' ');
      if (names.length != 2) {
        throw Error;
      }
      for (let i = 0; i < names.length; i++) {
        if (names[i][0] != names[i][0].toUpperCase()) {
          throw Error;
        }
      }
      let id = this.students.length + 1;
      this.students.push({
        firstname: names[0],
        lastname: names[1],
        id: id
      });
      return id;
    },

    getAllStudents: function () {
      return this.students;
    },

    submitHomework: function (studentID, homeworkID) {

      let studentIsValid = false;
      let homeworkIsValid = false;

      for (let i = 0; i < this.presentations.length; i++) {
        if (homeworkID === this.presentations.indexOf(this.presentations[i]) + 1) {
          homeworkIsValid = true;
        }
      }

      for (let i = 0; i < this.students.length; i++) {
        if (studentID === this.students[i].id) {
          studentIsValid = true;
          if (!this.students[i].hasOwnProperty('homeworks')) {
            this.students[i]["homeworks"] = [];
          }
          this.students[i].homeworks.push(homeworkID);
        }
      }
      if (studentIsValid === false || homeworkIsValid === false) {
        throw Error;
      }
    },

    pushExamResults: function (results) {

      let sortedArr = [...results].sort(this.pushExamResults.compare);


      for (let i = 0; i < results.length; i++) {

        if (i < results.length - 1 && sortedArr[i].StudentID === sortedArr[i + 1].StudentID) {
          throw "There are duplicate IDs";
        }
        if (results[i].StudentID < 1) {
          throw "Invalid ID";
        }
        if (results[i].score === null) {
          throw "Score is null";
        }
        if (results[i].score === undefined) {
          throw "Score is undefined";
        }
        if (isNaN(results[i].score)) {
          throw "Score is NaN";
        }
        if (isNaN(results[i].StudentID)) {
          throw "ID is NaN";
        }

        for (let j = 0; j < this.students.length; j++) {
          if (this.students[j].id === results[i].StudentID) {
            if (!this.students[i].hasOwnProperty('score')) {
              this.students[j]['score'] = results[i].score;
            }
          }
        }
      }
      // Function to compare objects by property studentID
      function compare(result1, result2) {
        if (result1.StudentID < result2.StudentID) {
          return -1;
        }
        if (result1.StudentID > result2.StudentID) {
          return 1;
        }
        return 0
      }

    },

    getTopStudents: function () {

      if (this.students.length < 10) {
        this.students.sort(this.getTopStudents.compare);
        return this.students;
      }

      for (let i = 0; i < this.students.length; i++) {
        this.students[i]['finalscore'] = CalculateScore(this.students[i].score, this.students[i].homework.length)
      }

      this.students.sort(this.getTopStudents.compare);
      return this.students;


      // Function to calculate final score
      function CalculateScore(score, homeworkCount) {
        let submittedHW = homeworkCount / this.presentations.length;
        let result = score * 3 + submittedHW;
      }

      // Function to compare objects by property finalscore
      function compare(student1, student2) {
        if (student1.finalscore < student2.finalscore) {
          return -1;
        }
        if (student1.finalscore > student2.finalscore) {
          return 1;
        }
        return 0
      }
    }
  }
  return Course;
}
module.exports = solve;
