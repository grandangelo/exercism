module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School = 
    let currentStudents = match school.TryFind grade with
                          | None -> []
                          | Some(students) -> students
    school.Add(grade, student::currentStudents |> List.sort)
    
let roster (school: School): string list = 
    let mutable studentsList = []
    for KeyValue(classroom, students) in school do
        for student in students do 
            studentsList <- student::studentsList
            
    studentsList |> List.rev

let grade (number: int) (school: School): string list =
    match school.TryFind number with
    | None -> []
    | Some(students) -> students
