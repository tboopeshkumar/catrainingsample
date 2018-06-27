import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'students',
    templateUrl: './student.component.html'
})
export class StudentComponent {
    public students: Student[] | undefined;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/Students').subscribe(result => {
            this.students = result.json() as Student[];
            console.dir(this.students);
        }, error => console.error(error));
    }
}

interface Student {
    ID: number,
    FirstName: string,
    LastName: string
}
