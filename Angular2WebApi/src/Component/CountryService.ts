import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import { ICountry, IState, ICity } from '../Interface/ICountry';
import { posix } from 'path';

@Injectable()
export class CountryService {
    public localHostUrl = 'http://localhost:53915/';
    public _CoutryUrl = this.localHostUrl+'api/ComapnyAndProduct/GetCountryList';
    public _StateUrl = this.localHostUrl +'api/ComapnyAndProduct/GetStateList';
    public _CityUrl = this.localHostUrl +'api/ComapnyAndProduct/GetCityList';
    public _saveData = this.localHostUrl + 'api/ComapnyAndProduct/SaveRegistrationForm';
    public param: Array<string>;
    
    constructor(private _http: Http) { }
    
 //Bind Country Bind
    getCountry() {
        return this._http.get(this._CoutryUrl)  
       .map((response: Response) => <ICountry[]>response.json());}

     //Bind State Bind
    getState() {
        return this._http.get(this._StateUrl)
            .map((response: Response) => <IState[]>response.json());
    }

    //Bind City Bind
    getCity() {
        return this._http.get(this._CityUrl)
            .map((response: Response) => <ICity[]>response.json());          
    }

    //Save Data in database(sqlServer)
    saveData(objSearch: any) {
        return this._http.post(this._saveData, objSearch)
            .map((response: Response) => response.json());
    }
    
}