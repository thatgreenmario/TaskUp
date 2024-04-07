import { Routes } from '@angular/router';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { SigninPageComponent } from './signin-page/signin-page.component';

export const routes: Routes = [
    {
        path: '',
        title: 'TaskUp',
        component: LandingPageComponent 
    },
    {
        path: 'sign-in',
        title: 'Sign in to TaskUp',
        component: SigninPageComponent
    }
];
