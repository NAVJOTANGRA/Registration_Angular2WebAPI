import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component';
import { RegistrationComponent } from './reg.component';
import { CountryService } from './CountryService';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
    imports: [BrowserModule, HttpModule, FormsModule  ],
    declarations: [AppComponent, RegistrationComponent],
   
    bootstrap: [AppComponent]

})
export class AppModule { }
