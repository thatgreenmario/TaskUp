import { Routes } from '@angular/router';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { SigninPageComponent } from './signin-page/signin-page.component';
import { SignupPageComponent } from './signup-page/signup-page.component';

export const routes: Routes = [
    {
        path: '',
        title: 'TaskUp | Boost Productivity',
        component: LandingPageComponent 
    },
    {
        path: 'sign-in',
        title: 'Sign in to TaskUp',
        component: SigninPageComponent
    },
    {
        path: 'sign-up',
        title: 'Sign up for a free TaskUp account',
        component: SignupPageComponent
    }
];
