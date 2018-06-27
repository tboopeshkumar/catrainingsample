import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'entrollments',
    templateUrl: './entrollment.component.html'
})
export class EntrollmentComponent {
    public entrollments: Entrollment[] | undefined;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/Entrollments').subscribe(result => {
            let tempValue = result.json();
            
            this.entrollments = tempValue as Entrollment[];
            console.dir(this.entrollments);
        }, error => console.error(error));
    }
}

interface Course {
    CourseID: number,
    title: string,
    credits: number
}

interface Student {
    ID: number,
    firstName: string,
    lastName: string
}

interface Entrollment {
    enrollmentID: number,
    student: Student,
    course : Course
}
