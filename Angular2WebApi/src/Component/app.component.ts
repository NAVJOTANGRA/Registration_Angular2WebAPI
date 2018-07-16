import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
    template: `Hello {{name}}
<reg-form></reg-form>`,
    //templateUrl:'HTMLPages/app.component.html'
})
export class AppComponent  {
    
    name = 'Angular 2';
}
