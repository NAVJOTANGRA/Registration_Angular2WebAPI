import { Component } from '@angular/core';
import { ICountry, IState, ICity } from '../Interface/ICountry';
import { CountryService } from './CountryService';
//import { appService } from './app.service';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Promise } from 'q';

@Component({
    selector: 'reg-form',
    templateUrl: 'HTMLPages/reg.component.html',
    styleUrls: ['CSS/reg.component.css'],
    providers: [CountryService]
})

export class RegistrationComponent {
  public   param: any;
    Title = 'Registration';
    Country: ICountry[];
    myRadio: string='true';
    State: IState[];
    City: ICity[];
    public istrue: string = 'true';
    public firstName: string ;
    public middleName: string;
    public fatherName: string;
    public motherName: string;
    public ddlcountry: string;
    public ddlState: string;
    public ddlCity: string;
    public _UId: number;
    public objsearch: any;
    public _param: any;
    iproducts: ICountry[];
    constructor(private ServiceObject: CountryService) {
        console.log("Constructor Call");
    }
    ngOnInit(): void {
        var param;
        console.log("ngonint Call");
        //Bind Country Bind
        this.ServiceObject.getCountry()
       .subscribe(response => (this.Country) = response);

        //Bind State Bind
        this.ServiceObject.getState()
        .subscribe(response => (this.State) = response);

        //Bind City Bind
        this.ServiceObject.getCity()
            .subscribe(data  => (this.City) =data);
        console.log(this.City);
    }
    
    //On Submit button
    fnSubmit() {
       // this.param = 'asd';
        //this.param = {
        //    objsearch: [{ "Key": "FirstName", "value": this.firstName },
        //        { "Key": "MiddleName", "value": this.middleName },
        //        { "Key": "fatherName ", "value": this.fatherName },
        //        { "Key": "motherName", "value": this.motherName },
        //        { "Key": "_UId", "value": this._UId },
        //        { "Key": "Country", "value": this.ddlcountry },    
        //        { "Key": "State", "value": this.ddlState },    
        //        { "Key": "City", "value": this.ddlCity },    
        //    ]
        //}


       
        this.objsearch=[{ "Key": "FirstName", "value": this.firstName },
            { "Key": "MiddleName", "value": this.middleName },
            { "Key": "fatherName ", "value": this.fatherName },
            { "Key": "motherName", "value": this.motherName },
            { "Key": "_UId", "value": this._UId },
            { "Key": "Country", "value": this.ddlcountry },
            { "Key": "State", "value": this.ddlState },
            { "Key": "City", "value": this.ddlCity },
            { "Key": "City", "value": this.myRadio },
            ]

      
        this.objsearch = {
            firstName: this.firstName,
            middleName: this.middleName,
            fatherName: this.fatherName,
            motherName: this.motherName,
            _Uid: this._UId,
            country: this.ddlcountry,
            state: this.ddlState,
            city: this.ddlCity,
            gender: this.myRadio
            
        }
        
      
        this.ServiceObject.saveData((this.objsearch))
            .subscribe(response => (this._param) =response);
        console.log("result is");
        console.log(this._param);
    }
}
