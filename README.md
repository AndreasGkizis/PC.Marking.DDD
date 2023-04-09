# PC.Marking.DDD

## Things considered 

 1. An Exam is always auto-marked
 2. An Exam can be re-manual-marked
	1. A history of previous marks must be preserved
	2. The history must be eponymnous 
 3. A Question is multiple choice styled
 4. A question can have more than one correct Options


 ## Things to check

 1. How to manage Questions with more than one correct answer
	1. Is a simple True/False enough to mark a question? <br/>
 ( what is they select 1/2 correct choices?)
	2. should points be awarded instead for each question?
 2. Should the marker know when each Exam was assigned to them?
	1. Will there be a custom time interval to mark diferent exams ?<br/>
	( can be solved with an added field in the UnmarkedExamDTO.cs
	2. Should this handle non-multiple choice Exams as well ?

