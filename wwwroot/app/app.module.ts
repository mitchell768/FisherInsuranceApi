import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import 'rxjs/Rx';

// import our application componet

import {AppComponent} from './app.components';
import {HomeComponent} from './components/home/home.component';
import {NavBarComponent} from './components/navbar/navbar.component';

@NgModule({
    declarations :[
        AppComponent,
        HomeComponent,
        NavBarComponent
    ],
    imports: [
        BrowserModule,
        HttpModule
    ],
    providers: [],
    bootstrap: [
        AppComponent
    ],

})

export class AppModule{}