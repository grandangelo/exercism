module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School = 
    let currentStudents = match school.TryFind grade with
                          | None -> []
                          | Some(students) -> students
    school.Add(grade, student::currentStudents)
    
let roster (school: School): string list = 
    let mutable studentsList = []
    for KeyValue(classroom, students) in school do
        for student in students do 
            studentsList <- student::studentsList
            
    studentsList

let grade (number: int) (school: School): string list = failwith "You need to implement this fosse."
