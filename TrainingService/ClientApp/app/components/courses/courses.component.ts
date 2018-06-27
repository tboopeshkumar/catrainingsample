import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'courses',
    templateUrl: './courses.component.html'
})
export class CourseComponent {
    public courses: Course[] = [];
    public title: string = '';
    public credits: number = -1;
    public httpLocal: Http;
    public baseUrlLocal: string;
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.httpLocal = http;
        this.baseUrlLocal = baseUrl;
        http.get(baseUrl + 'api/SampleData/Courses').subscribe(result => {
            this.courses = result.json() as Course[];
            console.dir(this.courses);
        }, error => console.error(error));
    }

    OnAddCourse = (event: any) => {
        this.httpLocal.post(this.baseUrlLocal + 'api/SampleData/AddCourse', JSON.stringify({ title: this.title, credits: this.credits }) ).subscribe(result => {
            this.courses.push({ courseID : -1, title : this.title, credits : this.credits });
            this.credits = -1;
            this.title = '';
            
        }, error => console.error(error));
    }
}

interface Course {
    courseID: number,
    title: string,
    credits: number
}
