import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { CourseComponent } from './components/courses/courses.component';
import { StudentComponent } from './components/student/student.component';
import { EntrollmentComponent } from './components/entrollment/entrollment.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CourseComponent,
        HomeComponent,
        StudentComponent,
        EntrollmentComponent

    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'students', component: StudentComponent },
            { path: 'entrollments', component: EntrollmentComponent },
            { path: 'courses', component: CourseComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
